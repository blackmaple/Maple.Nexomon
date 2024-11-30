using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using static Maple.Nexomon.Metadata.DatabaseItems_Entry;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."SaveData"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000062U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 97, 118, 101, 68, 97, 116, 97])]

//  class static SaveData current
[MonoCollectorSearchFieldAttribute(typeof(SaveData.Ptr_SaveData), "current", "CURRENT", true)]

//  class static System.Collections.Generic.List<System.Int32> cadiumMapsWithZieglerMiasma
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"cadiumMapsWithZieglerMiasma", "CADIUM_MAPS_WITH_ZIEGLER_MIASMA", true)]

//  class static System.Collections.Generic.List<System.Int32> _abyssalMagicMazeSequenceToVenefelis
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"_abyssalMagicMazeSequenceToVenefelis", "_ABYSSAL_MAGIC_MAZE_SEQUENCE_TO_VENEFELIS", true)]

//  class static System.Collections.Generic.List<System.Int32> _abyssalMagicMazeSequenceToKroma
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"_abyssalMagicMazeSequenceToKroma", "_ABYSSAL_MAGIC_MAZE_SEQUENCE_TO_KROMA", true)]

//  class static System.Collections.Generic.List<System.Int32> _abyssalMagicMazeSequenceToLab
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"_abyssalMagicMazeSequenceToLab", "_ABYSSAL_MAGIC_MAZE_SEQUENCE_TO_LAB", true)]

// struct 0x10 System.Int32 _forcedDifficultyWeight
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_forcedDifficultyWeight", "_FORCED_DIFFICULTY_WEIGHT")]

// struct 0x14 System.Int32 slotNumber
[MonoCollectorSearchFieldAttribute(typeof(System.Int32), "slotNumber", "SLOT_NUMBER")]

// struct 0x18 System.Boolean error_isFromNewerVersionOfTheGame
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"error_isFromNewerVersionOfTheGame", "ERROR_IS_FROM_NEWER_VERSION_OF_THE_GAME")]

// struct 0x1C System.Int32 error_isFromNewerVersionOfTheGameVERSION
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"error_isFromNewerVersionOfTheGameVERSION", "ERROR_IS_FROM_NEWER_VERSION_OF_THE_GAME_VERSION")]

// struct 0x20 System.Boolean error_hadStreamException
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"error_hadStreamException", "ERROR_HAD_STREAM_EXCEPTION")]

// struct 0x21 System.Boolean error_streamWasNullOrEmpty
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"error_streamWasNullOrEmpty", "ERROR_STREAM_WAS_NULL_OR_EMPTY")]

// class 0x28 CodeStage.AntiCheat.ObscuredTypes.ObscuredString playerName
// [MonoCollectorSearchFieldAttribute(typeof(nint),"playerName", "PLAYER_NAME")]

// class 0x30 System.String playerBody
// [MonoCollectorSearchFieldAttribute(typeof(nint),"playerBody", "PLAYER_BODY")]

// class 0x38 System.String petBody
// [MonoCollectorSearchFieldAttribute(typeof(nint),"petBody", "PET_BODY")]

// struct 0x40 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt playerX
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"playerX", "PLAYER_X")]

// struct 0x54 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt playerY
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"playerY", "PLAYER_Y")]

// struct 0x68 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mapID
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"mapID", "MAP_ID")]

// class 0x80 System.String playerDirection
// [MonoCollectorSearchFieldAttribute(typeof(nint),"playerDirection", "PLAYER_DIRECTION")]

// class 0x88 System.String languageID
// [MonoCollectorSearchFieldAttribute(typeof(nint),"languageID", "LANGUAGE_ID")]

// struct 0x90 System.Int32 checkpointX
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"checkpointX", "CHECKPOINT_X")]

// struct 0x94 System.Int32 checkpointY
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"checkpointY", "CHECKPOINT_Y")]

// struct 0x98 System.Int32 checkpointMapID
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"checkpointMapID", "CHECKPOINT_MAP_ID")]

// class 0xA0 Party party
// [MonoCollectorSearchFieldAttribute(typeof(nint),"party", "PARTY")]

// class 0xA8 StorageSystem storage
// [MonoCollectorSearchFieldAttribute(typeof(nint),"storage", "STORAGE")]

// class 0xB0 Wallet wallet
[MonoCollectorSearchFieldAttribute(typeof(Wallet.Ptr_Wallet), "wallet", "WALLET")]

// class 0xB8 Inventory inventory
[MonoCollectorSearchFieldAttribute(typeof(Inventory.Ptr_Inventory), "inventory", "INVENTORY")]

// class 0xC0 BeatenTamers beatenTamers
// [MonoCollectorSearchFieldAttribute(typeof(nint),"beatenTamers", "BEATEN_TAMERS")]

