namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Custom"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000052U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [67, 117, 115, 116, 111, 109])]


// struct 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredByte encryptionKeyActivation
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte),"encryptionKeyActivation", "ENCRYPTION_KEY_ACTIVATION")]

// struct 0x15 CodeStage.AntiCheat.ObscuredTypes.ObscuredByte encryptionKeySettingID
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte),"encryptionKeySettingID", "ENCRYPTION_KEY_SETTING_ID")]

// struct 0x1C CodeStage.AntiCheat.ObscuredTypes.ObscuredInt encryptionKeyVariables
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"encryptionKeyVariables", "ENCRYPTION_KEY_VARIABLES")]

// struct 0x30 CodeStage.AntiCheat.ObscuredTypes.ObscuredLong encryptionKeyChecksum
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong),"encryptionKeyChecksum", "ENCRYPTION_KEY_CHECKSUM")]

// struct 0x58 CodeStage.AntiCheat.ObscuredTypes.ObscuredBool active
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool),"active", "ACTIVE")]

// struct 0x64 CodeStage.AntiCheat.ObscuredTypes.ObscuredBool hasAnyDataBeenCopiedOnce
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool),"hasAnyDataBeenCopiedOnce", "HAS_ANY_DATA_BEEN_COPIED_ONCE")]

// struct 0x70 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt seed
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"seed", "SEED")]

// class 0x88 System.Collections.Generic.Dictionary<Custom.SETTING_ID,CodeStage.AntiCheat.ObscuredTypes.ObscuredBool> toggles
// [MonoCollectorSearchFieldAttribute(typeof(nint),"toggles", "TOGGLES")]

// class 0x90 System.Collections.Generic.Dictionary<Custom.SETTING_ID,CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> variables
// [MonoCollectorSearchFieldAttribute(typeof(nint),"variables", "VARIABLES")]

// class 0x98 System.Collections.Generic.HashSet<System.Int32> mapsDisabledFromCapturing
// [MonoCollectorSearchFieldAttribute(typeof(nint),"mapsDisabledFromCapturing", "MAPS_DISABLED_FROM_CAPTURING")]

