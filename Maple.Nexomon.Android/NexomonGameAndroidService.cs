using Maple.MonoGameAssistant.AndroidCore;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.Nexomon.Metadata;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Maple.Nexomon.Android
{
    public sealed class NexomonGameAndroidService(
        ILogger<NexomonMetadataContext> logger,
        MonoCollectorApiService collectorApiService,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler monoTaskScheduler,
        MonoGameSettings gameSettings) : GameContextAndroidService<NexomonMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings)
    {
        MonoCollectorApiService ApiService { get; } = collectorApiService;

        protected override NexomonMetadataContext LoadGameContext()
        {
            return new NexomonMetadataContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger);
        }



        //protected override   ValueTask LoadGameDataAsync()
        //{

        //    //  await this.MonoTaskAsync(p => p.GetNexomonEnvironment().LoadGameData()).ConfigureAwait(false);
        //    //Dictionary<string, string[]> enumKey = new()
        //    //{
        //    //    //         ["Assembly-CSharp"] = ["SaveData", "DatabaseMonsters", "Entry", "Equipment", "DatabaseItems", "Custom", "SETTING_ID", "Inventory", "Wallet"],
        //    //    //      ["ACTk.Runtime"] = ["Obscured"]
        //    //    ["Assembly-CSharp"] = ["Unit", "StorageSystem", "Box"],
        //    //};
        //    //var basepath = "/sdcard/Download";
        //    //await foreach (var fileData in EnumClassContentAsync(enumKey).ConfigureAwait(false))
        //    //{
        //    //    var filepath = Path.Combine(basepath, $"{fileData.FullName}.cs");
        //    //    using var stream = File.CreateText(filepath);
        //    //    await stream.WriteLineAsync("namespace Maple.Nexomon.Metadata;").ConfigureAwait(false);
        //    //    foreach (var str in fileData.Content.GetChunks())
        //    //    {
        //    //        await stream.WriteAsync(str).ConfigureAwait(false);
        //    //    }

        //    //}

        //}

        //private async IAsyncEnumerable<ClassContent> EnumClassContentAsync(IReadOnlyDictionary<string, string[]> enumKey)
        //{



        //    var images = await this.ApiService.EnumMonoImagesAsync().ConfigureAwait(false);
        //    foreach (var image in images)
        //    {
        //        foreach (var key in enumKey)
        //        {
        //            if (image.Name.AsSpan().Contains(key.Key, StringComparison.OrdinalIgnoreCase))
        //            {
        //                var objs = await this.ApiService.EnumMonoObjectsAsync(image.Pointer).ConfigureAwait(false);

        //                foreach (var obj in objs)
        //                {

        //                    foreach (var objName in key.Value)
        //                    {
        //                        if (obj.Name.AsSpan().StartsWith(objName, StringComparison.OrdinalIgnoreCase))
        //                        {
        //                            var details = await this.ApiService.EnumMonoClassDetailAsync(obj.Pointer, EnumMonoFieldOptions.EnumAndConst).ConfigureAwait(false);
        //                            var content = MonoCollectorGeneratorV0.OutputStringBuilder(
        //                                   details.ClassInfoDTO,
        //                                   details.FieldInfos ?? [],
        //                                   details.MethodInfos ?? [],
        //                                   details.ParentClassInfos ?? [],
        //                                   details.InterfaceInfos ?? [], 256);

        //                            yield return new ClassContent() { FullName = details.ClassInfoDTO.FullName ?? Guid.CreateVersion7().ToString("N"), Content = content };


        //                        }


        //                    }
        //                }
        //            }

        //        }


        //    }

        //}
        //class ClassContent
        //{
        //    public required string FullName { set; get; }
        //    public required StringBuilder Content { set; get; }
        //}

        //public override async ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        //{
        //    await  this.MonoTaskAsync(p => p.GetNexomonEnvironment().LoadGameData()).ConfigureAwait(false);
        //    return await  base.GetSessionInfoAsync().ConfigureAwait(false);
        //}



        public Task<NexomonEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(static p => p.GetNexomonEnvironment());
        }

        public async Task<NexomonEnvironment> GetGameEnvironmentThrowIfNotLoadedAsync()
        {
            var env = await GetGameEnvironmentAsync().ConfigureAwait(false);
            return env.InGame() ? env : GameException.ThrowIfNotLoaded<NexomonEnvironment>();
        }

        public override async ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var gameEnv = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameCurrencyDisplays(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameCurrencyInfo(args.currencyObjectDTO), (gameEnv, currencyObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameCurrencyInfo(args.currencyModifyDTO), (gameEnv, currencyModifyDTO)).ConfigureAwait(false);
        }

        public override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnv = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.GetGameInventoryDisplays(), gameEnv).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.GetGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnv = await this.GetGameEnvironmentThrowIfNotLoadedAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync(static (p, args) => args.gameEnv.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameEnv, inventoryObjectDTO)).ConfigureAwait(false);
        }

        public override async ValueTask<GameSessionInfoDTO> GetSessionInfoAsync()
        {
            await this.MonoTaskAsync(static p => p.GetNexomonEnvironment().LoadGameDataThrowIfNotInit()).ConfigureAwait(false);
            return await base.GetSessionInfoAsync().ConfigureAwait(false);
        }
    }

}