// class 0xC8 Mining mining
// [MonoCollectorSearchFieldAttribute(typeof(nint),"mining", "MINING")]

// class 0xD0 Rematcher rematcher
// [MonoCollectorSearchFieldAttribute(typeof(nint),"rematcher", "REMATCHER")]

// class 0xD8 Achievements achievements
// [MonoCollectorSearchFieldAttribute(typeof(nint),"achievements", "ACHIEVEMENTS")]

// class 0xE0 Equipment equipment
[MonoCollectorSearchFieldAttribute(typeof(Equipment.Ptr_Equipment), "equipment", "EQUIPMENT")]

// class 0xE8 BeatenMonsters beatenMonsters
// [MonoCollectorSearchFieldAttribute(typeof(nint),"beatenMonsters", "BEATEN_MONSTERS")]

// class 0xF0 Custom custom
[MonoCollectorSearchFieldAttribute(typeof(Custom.Ptr_Custom), "custom", "CUSTOM")]

// class 0xF8 Luring luring
// [MonoCollectorSearchFieldAttribute(typeof(nint),"luring", "LURING")]

// class 0x100 PermanentlyDestroyedEntities permanentlyKilledEntities
// [MonoCollectorSearchFieldAttribute(typeof(nint),"permanentlyKilledEntities", "PERMANENTLY_KILLED_ENTITIES")]

// class 0x108 System.Collections.Generic.Dictionary<System.Int32,System.Boolean> switches
// [MonoCollectorSearchFieldAttribute(typeof(nint),"switches", "SWITCHES")]

// class 0x110 System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.String>> permanentlyKilledFlags
// [MonoCollectorSearchFieldAttribute(typeof(nint),"permanentlyKilledFlags", "PERMANENTLY_KILLED_FLAGS")]

// class 0x118 System.Collections.Generic.Dictionary<System.String,System.Int32> variables
// [MonoCollectorSearchFieldAttribute(typeof(nint),"variables", "VARIABLES")]

// struct 0x120 System.Int32 playtimeSeconds
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"playtimeSeconds", "PLAYTIME_SECONDS")]

// struct 0x124 System.Int32 volumeBGM
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"volumeBGM", "VOLUME_BGM")]

// struct 0x128 System.Int32 volumeSFX
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"volumeSFX", "VOLUME_SFX")]

// struct 0x12C System.Boolean autoSaveEnabled
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"autoSaveEnabled", "AUTO_SAVE_ENABLED")]

// class 0x130 System.Collections.Generic.HashSet<DatabaseMonsters.Entry> seenMonsters
// [MonoCollectorSearchFieldAttribute(typeof(nint),"seenMonsters", "SEEN_MONSTERS")]

// class 0x138 System.Collections.Generic.HashSet<DatabaseMonsters.Entry> ownedMonsters
[MonoCollectorSearchFieldAttribute(typeof(PMonoHashSet<Ref_MonoHashSet_OptimizationDefault, DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry, Ref_MonoSlot<DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry>>), "ownedMonsters", "OWNED_MONSTERS")]

// class 0x140 System.Collections.Generic.Queue<UINexoboxes.OpeningDefinition> temp_queuedNexoboxOpenings
// [MonoCollectorSearchFieldAttribute(typeof(nint),"temp_queuedNexoboxOpenings", "TEMP_QUEUED_NEXOBOX_OPENINGS")]

// struct 0x148 System.Boolean temp_isAcceptingNexoBoxOpeningAnimationEnqueues
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"temp_isAcceptingNexoBoxOpeningAnimationEnqueues", "TEMP_IS_ACCEPTING_NEXO_BOX_OPENING_ANIMATION_ENQUEUES")]

// class 0x150 System.Collections.Generic.List<System.Int32> temp_abyssalMagicMazePathSoFar
// [MonoCollectorSearchFieldAttribute(typeof(nint),"temp_abyssalMagicMazePathSoFar", "TEMP_ABYSSAL_MAGIC_MAZE_PATH_SO_FAR")]
public partial class SaveData
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "SaveData";
    //public static byte[] Static_ClassName { get; } = [83, 97, 118, 101, 68, 97, 116, 97];

    //public const uint Const_TypeToken = 0x02000062U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_SaveData(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_SaveData(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_SaveData obj) => obj._ptr;
        public static implicit operator bool(Ptr_SaveData obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."SaveData"]
/// </summary>
public partial class SaveData
{



    /// <summary>
    /// static  System.Void .cctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
    /// static extern void .CCTOR ();


    /// <summary>
    ///   System.Void .ctor(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Int32 slotNumber);