// class 0xA0 System.Collections.Generic.Dictionary<Custom.SETTING_ID,CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> configuration
// [MonoCollectorSearchFieldAttribute(typeof(nint),"configuration", "CONFIGURATION")]
public partial class Custom
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Custom";
    //public static byte[] Static_ClassName { get; } = [67, 117, 115, 116, 111, 109];

    //public const uint Const_TypeToken = 0x02000052U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Custom(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Custom(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Custom obj) => obj._ptr;
        public static implicit operator bool(Ptr_Custom obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Custom"]
/// </summary>
public partial class Custom
{



    /// <summary>
    /// static  SaveData <ExecuteDataCopies>g__GetDataSource|21_0(System.Int32 slotNumber, Custom.<>c__DisplayClass21_0& , Custom.<>c__DisplayClass21_1& )
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <param name="">struct Custom.<>c__DisplayClass21_0&</param>
    /// <param name="">struct Custom.<>c__DisplayClass21_1&</param>
    /// <returns>class SaveData</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<ExecuteDataCopies>g__GetDataSource|21_0")]
    /// static extern nint <EXECUTE_DATA_COPIES>G__GET_DATA_SOURCE|21_0 (System.Int32 slotNumber, Custom.<>c__DisplayClass21_0& , Custom.<>c__DisplayClass21_1& );


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool AllowHighTierEncounters()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllowHighTierEncounters")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ALLOW_HIGH_TIER_ENCOUNTERS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool CanUseCapture(System.Int32 mapID)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseCapture")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool CAN_USE_CAPTURE (System.Int32 mapID);


    /// <summary>
    ///   System.Void ConsiderPermadeadParty()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConsiderPermadeadParty")]
    ///  extern void CONSIDER_PERMADEAD_PARTY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool DidCopyAnyData()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DidCopyAnyData")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool DID_COPY_ANY_DATA ();


    /// <summary>
    ///   System.Void DisableMapFromCapturing(System.Int32 mapID)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DisableMapFromCapturing")]
    ///  extern void DISABLE_MAP_FROM_CAPTURING (System.Int32 mapID);


    /// <summary>
    ///   System.Boolean ExecuteDataCopies(SaveData destinationData)
    /// </summary>
    /// <param name="destinationData">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteDataCopies")]
    ///  extern System.Boolean EXECUTE_DATA_COPIES (nint destinationData);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetEXPGainMultiplier()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEXPGainMultiplier")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_EXP_GAIN_MULTIPLIER ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetExtraDifficultyWeight()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExtraDifficultyWeight")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_EXTRA_DIFFICULTY_WEIGHT ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetExtraTamerIncomeMultiplier()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExtraTamerIncomeMultiplier")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_EXTRA_TAMER_INCOME_MULTIPLIER ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetExtraWildIncomeMultiplier()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExtraWildIncomeMultiplier")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_EXTRA_WILD_INCOME_MULTIPLIER ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetHowManyItemsCanBeUsedPerBattle()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHowManyItemsCanBeUsedPerBattle")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_HOW_MANY_ITEMS_CAN_BE_USED_PER_BATTLE ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetLevelCap()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLevelCap")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_LEVEL_CAP ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetNumberOfCopiedItems()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNumberOfCopiedItems")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_NUMBER_OF_COPIED_ITEMS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetNumberOfCopiedStorageUnits()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNumberOfCopiedStorageUnits")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_NUMBER_OF_COPIED_STORAGE_UNITS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetNumberOfCopiedTeamUnits()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNumberOfCopiedTeamUnits")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_NUMBER_OF_COPIED_TEAM_UNITS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSeed()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSeed")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_SEED ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSlotNumberToCopyInventoryFrom()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSlotNumberToCopyInventoryFrom")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_SLOT_NUMBER_TO_COPY_INVENTORY_FROM ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSlotNumberToCopyPartyFrom()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSlotNumberToCopyPartyFrom")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_SLOT_NUMBER_TO_COPY_PARTY_FROM ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSlotNumberToCopyStorageFrom()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSlotNumberToCopyStorageFrom")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_SLOT_NUMBER_TO_COPY_STORAGE_FROM ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetStartingLevelForPlayerUnits()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStartingLevelForPlayerUnits")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_STARTING_LEVEL_FOR_PLAYER_UNITS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GetToggleIfExistsAndCustomModeIsActive(Custom.SETTING_ID key, System.Boolean defaultValue)
    /// </summary>
    /// <param name="key">enum Custom.SETTING_ID</param>
    /// <param name="defaultValue">struct System.Boolean</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetToggleIfExistsAndCustomModeIsActive")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GET_TOGGLE_IF_EXISTS_AND_CUSTOM_MODE_IS_ACTIVE (Custom.SETTING_ID key, System.Boolean defaultValue);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetVariableIfExistsAndCustomModeIsActive(Custom.SETTING_ID key, System.Int32 defaultValue)
    /// </summary>
    /// <param name="key">enum Custom.SETTING_ID</param>
    /// <param name="defaultValue">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetVariableIfExistsAndCustomModeIsActive")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_VARIABLE_IF_EXISTS_AND_CUSTOM_MODE_IS_ACTIVE (Custom.SETTING_ID key, System.Int32 defaultValue);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsActive()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_ACTIVE ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsLocked()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLocked")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_LOCKED ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsRandomizingSkilltreesInAnyWay()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRandomizingSkilltreesInAnyWay")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_RANDOMIZING_SKILLTREES_IN_ANY_WAY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsRandomizingStartersInAnyWay()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRandomizingStartersInAnyWay")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_RANDOMIZING_STARTERS_IN_ANY_WAY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsRandomizingTamerPartiesInAnyWay()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRandomizingTamerPartiesInAnyWay")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_RANDOMIZING_TAMER_PARTIES_IN_ANY_WAY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IsThisSaveFileLockedDueToPermadeath()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsThisSaveFileLockedDueToPermadeath")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool IS_THIS_SAVE_FILE_LOCKED_DUE_TO_PERMADEATH ();


    /// <summary>
    ///   System.Void RemovePermadeathLock()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePermadeathLock")]
    ///  extern void REMOVE_PERMADEATH_LOCK ();


    /// <summary>
    ///   System.Void SetActive(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetActive")]
    ///  extern void SET_ACTIVE (CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);


    /// <summary>
    ///   System.Void SetSeed(System.Int32 desiredSeed)
    /// </summary>
    /// <param name="desiredSeed">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSeed")]
    ///  extern void SET_SEED (System.Int32 desiredSeed);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldAllowCaptureOnlyOnFirstMapEncounter()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldAllowCaptureOnlyOnFirstMapEncounter")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_ALLOW_CAPTURE_ONLY_ON_FIRST_MAP_ENCOUNTER ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldDisableFlee()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldDisableFlee")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_DISABLE_FLEE ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldDisableShops()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldDisableShops")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_DISABLE_SHOPS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldLockFileOnGameOver()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldLockFileOnGameOver")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_LOCK_FILE_ON_GAME_OVER ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldMutateTamerPartiesPerDefeat()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldMutateTamerPartiesPerDefeat")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_MUTATE_TAMER_PARTIES_PER_DEFEAT ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldPermanentlyFaintNexomon()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldPermanentlyFaintNexomon")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_PERMANENTLY_FAINT_NEXOMON ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeMonsterDistributions()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeMonsterDistributions")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_MONSTER_DISTRIBUTIONS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeMonsterEncountersCompletely()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeMonsterEncountersCompletely")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_MONSTER_ENCOUNTERS_COMPLETELY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeOreBoulders()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeOreBoulders")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_ORE_BOULDERS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeOverworldItems()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeOverworldItems")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_OVERWORLD_ITEMS ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeSkilltreesButKeepOriginalElement()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeSkilltreesButKeepOriginalElement")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_SKILLTREES_BUT_KEEP_ORIGINAL_ELEMENT ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeSkilltreesCompletely()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeSkilltreesCompletely")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_SKILLTREES_COMPLETELY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeStarterOptionsAnyTierExcludingLegendaries()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeStarterOptionsAnyTierExcludingLegendaries")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_STARTER_OPTIONS_ANY_TIER_EXCLUDING_LEGENDARIES ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeStarterOptionsAnyTierIncludingLegendaries()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeStarterOptionsAnyTierIncludingLegendaries")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_STARTER_OPTIONS_ANY_TIER_INCLUDING_LEGENDARIES ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeStarterOptionsToTierOneOnly()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeStarterOptionsToTierOneOnly")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_STARTER_OPTIONS_TO_TIER_ONE_ONLY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeStoryBosses()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeStoryBosses")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_STORY_BOSSES ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeTamerPartiesButKeepOriginalTierLevel()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeTamerPartiesButKeepOriginalTierLevel")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_TAMER_PARTIES_BUT_KEEP_ORIGINAL_TIER_LEVEL ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeTamerPartiesButUseEqualOrGreaterTierLevel()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeTamerPartiesButUseEqualOrGreaterTierLevel")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_TAMER_PARTIES_BUT_USE_EQUAL_OR_GREATER_TIER_LEVEL ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRandomizeTamerPartiesCompletely()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRandomizeTamerPartiesCompletely")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_RANDOMIZE_TAMER_PARTIES_COMPLETELY ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ShouldRevertEvolutionStagesAfterCopying()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldRevertEvolutionStagesAfterCopying")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SHOULD_REVERT_EVOLUTION_STAGES_AFTER_COPYING ();


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   System.Void ToBinaryDeprecated(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinaryDeprecated")]
    ///  extern void TO_BINARY_DEPRECATED (nint writer);



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Custom))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Custom))]
    ///  extern void .CTOR_01 (nint reader);


    /// public static partial class Search_Custom
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.IO.BinaryReader");
    ///     
    ///  
    /// 
    /// 
    /// }

}
