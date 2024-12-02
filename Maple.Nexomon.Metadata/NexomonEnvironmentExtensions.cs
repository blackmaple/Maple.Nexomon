using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

        public static void LoadGameDataThrowIfNotInit(this NexomonEnvironment @this)
        {
            using (@this.Context.Logger.Running())
            {
                var items = @this.EnumItems().ToArray();
                var itemCount = items.Length;
                if (itemCount <= 0)
                {
                    GameException.Throw("NOT INIT:DatabaseItems");
                }

                var monsters = @this.EnumMonsters().ToArray();
                var monsterCount = monsters.Length;
                if (monsterCount <= 0)
                {
                    GameException.Throw("NOT INIT:DatabaseMonsters");
                }

                ListItems.AddRange(items);
                ListMonsters.AddRange(monsters);
                @this.Context.Logger.LogInformation("EnumMonsters:{c}", monsterCount);
                @this.Context.Logger.LogInformation("EnumItems:{c}", itemCount);

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
                //@this.Context.Logger.LogInformation("{id}=>{name}=>{cate}=>{desc}",
                //  itemData.ObjectId,
                //    itemData.DisplayName,
                //    itemData.DisplayCategory,
                //    itemData.DisplayDesc);
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
                //@this.Context.Logger.LogInformation("{id}=>{name}=>{cate}=>{desc}",
                //    itemData.ObjectId,
                //    itemData.DisplayName,
                //    itemData.DisplayCategory,
                //    itemData.DisplayDesc);
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

        public unsafe static GameCurrencyInfoDTO GetGameCurrencyInfo(this NexomonEnvironment @this, GameCurrencyObjectDTO objectDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(objectDTO.CurrencyObject, out var enumObject))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{objectDTO.CurrencyObject}");
            }
            if (enumObject == EnumGameCurrencyType.COINS)
            {
                int count = @this.Ptr_Wallet.COINS.GetDecryptValue();
                return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, DisplayValue = count.ToString() };

            }
            else if (enumObject == EnumGameCurrencyType.DIAMONDS)
            {
                var count = @this.Ptr_Wallet.DIAMONDS.GetDecryptValue();
                return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, DisplayValue = count.ToString() };
            }
            else if (enumObject == EnumGameCurrencyType.TOKENS)
            {
                var count = @this.Ptr_Wallet.TOKENS.GetDecryptValue();
                return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, DisplayValue = count.ToString() };
            }
            return new GameCurrencyInfoDTO() { ObjectId = objectDTO.CurrencyObject, };
        }

        public static GameCurrencyInfoDTO UpdateGameCurrencyInfo(this NexomonEnvironment @this, GameCurrencyModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(modifyDTO.CurrencyObject, out var enumObject))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{modifyDTO.CurrencyObject}");
            }

            if (enumObject == EnumGameCurrencyType.COINS)
            {
                var val = @this.Ptr_Wallet.SetCoins(modifyDTO.IntValue);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, DisplayValue = val.ToString() };
            }
            else if (enumObject == EnumGameCurrencyType.DIAMONDS)
            {
                var val = @this.Ptr_Wallet.SetDiamonds(modifyDTO.IntValue);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, DisplayValue = val.ToString() };
            }
            else if (enumObject == EnumGameCurrencyType.TOKENS)
            {
                var val = @this.Ptr_Wallet.SetTokens(modifyDTO.IntValue);
                return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, DisplayValue = val.ToString() };
            }
            return new GameCurrencyInfoDTO() { ObjectId = modifyDTO.CurrencyObject, };




        }


        public static GameInventoryDisplayDTO[] GetGameInventoryDisplays(this NexomonEnvironment @this)
        {
            return [.. ListItems, .. ListMonsters];
        }

        static bool TryGetDatabaseItem(this NexomonEnvironment @this, ReadOnlySpan<char> objectId, out DatabaseItems_Entry.Ptr_DatabaseItems_Entry ptr_DatabaseItems_Entry)
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
        static bool TryGetDatabaseMonster(this NexomonEnvironment @this, int objectId, out DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry ptr_DatabaseMonsters_Entry)
        {
            Unsafe.SkipInit(out ptr_DatabaseMonsters_Entry);
            foreach (var item in @this.DatabaseMonsters.DATA)
            {
                if (item.UNIQUE_ID == objectId)
                {
                    ptr_DatabaseMonsters_Entry = item;
                    return true;

                }
            }
            return false;
        }

        static int GetOwnedItemCount(this NexomonEnvironment @this, ReadOnlySpan<char> objectId)
        {
            //var metadata = @this.Context.Inventory.ClassInfo.FieldInfos.Where(p => p.Name.AsSpan().Contains("content", StringComparison.OrdinalIgnoreCase))
            //    .FirstOrDefault();
            //if (metadata is not null)
            //{
            //    @this.Context.Logger.LogInformation("metadata:{i} ", metadata.Name);
            //    foreach (var f in @this.Context.RuntimeContext.EnumMonoFields(metadata.FieldType.Pointer, MonoGameAssistant.Model.EnumMonoFieldOptions.EnumAndConst))
            //    {
            //        @this.Context.Logger.LogInformation("{f}={o}", f.Name, f.RawOffset);
            //    }
            //}
            //@this.Context.Logger.LogInformation("find:{i} ", objectId.ToString());

            foreach (var item in @this.Ptr_Inventory.CONTENT.AsRefArray())
            {
            //    @this.Context.Logger.LogInformation("enum:{i}", item.Key.GET_DECRYPTED().ToString());
                if (item.Key.GET_DECRYPTED().AsReadOnlySpan().SequenceEqual(objectId))
                {
         //           @this.Context.Logger.LogInformation("GetOwnedItemCount:{k}^{h}={v}", item.Value.currentCryptoKey, item.Value.hiddenValue, item.Value.currentCryptoKey ^ item.Value.hiddenValue);
                    return item.Value.GetDecryptValue();
                }
            }
            return 0;
        }
        static bool GetOwnedMonsterCount(this NexomonEnvironment @this, int objectId)
        {
            foreach (var item in @this.Ptr_SaveData.OWNED_MONSTERS.AsRefArray())
            {
                if (item.Value.UNIQUE_ID == objectId)
                {
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
            if (enumObject == EnumGameInventoryType.Item && @this.TryGetDatabaseItem(objectDTO.InventoryObject, out var _))
            {
                return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = @this.GetOwnedItemCount(objectDTO.InventoryObject) };
            }
            else if (enumObject == EnumGameInventoryType.Monster && int.TryParse(objectDTO.InventoryObject, out var objectId) && @this.TryGetDatabaseMonster(objectId, out var ptr_DatabaseMonsters_Entry))
            {
                return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = @this.GetOwnedMonsterCount(ptr_DatabaseMonsters_Entry.UNIQUE_ID) ? 1 : 0 };

            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = -1 };
        }


        public static GameInventoryInfoDTO UpdateGameInventoryInfo(this NexomonEnvironment @this, GameInventoryModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameInventoryType>(modifyDTO.InventoryCategory, out var enumObject))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{modifyDTO.InventoryCategory}");
            }
            if (enumObject == EnumGameInventoryType.Item && @this.TryGetDatabaseItem(modifyDTO.InventoryObject, out var ptr_DatabaseItems_Entry))
            {
                @this.Ptr_SaveData.INVENTORY.COMPLETELY_REMOVE_ITEM_00(ptr_DatabaseItems_Entry);
                var count = Ref_ObscuredInt.New(modifyDTO.InventoryCount);
                @this.Ptr_SaveData.INVENTORY.ADD_ITEM_00(ptr_DatabaseItems_Entry, MapleRef<Ref_ObscuredInt>.FromRef(ref count));
                return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = modifyDTO.InventoryCount };
            }
            else if (enumObject == EnumGameInventoryType.Monster && int.TryParse(modifyDTO.InventoryObject, out var objectId) && @this.TryGetDatabaseMonster(objectId, out var ptr_DatabaseMonsters_Entry))
            {
                @this.Ptr_SaveData.REPORT_SEEN_NEXOMON(ptr_DatabaseMonsters_Entry);
                @this.Ptr_SaveData.REPORT_CAPTURED_NEXOMON(ptr_DatabaseMonsters_Entry);
                return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = 1 };
            }
            return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = -1 };

        }
    }



    partial class ObscuredInt
    {

        unsafe partial struct Ref_ObscuredInt
        {
            //[System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
            //public readonly long bak;

            public Ptr_ObscuredInt AsPtr()
            {
                return Unsafe.AsRef(ref this).AsPointer();
            }

            public static implicit operator int(Ref_ObscuredInt ref_ObscuredInt) => ref_ObscuredInt.GetDecryptValue();

            public readonly int GetDecryptValue() => this.hiddenValue ^ this.currentCryptoKey;

            public void SetDecryptValue(int v) => this.hiddenValue = v ^ this.currentCryptoKey;

            public Ref_ObscuredInt Init(int v)
            {
                var key = DateTime.Now.Second;
                this.currentCryptoKey = key;
                this.hiddenValue = v ^ key;
                this.inited = true;
                this.fakeValue = v;
                this.fakeValueActive = true;
                return this;
            }

            public static Ref_ObscuredInt New(int v) => new Ref_ObscuredInt().Init(v);


        }

        unsafe partial struct Ptr_ObscuredInt
        {
            public static Ref_ObscuredInt SetDecryptValue(int n)
            {
                Ref_ObscuredInt ref_ObscuredInt = new();
                ref_ObscuredInt.AsPtr().CTOR(n);
                return ref_ObscuredInt;
            }
        }
    }

    partial class Wallet
    {


        unsafe partial struct Ptr_Wallet
        {
            public int SetDiamonds(int v)
            {
                ref var data = ref GetMemberFieldValue<Maple.Nexomon.Metadata.ObscuredInt.Ref_ObscuredInt>(this, FieldOffset_DIAMONDS);
                data.hiddenValue = v ^ data.currentCryptoKey;
                return v;
            }

            public int SetCoins(int v)
            {
                ref var data = ref GetMemberFieldValue<Maple.Nexomon.Metadata.ObscuredInt.Ref_ObscuredInt>(this, FieldOffset_COINS);
                data.hiddenValue = v ^ data.currentCryptoKey;
                return v;
            }

            public int SetTokens(int v)
            {
                ref var data = ref GetMemberFieldValue<Maple.Nexomon.Metadata.ObscuredInt.Ref_ObscuredInt>(this, FieldOffset_TOKENS);
                data.hiddenValue = v ^ data.currentCryptoKey;
                return v;
            }

        }
    }
}