    /// <summary>
    /// static  System.Void <CompareDataFiles>g__Check|150_0(System.Boolean condition, System.String errorMessage, SaveData.<>c__DisplayClass150_0& )
    /// </summary>
    /// <param name="condition">struct System.Boolean</param>
    /// <param name="errorMessage">class System.String</param>
    /// <param name="">struct SaveData.<>c__DisplayClass150_0&</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<CompareDataFiles>g__Check|150_0")]
    /// static extern void <COMPARE_DATA_FILES>G__CHECK|150_0 (System.Boolean condition, nint errorMessage, SaveData.<>c__DisplayClass150_0& );


    /// <summary>
    /// static  System.Int32 <DumpInformation>g__ComputeCoreChecksum|135_0(System.Collections.Generic.List<DatabaseItems.Entry> cores)
    /// </summary>
    /// <param name="cores">class System.Collections.Generic.List<DatabaseItems.Entry></param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<DumpInformation>g__ComputeCoreChecksum|135_0")]
    /// static extern System.Int32 <DUMP_INFORMATION>G__COMPUTE_CORE_CHECKSUM|135_0 (nint cores);


    /// <summary>
    ///   System.Boolean <TakeAbyssalMagicMazeExit>g__HasPattern|143_0(System.Collections.Generic.List<System.Int32> pattern, System.Boolean allowWideDirection)
    /// </summary>
    /// <param name="pattern">class System.Collections.Generic.List<System.Int32></param>
    /// <param name="allowWideDirection">struct System.Boolean</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<TakeAbyssalMagicMazeExit>g__HasPattern|143_0")]
    ///  extern System.Boolean <TAKE_ABYSSAL_MAGIC_MAZE_EXIT>G__HAS_PATTERN|143_0 (nint pattern, System.Boolean allowWideDirection);


    /// <summary>
    ///   System.Void AddPermanentlyKilledFlag(System.Int32 mapID, System.String flag)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <param name="flag">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPermanentlyKilledFlag")]
    ///  extern void ADD_PERMANENTLY_KILLED_FLAG (System.Int32 mapID, nint flag);


    /// <summary>
    ///   System.Boolean AreAbyssalPrerequisitesMet()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreAbyssalPrerequisitesMet")]
    ///  extern System.Boolean ARE_ABYSSAL_PREREQUISITES_MET ();


    /// <summary>
    ///   System.Boolean AreTier2WildEncountersAllowed()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreTier2WildEncountersAllowed")]
    ///  extern System.Boolean ARE_TIER2_WILD_ENCOUNTERS_ALLOWED ();


    /// <summary>
    ///   System.Boolean AreTier3WildEncountersAllowed()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreTier3WildEncountersAllowed")]
    ///  extern System.Boolean ARE_TIER3_WILD_ENCOUNTERS_ALLOWED ();


    /// <summary>
    ///   System.Boolean AreWildAbyssalTyrantsEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildAbyssalTyrantsEnabled")]
    ///  extern System.Boolean ARE_WILD_ABYSSAL_TYRANTS_ENABLED ();


    /// <summary>
    ///   System.Boolean AreWildAbyssalWardensEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildAbyssalWardensEnabled")]
    ///  extern System.Boolean ARE_WILD_ABYSSAL_WARDENS_ENABLED ();


    /// <summary>
    ///   System.Boolean AreWildChaosSiblingsEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildChaosSiblingsEnabled")]
    ///  extern System.Boolean ARE_WILD_CHAOS_SIBLINGS_ENABLED ();


    /// <summary>
    ///   System.Boolean AreWildExtinctsEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildExtinctsEnabled")]
    ///  extern System.Boolean ARE_WILD_EXTINCTS_ENABLED ();


    /// <summary>
    ///   System.Boolean AreWildTyrantsEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildTyrantsEnabled")]
    ///  extern System.Boolean ARE_WILD_TYRANTS_ENABLED ();


    /// <summary>
    ///   System.Boolean AreWildWardensEnabled()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AreWildWardensEnabled")]
    ///  extern System.Boolean ARE_WILD_WARDENS_ENABLED ();


    /// <summary>
    ///   System.Boolean CanSynthesizeMaxCores()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanSynthesizeMaxCores")]
    ///  extern System.Boolean CAN_SYNTHESIZE_MAX_CORES ();


    /// <summary>
    ///   System.Boolean CanUseLureFeature()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUseLureFeature")]
    ///  extern System.Boolean CAN_USE_LURE_FEATURE ();


    /// <summary>
    ///   System.Boolean CanUsePortableWarpstone()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUsePortableWarpstone")]
    ///  extern System.Boolean CAN_USE_PORTABLE_WARPSTONE ();


    /// <summary>
    ///   System.Void ChangeFriendshipPoints(System.Int32 amount)
    /// </summary>
    /// <param name="amount">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeFriendshipPoints")]
    ///  extern void CHANGE_FRIENDSHIP_POINTS (System.Int32 amount);


