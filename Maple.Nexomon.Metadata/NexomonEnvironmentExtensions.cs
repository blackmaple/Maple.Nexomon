using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Maple.Nexomon.Metadata.DatabaseItems_Entry;
using static Maple.Nexomon.Metadata.ObscuredInt;

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
        enum EnumGameCurrencyType
        {
            COINS = 0,
            DIAMONDS = 1,
            TOKENS,
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

                    ObjectId = item.Key.ToString()!,//itemEntry.ID.GET_DECRYPTED().ToString()!,
                    DisplayName = itemEntry.GET_LOCALIZED_NAME().ToString(),
                    DisplayCategory = nameof(EnumGameInventoryType.Item),
                    DisplayDesc = $"{itemEntry.GET_LOCALIZED_CATEGORY_NAME(false)}:{itemEntry.GET_LOCALIZED_DESCRIPTION()}",
                };
                @this.Context.Logger.LogInformation("{id}=>{name}=>{cate}=>{desc}",
                  itemData.ObjectId,
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


        public static GameCurrencyDisplayDTO[] GetGameCurrencyDisplays(this NexomonEnvironment @this)
        {
            return [
                new GameCurrencyDisplayDTO(){ ObjectId = nameof(EnumGameCurrencyType.COINS),DisplayCategory= nameof(EnumGameCurrencyType.COINS), DisplayName = nameof(EnumGameCurrencyType.COINS),DisplayDesc = ""},
                new GameCurrencyDisplayDTO(){ ObjectId = nameof(EnumGameCurrencyType.DIAMONDS),DisplayCategory =  nameof(EnumGameCurrencyType.DIAMONDS), DisplayName = nameof(EnumGameCurrencyType.DIAMONDS),DisplayDesc = ""},
                new GameCurrencyDisplayDTO(){ ObjectId = nameof(EnumGameCurrencyType.TOKENS), DisplayCategory =nameof(EnumGameCurrencyType.TOKENS), DisplayName = nameof(EnumGameCurrencyType.TOKENS),DisplayDesc = ""}
                ];
        }

        public static GameCurrencyInfoDTO GetGameCurrencyInfo(this NexomonEnvironment @this, GameCurrencyObjectDTO objectDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(objectDTO.CurrencyObject, out var enumObject))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{objectDTO.CurrencyObject}");
            }
            return new GameCurrencyInfoDTO()
            {
                ObjectId = objectDTO.CurrencyObject,
                Currency = enumObject switch
                {
                    EnumGameCurrencyType.COINS => Ptr_ObscuredInt.GetDecryptValue(@this.Ptr_SaveData.WALLET.GET_COINS()),
                    EnumGameCurrencyType.DIAMONDS => Ptr_ObscuredInt.GetDecryptValue(@this.Ptr_SaveData.WALLET.GET_DIAMONDS()),
                    EnumGameCurrencyType.TOKENS => Ptr_ObscuredInt.GetDecryptValue(@this.Ptr_SaveData.WALLET.GET_TOKENS()),
                    _ => 0
                }
            };
        }

        public static GameCurrencyInfoDTO UpdateGameCurrencyInfo(this NexomonEnvironment @this, GameCurrencyModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(modifyDTO.CurrencyObject, out var enumObject))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{modifyDTO.CurrencyObject}");
            }

            if (enumObject == EnumGameCurrencyType.COINS)
            {
                var value = @this.Ptr_SaveData.WALLET.GET_COINS();
                @this.Ptr_SaveData.WALLET.SPEND_COINS(value);
                Ptr_ObscuredInt.SetDecryptValue(ref value, modifyDTO.IntValue);
                @this.Ptr_SaveData.WALLET.RECEIVE_COINS(value, true);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, Currency = Ptr_ObscuredInt.GetDecryptValue(value) };
            }
            else if (enumObject == EnumGameCurrencyType.DIAMONDS)
            {
                var value = @this.Ptr_SaveData.WALLET.GET_DIAMONDS();
                @this.Ptr_SaveData.WALLET.SPEND_DIAMONDS(value);
                Ptr_ObscuredInt.SetDecryptValue(ref value, modifyDTO.IntValue);

                @this.Ptr_SaveData.WALLET.RECEIVE_DIAMONDS(value);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, Currency = Ptr_ObscuredInt.GetDecryptValue(value) };
            }
            else if (enumObject == EnumGameCurrencyType.DIAMONDS)
            {
                var value = @this.Ptr_SaveData.WALLET.GET_TOKENS();
                @this.Ptr_SaveData.WALLET.SPEND_TOKENS(value);
                Ptr_ObscuredInt.SetDecryptValue(ref value, modifyDTO.IntValue);

                @this.Ptr_SaveData.WALLET.RECEIVE_TOKENS(value);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, Currency = Ptr_ObscuredInt.GetDecryptValue(value) };
            }
            return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, };




        }


        public static GameInventoryDisplayDTO[] GetGameInventoryDisplays(this NexomonEnvironment @this)
        {
            return [.. ListItems, .. ListMonsters];
        }

        static bool TryGetItem(this NexomonEnvironment @this, ReadOnlySpan<char> objectId, out DatabaseItems_Entry.Ptr_DatabaseItems_Entry ptr_DatabaseItems_Entry)
        {
            Unsafe.SkipInit(out ptr_DatabaseItems_Entry);
            foreach (var item in @this.DatabaseItems.DATA.AsRefArray())
            {
                if (item.Key.AsReadOnlySpan().SequenceEqual(objectId))
                {
                    ptr_DatabaseItems_Entry = item.Value;
                    return true;
                }
            }
            return false;
        }
        static bool TryGetMonster(this NexomonEnvironment @this, ReadOnlySpan<char> objectId, out DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry ptr_DatabaseMonsters_Entry)
        {
            Unsafe.SkipInit(out ptr_DatabaseMonsters_Entry);
            foreach (var item in @this.Ptr_SaveData.OWNED_MONSTERS.AsRefArray())
            {
                if (item.Value.UNIQUE_ID.ToString().AsSpan().SequenceEqual(objectId))
                {
                    ptr_DatabaseMonsters_Entry = item.Value;
                    return true;

                }
            }
            return false;
        }
        public static GameInventoryInfoDTO GetGameInventoryInfo(this NexomonEnvironment @this, GameInventoryObjectDTO objectDTO)
        {
            if (!Enum.TryParse<EnumGameInventoryType>(objectDTO.InventoryCategory, out var enumObject))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{objectDTO.InventoryCategory}");
            }
            if (enumObject == EnumGameInventoryType.Item && @this.TryGetItem(objectDTO.InventoryObject, out var ptr_DatabaseItems_Entry))
            {
                return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = Ptr_ObscuredInt.GetDecryptValue(@this.Ptr_SaveData.INVENTORY.GET_QUANTITY_00(ptr_DatabaseItems_Entry)) };
            }
            else if (enumObject == EnumGameInventoryType.Monster)
            {
                return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = @this.TryGetMonster(objectDTO.InventoryObject, out _) ? 1 : 0 };
            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, };
        }


        public static GameInventoryInfoDTO UpdateGameInventoryInfo(this NexomonEnvironment @this, GameInventoryModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameInventoryType>(modifyDTO.InventoryCategory, out var enumObject))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{modifyDTO.InventoryCategory}");
            }
            if (enumObject == EnumGameInventoryType.Item && @this.TryGetItem(modifyDTO.InventoryObject, out var ptr_DatabaseItems_Entry))
            {
                @this.Ptr_SaveData.INVENTORY.COMPLETELY_REMOVE_ITEM_00(ptr_DatabaseItems_Entry);
                @this.Ptr_SaveData.INVENTORY.ADD_ITEM_00(ptr_DatabaseItems_Entry, ObscuredInt.Ptr_ObscuredInt.New(modifyDTO.InventoryCount));
                return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = Ptr_ObscuredInt.GetDecryptValue(@this.Ptr_SaveData.INVENTORY.GET_QUANTITY_00(ptr_DatabaseItems_Entry)) };
            }
            else if (enumObject == EnumGameInventoryType.Monster && @this.TryGetMonster(modifyDTO.InventoryObject, out var ptr_DatabaseMonsters_Entry))
            {
                @this.Ptr_SaveData.REPORT_SEEN_NEXOMON(ptr_DatabaseMonsters_Entry);
                @this.Ptr_SaveData.REPORT_RELEASE(ptr_DatabaseMonsters_Entry, true);

                return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = 1 };
            }
            return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, };

        }
    }



    partial class ObscuredInt
    {

        unsafe partial struct Ptr_ObscuredInt
        {
            public static int GetDecryptValue(in Ref_ObscuredInt ref_ObscuredInt)
            {
                return Ptr_ObscuredInt.DECRYPT_00(ref_ObscuredInt.hiddenValue, ref_ObscuredInt.currentCryptoKey);
            }

            public static void SetDecryptValue(ref Ref_ObscuredInt ref_ObscuredInt, int setValue)
            {
                ref_ObscuredInt.hiddenValue = Ptr_ObscuredInt.ENCRYPT_00(setValue, ref_ObscuredInt.currentCryptoKey);
            }

            public static Ref_ObscuredInt New(int n)
            {
                Ref_ObscuredInt val = new();
                var pointer = new nint(Unsafe.AsPointer(ref val));
                Ptr_ObscuredInt ptr_ObscuredInt = new(pointer);
                ptr_ObscuredInt.CTOR(n);
                return val;
            }
        }
    }

}
