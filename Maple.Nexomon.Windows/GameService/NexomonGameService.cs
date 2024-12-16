using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Maple.Nexomon.Metadata;
using Microsoft.Extensions.Logging;

namespace Maple.Nexomon.Windows.GameService
{

    internal sealed partial class NexomonGameService(ILogger<NexomonGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<NexomonMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected sealed override NexomonMetadataContext LoadGameContext()
        {
            //    return NexomonMetadataContext.LoadGameContext(RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);

            return new NexomonMetadataContext(RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);
        }

        protected sealed override UnityEngineContext? LoadUnityEngineContext()
        {
            return new UnityEngineContext_IL2CPP(this.RuntimeContext, this.Logger);
        }

        public Task<NexomonEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(static p => p.GetNexomonEnvironment());
        }

        public async Task<NexomonEnvironment> GetGameEnvironmentThrowIfNotLoadedAsync()
        {
            var env = await GetGameEnvironmentAsync().ConfigureAwait(false);
            return env.InGame() ? env : GameException.ThrowIfNotLoaded<NexomonEnvironment>();
        }

        public sealed override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var gameEnv = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameCurrencyDisplays(), gameEnv).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameCurrencyInfo(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameCurrencyInfo(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnv = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            var items = await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
            foreach (var item in items)
            {
                if (this.GameSettings.TryGetGameResourceUrl(item.DisplayCategory!, $"{item.ObjectId}.png", out var url))
                {
                    item.DisplayImage = url;
                }
            }
            return items;
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            await this.MonoTaskAsync(static p => p.GetNexomonEnvironment().LoadGameDataThrowIfNotInit()).ConfigureAwait(false);
            return await base.GetSessionInfoAsync().ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            if (UnityEngineContext is not null)
            {
                //   await this.MonoTaskAsync(static (p, args) => args.SetAllGameInventoryInfo(), (gameEnv)).ConfigureAwait(false);
                var images = await this.UITaskAsync((p, args) => GetImageDatas(args.gameEnv, args.UnityEngineContext).ToArray(), (gameEnv, this.UnityEngineContext)).ConfigureAwait(false);
                foreach (var image in images)
                {
                    this.GameSettings.WriteImageFile(image.ImageData.AsReadOnlySpan(), image.Category, $"{image.Name}.png");
                }
            }
            return await base.LoadResourceAsync().ConfigureAwait(false);
        }

        static IEnumerable<UnitySpriteImageData> GetImageDatas(NexomonEnvironment @this, UnityEngineContext unityEngineContext)
        {
            foreach (var monster in @this.Context.Cache.PREVIEWS.AsRefArray())
            {
                var image = unityEngineContext.ReadSprite2Png(monster.Value, 2);
                if (image.Valid())
                {
                    yield return new UnitySpriteImageData()
                    {
                        Name = monster.Key.UNIQUE_ID.ToString(),
                        Category = NexomonEnvironmentExtensions.EnumGameInventoryType.Monster.ToString(),
                        ImageData = image
                    };
                }
            }
            foreach (var monster in @this.Context.Cache.ITEM_ICONS.AsRefArray())
            {
                var image = unityEngineContext.ReadSprite2Png(monster.Value, 2);
                if (image.Valid())
                {
                    yield return new UnitySpriteImageData()
                    {
                        Name = monster.Key.ID.GET_DECRYPTED().ToString(),
                        Category = NexomonEnvironmentExtensions.EnumGameInventoryType.Item.ToString(),
                        ImageData = image
                    };
                }
            }

            foreach (var monster in @this.Context.Cache.MINIS.AsRefArray())
            {
                var image = unityEngineContext.ReadSprite2Png(monster.Value, 2);
                if (image.Valid())
                {
                    yield return new UnitySpriteImageData()
                    {
                        Name = monster.Key.ToString(),
                        Category = "MINIS",
                        ImageData = image
                    };
                }
            }
            foreach (var monster in @this.Context.Cache.JOURNAL_PICTURES.AsRefArray())
            {
                var image = unityEngineContext.ReadSprite2Png(monster.Value, 2);
                if (image.Valid())
                {
                    yield return new UnitySpriteImageData()
                    {
                        Name = monster.Key.ToString(),
                        Category = "JOURNAL_PICTURES",
                        ImageData = image
                    };
                }
            }
            foreach (var monster in @this.Context.Cache.PORTRAITS.AsRefArray())
            {
                var image = unityEngineContext.ReadSprite2Png(monster.Value, 2);
                if (image.Valid())
                {
                    yield return new UnitySpriteImageData()
                    {
                        Name = monster.Key.ToString(),
                        Category = "PORTRAITS",
                        ImageData = image
                    };
                }
            }



        }




    }
}