    /// <summary>
    /// static  System.ValueTuple<System.Boolean,System.Boolean> CheckSaveDataType(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>struct System.ValueTuple<System.Boolean,System.Boolean></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckSaveDataType")]
    /// static extern System.ValueTuple<System.Boolean,System.Boolean> CHECK_SAVE_DATA_TYPE (System.Int32 slotNumber);


    /// <summary>
    ///   System.Void ClearAbyssalMagicMazeVisits()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearAbyssalMagicMazeVisits")]
    ///  extern void CLEAR_ABYSSAL_MAGIC_MAZE_VISITS ();


    /// <summary>
    ///   System.Void ClearFreeNexoBoxNonces()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearFreeNexoBoxNonces")]
    ///  extern void CLEAR_FREE_NEXO_BOX_NONCES ();


    /// <summary>
    ///   System.Void ClearGlobalSwitchesRelatedToAbyssalExpansion1000to1900()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearGlobalSwitchesRelatedToAbyssalExpansion1000to1900")]
    ///  extern void CLEAR_GLOBAL_SWITCHES_RELATED_TO_ABYSSAL_EXPANSION1000TO1900 ();


    /// <summary>
    ///   System.Void ClearGlobalSwitchesRelatedToAbyssalStoryExpansion1003to1900()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearGlobalSwitchesRelatedToAbyssalStoryExpansion1003to1900")]
    ///  extern void CLEAR_GLOBAL_SWITCHES_RELATED_TO_ABYSSAL_STORY_EXPANSION1003TO1900 ();


    /// <summary>
    ///   System.Void ClearPermanentlyKilledFlagsFromMap(System.Int32 mapID)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearPermanentlyKilledFlagsFromMap")]
    ///  extern void CLEAR_PERMANENTLY_KILLED_FLAGS_FROM_MAP (System.Int32 mapID);


    /// <summary>
    /// static  System.Void CompareDataFiles(SaveData first, SaveData second)
    /// </summary>
    /// <param name="first">class SaveData</param>
    /// <param name="second">class SaveData</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareDataFiles")]
    /// static extern void COMPARE_DATA_FILES (nint first, nint second);


    /// <summary>
    ///   System.Collections.Generic.HashSet<DatabaseMonsters.Entry> ComputeCurrentlyOwnedNexomon(System.Boolean onlyCosmic)
    /// </summary>
    /// <param name="onlyCosmic">struct System.Boolean</param>
    /// <returns>class System.Collections.Generic.HashSet<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeCurrentlyOwnedNexomon")]
    ///  extern nint COMPUTE_CURRENTLY_OWNED_NEXOMON (System.Boolean onlyCosmic);


    /// <summary>
    /// static  System.String ComputeDataSavePathForDesktopAndMobile(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeDataSavePathForDesktopAndMobile")]
    /// static extern nint COMPUTE_DATA_SAVE_PATH_FOR_DESKTOP_AND_MOBILE (System.Int32 slotNumber);


    /// <summary>
    ///   System.Int32 ComputeOwnedNexomonByElement(System.String element)
    /// </summary>
    /// <param name="element">class System.String</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeOwnedNexomonByElement")]
    ///  extern System.Int32 COMPUTE_OWNED_NEXOMON_BY_ELEMENT (nint element);


    /// <summary>
    ///   System.String ComputePlaytimeString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputePlaytimeString")]
    ///  extern nint COMPUTE_PLAYTIME_STRING ();


    /// <summary>
    ///   System.Int32 ComputeReputation()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeReputation")]
    ///  extern System.Int32 COMPUTE_REPUTATION ();


    /// <summary>
    ///   System.Int32 CountSwitches()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountSwitches")]
    ///  extern System.Int32 COUNT_SWITCHES ();


    /// <summary>
    ///   System.Boolean DeepCheckIfNexomonOwnedMoreThanOnce(DatabaseMonsters.Entry query)
    /// </summary>
    /// <param name="query">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeepCheckIfNexomonOwnedMoreThanOnce")]
    ///  extern System.Boolean DEEP_CHECK_IF_NEXOMON_OWNED_MORE_THAN_ONCE (nint query);


    /// <summary>
    ///   System.Void DeepPollIfCurrentlyOwnsNexomon(System.Collections.Generic.Dictionary<DatabaseMonsters.Entry,System.Boolean> poll)
    /// </summary>
    /// <param name="poll">class System.Collections.Generic.Dictionary<DatabaseMonsters.Entry,System.Boolean></param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeepPollIfCurrentlyOwnsNexomon")]
    ///  extern void DEEP_POLL_IF_CURRENTLY_OWNS_NEXOMON (nint poll);


