using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace Maple.Nexomon.Metadata
{
    public static class NexomonEnvironmentExtensions
    {
        static List<GameInventoryDisplayDTO> ListItems { get; } = new List<GameInventoryDisplayDTO>(1024);
        static List<GameInventoryDisplayDTO> ListMonsters { get; } = new List<GameInventoryDisplayDTO>(1024);

        enum EnumGameInventoryType
        {
            Item = 0,
            Monster = 1,
        }

        public static NexomonEnvironment GetNexomonEnvironment(this NexomonMetadataContext context)
            => new(context);

        public static void LoadGameData(this NexomonEnvironment @this)
        {
            using (@this.Context.Logger.Running())
            {
                @this.WaitGameData();
                ListItems.AddRange(@this.EnumItems());
                ListMonsters.AddRange(@this.EnumMonsters());
            }
        }

        static IEnumerable<GameInventoryDisplayDTO> EnumItems(this NexomonEnvironment @this)
        {
            foreach (var item in @this.DatabaseItems.DATA.AsRefArray())
            {
                var itemEntry = item.Value;
                var itemData = new GameInventoryDisplayDTO()
                {

                    ObjectId = itemEntry.ID.GET_DECRYPTED().ToString()!,
                    DisplayName = itemEntry.GET_LOCALIZED_NAME().ToString(),
                    DisplayCategory = nameof(EnumGameInventoryType.Item),
                    DisplayDesc = $"{itemEntry.GET_LOCALIZED_CATEGORY_NAME(false)}:{itemEntry.GET_LOCALIZED_DESCRIPTION()}",
                };
                @this.Context.Logger.LogInformation("{key}:{id}=>{name}=>{cate}=>{desc}",
                    item.Key.ToString(), itemData.ObjectId,
                    itemData.DisplayName,
                    itemData.DisplayCategory,
                    itemData.DisplayDesc);
                yield return itemData;
            }
        }

        static IEnumerable<GameInventoryDisplayDTO> EnumMonsters(this NexomonEnvironment @this)
        {
            foreach (var item in @this.DatabaseMonsters.DATA)
            {

                var itemData = new GameInventoryDisplayDTO()
                {
                    ObjectId = item.UNIQUE_ID.ToString(),
                    DisplayName = item.GET_LOCALIZED_NAME().ToString(),
                    DisplayCategory = nameof(EnumGameInventoryType.Monster),
                    DisplayDesc = item.GET_LOCALIZED_DESCRIPTION().ToString(),
                };
                @this.Context.Logger.LogInformation("{id}=>{name}=>{cate}=>{desc}",
                    itemData.ObjectId,
                    itemData.DisplayName,
                    itemData.DisplayCategory,
                    itemData.DisplayDesc);
                yield return itemData;
            }
        }

    }
}