    /// <summary>
    /// static  System.Void DeleteSaveData(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DeleteSaveData")]
    /// static extern void DELETE_SAVE_DATA (System.Int32 slotNumber);


    /// <summary>
    /// static  System.Boolean DoesSaveDataExist(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesSaveDataExist")]
    static extern System.Boolean DOES_SAVE_DATA_EXIST(System.Int32 slotNumber);


    /// <summary>
    ///   System.Void DumpInformation()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DumpInformation")]
    ///  extern void DUMP_INFORMATION ();


    /// <summary>
    ///   System.Void EnsureKeyItemsFromSwitches()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureKeyItemsFromSwitches")]
    ///  extern void ENSURE_KEY_ITEMS_FROM_SWITCHES ();


    /// <summary>
    /// static  SaveData.BinaryExtractionReport ExtractDataAsBINARY(System.Int32 slotNumber, SaveData data, System.IO.BinaryReader reader)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <param name="data">class SaveData</param>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <returns>enum SaveData.BinaryExtractionReport</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExtractDataAsBINARY")]
    /// static extern SaveData.BinaryExtractionReport EXTRACT_DATA_AS_BINARY (System.Int32 slotNumber, nint data, nint reader);


    /// <summary>
    /// static  System.Void ExtractDataAsJSON(System.Int32 slotNumber, SaveData data, System.String jsonString)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <param name="data">class SaveData</param>
    /// <param name="jsonString">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExtractDataAsJSON")]
    /// static extern void EXTRACT_DATA_AS_JSON (System.Int32 slotNumber, nint data, nint jsonString);


    /// <summary>
    ///   System.Boolean ForgetSeenNexomon(DatabaseMonsters.Entry entry)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForgetSeenNexomon")]
    ///  extern System.Boolean FORGET_SEEN_NEXOMON (nint entry);


    /// <summary>
    ///   System.Int32 GeneratePermaUnlockCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GeneratePermaUnlockCode")]
    ///  extern System.Int32 GENERATE_PERMA_UNLOCK_CODE ();


    /// <summary>
    ///   System.Int32 GetAverageLevelInParty()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAverageLevelInParty")]
    ///  extern System.Int32 GET_AVERAGE_LEVEL_IN_PARTY ();


    /// <summary>
    ///   System.Int32 GetAverageOfSpecificTopLevelsInParty(System.Int32 count)
    /// </summary>
    /// <param name="count">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAverageOfSpecificTopLevelsInParty")]
    ///  extern System.Int32 GET_AVERAGE_OF_SPECIFIC_TOP_LEVELS_IN_PARTY (System.Int32 count);


    /// <summary>
    /// static  System.Byte[] GetBytesFromString(System.String str)
    /// </summary>
    /// <param name="str">class System.String</param>
    /// <returns>class System.Byte[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBytesFromString")]
    /// static extern nint GET_BYTES_FROM_STRING (nint str);


    /// <summary>
    ///   System.Int32 GetFreeNexoBoxRNGNonce(Algorithms.NexoboxType type)
    /// </summary>
    /// <param name="type">enum Algorithms.NexoboxType</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFreeNexoBoxRNGNonce")]
    ///  extern System.Int32 GET_FREE_NEXO_BOX_RNG_NONCE (Algorithms.NexoboxType type);


    /// <summary>
    ///   System.String GetFreeNexoBoxRNGNonceVariableKey(Algorithms.NexoboxType type)
    /// </summary>
    /// <param name="type">enum Algorithms.NexoboxType</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFreeNexoBoxRNGNonceVariableKey")]
    ///  extern nint GET_FREE_NEXO_BOX_RNG_NONCE_VARIABLE_KEY (Algorithms.NexoboxType type);


    /// <summary>
    ///   System.Int32 GetFriendshipPoints()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFriendshipPoints")]
    ///  extern System.Int32 GET_FRIENDSHIP_POINTS ();


    /// <summary>
    ///   System.Int32 GetHighestLevelInParty()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHighestLevelInParty")]
    ///  extern System.Int32 GET_HIGHEST_LEVEL_IN_PARTY ();


    /// <summary>
    ///   System.Int32 GetLevelCap()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLevelCap")]
    ///  extern System.Int32 GET_LEVEL_CAP ();


    /// <summary>
    ///   System.Collections.Generic.List<System.String> GetPermanentlyKilledFlags(System.Int32 mapID)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <returns>class System.Collections.Generic.List<System.String></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPermanentlyKilledFlags")]
    ///  extern nint GET_PERMANENTLY_KILLED_FLAGS (System.Int32 mapID);


    /// <summary>
    /// static  System.String GetStringFromBytes(System.Byte[] bytes)
    /// </summary>
    /// <param name="bytes">class System.Byte[]</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStringFromBytes")]
    /// static extern nint GET_STRING_FROM_BYTES (nint bytes);


    /// <summary>
    ///   System.Boolean GetSwitch(System.Int32 id)
    /// </summary>
    /// <param name="id">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSwitch")]
    ///  extern System.Boolean GET_SWITCH (System.Int32 id);


    /// <summary>
    ///   System.Int32 GetTimesLost()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTimesLost")]
    ///  extern System.Int32 GET_TIMES_LOST ();


    /// <summary>
    ///   System.Int32 GetTotalNexomonEverOwned()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTotalNexomonEverOwned")]
    ///  extern System.Int32 GET_TOTAL_NEXOMON_EVER_OWNED ();


    /// <summary>
    ///   System.Int32 GetVariable(System.String variableKey)
    /// </summary>
    /// <param name="variableKey">class System.String</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetVariable")]
    ///  extern System.Int32 GET_VARIABLE (nint variableKey);


    /// <summary>
    ///   System.Boolean HasEverOwnedNexomon(DatabaseMonsters.Entry entry)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasEverOwnedNexomon")]
    ///  extern System.Boolean HAS_EVER_OWNED_NEXOMON (nint entry);


    /// <summary>
    ///   System.Boolean HasLostAgainstBraccus()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasLostAgainstBraccus")]
    ///  extern System.Boolean HAS_LOST_AGAINST_BRACCUS ();


    /// <summary>
    ///   System.Boolean HasLostAgainstInominox()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasLostAgainstInominox")]
    ///  extern System.Boolean HAS_LOST_AGAINST_INOMINOX ();


    /// <summary>
    ///   System.Boolean HasMiningGoggles()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasMiningGoggles")]
    ///  extern System.Boolean HAS_MINING_GOGGLES ();


    /// <summary>
    ///   System.Boolean HasSeenNexomon(DatabaseMonsters.Entry entry)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasSeenNexomon")]
    ///  extern System.Boolean HAS_SEEN_NEXOMON (nint entry);


    /// <summary>
    ///   System.Boolean HasValidCheckpoint()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasValidCheckpoint")]
    ///  extern System.Boolean HAS_VALID_CHECKPOINT ();


    /// <summary>
    ///   System.Void IncreaseFreeNexoBoxRNGNonce(Algorithms.NexoboxType type)
    /// </summary>
    /// <param name="type">enum Algorithms.NexoboxType</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IncreaseFreeNexoBoxRNGNonce")]
    ///  extern void INCREASE_FREE_NEXO_BOX_RNG_NONCE (Algorithms.NexoboxType type);


    /// <summary>
    ///   System.Boolean IsBarelyStartingOutGame()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsBarelyStartingOutGame")]
    ///  extern System.Boolean IS_BARELY_STARTING_OUT_GAME ();


    /// <summary>
    ///   System.Boolean IsCocoAvailable()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCocoAvailable")]
    ///  extern System.Boolean IS_COCO_AVAILABLE ();


    /// <summary>
    ///   System.Boolean IsCollectingFriendshipPoints()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCollectingFriendshipPoints")]
    ///  extern System.Boolean IS_COLLECTING_FRIENDSHIP_POINTS ();


    /// <summary>
    ///   System.Boolean IsCurrentlyOwningNexomon(DatabaseMonsters.Entry entry, System.Boolean asCosmic)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <param name="asCosmic">struct System.Boolean</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCurrentlyOwningNexomon")]
    ///  extern System.Boolean IS_CURRENTLY_OWNING_NEXOMON (nint entry, System.Boolean asCosmic);


    /// <summary>
    ///   System.Boolean IsEarlyGame()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEarlyGame")]
    ///  extern System.Boolean IS_EARLY_GAME ();


    /// <summary>
    ///   System.Boolean IsElizaSpawningLegendaryCopies()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsElizaSpawningLegendaryCopies")]
    ///  extern System.Boolean IS_ELIZA_SPAWNING_LEGENDARY_COPIES ();


    /// <summary>
    ///   System.Boolean IsLateGame()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLateGame")]
    ///  extern System.Boolean IS_LATE_GAME ();


    /// <summary>
    ///   System.Boolean IsPlayerMale()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerMale")]
    ///  extern System.Boolean IS_PLAYER_MALE ();


    /// <summary>
    ///   System.Boolean IsRepellingWildEncounters()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsRepellingWildEncounters")]
    ///  extern System.Boolean IS_REPELLING_WILD_ENCOUNTERS ();


    /// <summary>
    ///   System.Boolean IsUsingCaptureCharm()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingCaptureCharm")]
    ///  extern System.Boolean IS_USING_CAPTURE_CHARM ();


    /// <summary>
    ///   System.Boolean IsUsingChallengerBadge()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingChallengerBadge")]
    ///  extern System.Boolean IS_USING_CHALLENGER_BADGE ();


    /// <summary>
    ///   System.Boolean IsUsingMultiplierCoins()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingMultiplierCoins")]
    ///  extern System.Boolean IS_USING_MULTIPLIER_COINS ();


    /// <summary>
    ///   System.Boolean IsUsingMultiplierEXP()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingMultiplierEXP")]
    ///  extern System.Boolean IS_USING_MULTIPLIER_EXP ();


    /// <summary>
    ///   System.Boolean IsUsingMultiplierShard()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingMultiplierShard")]
    ///  extern System.Boolean IS_USING_MULTIPLIER_SHARD ();


    /// <summary>
    ///   System.Boolean IsUsingRarityCharm()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingRarityCharm")]
    ///  extern System.Boolean IS_USING_RARITY_CHARM ();


    /// <summary>
    ///   System.Boolean IsUsingUniqueCharm()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUsingUniqueCharm")]
    ///  extern System.Boolean IS_USING_UNIQUE_CHARM ();


    /// <summary>
    /// static  System.Boolean MustShowDataCompatibilityDisclaimer()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MustShowDataCompatibilityDisclaimer")]
    /// static extern System.Boolean MUST_SHOW_DATA_COMPATIBILITY_DISCLAIMER ();


    /// <summary>
    /// static  System.Void PerformSaveData(System.Int32 slotNumber, SaveData data, System.Boolean performAsBinary)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <param name="data">class SaveData</param>
    /// <param name="performAsBinary">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PerformSaveData")]
    /// static extern void PERFORM_SAVE_DATA (System.Int32 slotNumber, nint data, System.Boolean performAsBinary);


    /// <summary>
    ///   System.Void RecalculateOwnedMonsters(System.Boolean preserveExistingEntries)
    /// </summary>
    /// <param name="preserveExistingEntries">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecalculateOwnedMonsters")]
    ///  extern void RECALCULATE_OWNED_MONSTERS (System.Boolean preserveExistingEntries);


    /// <summary>
    ///   System.Void RefreshAbyssalPrerequisitesSwitch()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshAbyssalPrerequisitesSwitch")]
    ///  extern void REFRESH_ABYSSAL_PREREQUISITES_SWITCH ();


    /// <summary>
    ///   System.Void RefreshCompanionAvailability()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshCompanionAvailability")]
    ///  extern void REFRESH_COMPANION_AVAILABILITY ();


    /// <summary>
    ///   System.Void RefreshLaterianHunters()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshLaterianHunters")]
    ///  extern void REFRESH_LATERIAN_HUNTERS ();


    /// <summary>
    ///   System.Void RefreshPickaxe()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshPickaxe")]
    ///  extern void REFRESH_PICKAXE ();


    /// <summary>
    ///   System.Void RefreshPlayerGender()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RefreshPlayerGender")]
    ///  extern void REFRESH_PLAYER_GENDER ();


    /// <summary>
    /// static  System.Void RegisterDataCompatibilityDisclaimerFlag()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RegisterDataCompatibilityDisclaimerFlag")]
    /// static extern void REGISTER_DATA_COMPATIBILITY_DISCLAIMER_FLAG ();


    /// <summary>
    ///   System.Void RemovePermanentlyKilledFlag(System.Int32 mapID, System.String flag)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <param name="flag">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePermanentlyKilledFlag")]
    ///  extern void REMOVE_PERMANENTLY_KILLED_FLAG (System.Int32 mapID, nint flag);


    /// <summary>
    ///   System.Boolean ReportCapturedNexomon(DatabaseMonsters.Entry entry)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReportCapturedNexomon")]
    ///  extern System.Boolean REPORT_CAPTURED_NEXOMON (nint entry);


    /// <summary>
    ///   System.Void ReportDefeat()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReportDefeat")]
    ///  extern void REPORT_DEFEAT ();


    /// <summary>
    ///   System.Void ReportRelease(DatabaseMonsters.Entry entry, System.Boolean isCosmic)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <param name="isCosmic">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReportRelease")]
    ///  extern void REPORT_RELEASE (nint entry, System.Boolean isCosmic);


    /// <summary>
    ///   System.Boolean ReportSeenNexomon(DatabaseMonsters.Entry entry)
    /// </summary>
    /// <param name="entry">class DatabaseMonsters.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReportSeenNexomon")]
    ///  extern System.Boolean REPORT_SEEN_NEXOMON (nint entry);


    /// <summary>
    /// static  SaveData RetrieveSaveData(System.Int32 slotNumber)
    /// </summary>
    /// <param name="slotNumber">struct System.Int32</param>
    /// <returns>class SaveData</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveSaveData")]
    /// static extern nint RETRIEVE_SAVE_DATA (System.Int32 slotNumber);


    /// <summary>
    ///   System.Void SetFriendshipPoints(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFriendshipPoints")]
    ///  extern void SET_FRIENDSHIP_POINTS (System.Int32 value);


    /// <summary>
    ///   System.Void SetSwitch(System.Int32 id, System.Boolean value)
    /// </summary>
    /// <param name="id">struct System.Int32</param>
    /// <param name="value">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSwitch")]
    ///  extern void SET_SWITCH (System.Int32 id, System.Boolean value);


    /// <summary>
    ///   System.Void SetTimesLost(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTimesLost")]
    ///  extern void SET_TIMES_LOST (System.Int32 value);


    /// <summary>
    ///   System.Void SetVariable(System.String variableKey, System.Int32 value)
    /// </summary>
    /// <param name="variableKey">class System.String</param>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVariable")]
    ///  extern void SET_VARIABLE (nint variableKey, System.Int32 value);


    /// <summary>
    ///   System.Boolean ShouldDragonsSpawnInCadium()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldDragonsSpawnInCadium")]
    ///  extern System.Boolean SHOULD_DRAGONS_SPAWN_IN_CADIUM ();


    /// <summary>
    ///   System.Boolean ShouldForcePlayerOmnisunToLookLikeSolus()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldForcePlayerOmnisunToLookLikeSolus")]
    ///  extern System.Boolean SHOULD_FORCE_PLAYER_OMNISUN_TO_LOOK_LIKE_SOLUS ();


    /// <summary>
    ///   System.Boolean ShouldSpawnZieglerMiasmaWeather(System.Int32 mapID)
    /// </summary>
    /// <param name="mapID">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldSpawnZieglerMiasmaWeather")]
    ///  extern System.Boolean SHOULD_SPAWN_ZIEGLER_MIASMA_WEATHER (System.Int32 mapID);


    /// <summary>
    ///   System.ValueTuple<System.Int32,System.Int32,System.Int32,System.String> TakeAbyssalMagicMazeExit(System.Int32 exitTaken)
    /// </summary>
    /// <param name="exitTaken">struct System.Int32</param>
    /// <returns>struct System.ValueTuple<System.Int32,System.Int32,System.Int32,System.String></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeAbyssalMagicMazeExit")]
    ///  extern System.ValueTuple<System.Int32,System.Int32,System.Int32,System.String> TAKE_ABYSSAL_MAGIC_MAZE_EXIT (System.Int32 exitTaken);


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   SimpleJSON.JSONClass ToJSON()
    /// </summary>
    /// <returns>class SimpleJSON.JSONClass</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToJSON")]
    ///  extern nint TO_JSON ();


    /// <summary>
    /// static  System.ValueTuple<System.Boolean,System.Collections.Generic.Dictionary<System.Int32,System.Boolean>,System.Int32> TrimSwitches(System.Collections.Generic.Dictionary<System.Int32,System.Boolean> currentSwitches)
    /// </summary>
    /// <param name="currentSwitches">class System.Collections.Generic.Dictionary<System.Int32,System.Boolean></param>
    /// <returns>struct System.ValueTuple<System.Boolean,System.Collections.Generic.Dictionary<System.Int32,System.Boolean>,System.Int32></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrimSwitches")]
    /// static extern System.ValueTuple<System.Boolean,System.Collections.Generic.Dictionary<System.Int32,System.Boolean>,System.Int32> TRIM_SWITCHES (nint currentSwitches);



    /// <summary>
    ///   System.Void SetSwitches(System.Boolean value, System.Int32[] ids)
    /// </summary>
    /// <param name="value">struct System.Boolean</param>
    /// <param name="ids">class System.Int32[]</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSwitches", Search = typeof(Search_SaveData))]
    ///  extern void SET_SWITCHES_00 (System.Boolean value, nint ids);


    /// <summary>
    ///   System.Void SetSwitches(System.Boolean value, System.Int32 start, System.Int32 end)
    /// </summary>
    /// <param name="value">struct System.Boolean</param>
    /// <param name="start">struct System.Int32</param>
    /// <param name="end">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSwitches", Search = typeof(Search_SaveData))]
    ///  extern void SET_SWITCHES_01 (System.Boolean value, System.Int32 start, System.Int32 end);


    /// public static partial class Search_SaveData
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void SetSwitches(System.Boolean value, System.Int32[] ids)
    /// </summary>
    /// public static bool SET_SWITCHES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSwitches", "System.Boolean", "System.Int32[]");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetSwitches(System.Boolean value, System.Int32 start, System.Int32 end)
    /// </summary>
    /// public static bool SET_SWITCHES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetSwitches", "System.Boolean", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 
    /// 
    /// }

}
