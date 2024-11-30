namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000BFU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// class 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredString id
// [MonoCollectorSearchFieldAttribute(typeof(nint),"id", "ID")]

// class 0x18 Party partyMAIN
// [MonoCollectorSearchFieldAttribute(typeof(nint),"partyMAIN", "PARTY_MAIN")]

// class 0x20 Party partyEARLY
// [MonoCollectorSearchFieldAttribute(typeof(nint),"partyEARLY", "PARTY_EARLY")]

// class 0x28 Party partyREGULAR
// [MonoCollectorSearchFieldAttribute(typeof(nint),"partyREGULAR", "PARTY_REGULAR")]

// class 0x30 Party partyLATE
// [MonoCollectorSearchFieldAttribute(typeof(nint),"partyLATE", "PARTY_LATE")]

// struct 0x38 System.Int32 switchID
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"switchID", "SWITCH_ID")]

// struct 0x3C System.Single extraWeight
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"extraWeight", "EXTRA_WEIGHT")]

// class 0x40 System.String bgm
// [MonoCollectorSearchFieldAttribute(typeof(nint),"bgm", "BGM")]

// struct 0x48 System.Boolean allowedEscape
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowedEscape", "ALLOWED_ESCAPE")]

// struct 0x49 System.Boolean allowedItems
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowedItems", "ALLOWED_ITEMS")]

// struct 0x4A System.Boolean allowedParty
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowedParty", "ALLOWED_PARTY")]

// struct 0x4B System.Boolean allowedCapture
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowedCapture", "ALLOWED_CAPTURE")]

// struct 0x4C System.Boolean allowedDefeat
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowedDefeat", "ALLOWED_DEFEAT")]

// struct 0x4D System.Boolean isWild
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isWild", "IS_WILD")]

// struct 0x4E System.Boolean instantEnemySpawn
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"instantEnemySpawn", "INSTANT_ENEMY_SPAWN")]

// struct 0x4F System.Boolean useMapDifficulty
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"useMapDifficulty", "USE_MAP_DIFFICULTY")]

// struct 0x50 System.Boolean recalculateSkillsWhenMapDifficultyIsUsed
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"recalculateSkillsWhenMapDifficultyIsUsed", "RECALCULATE_SKILLS_WHEN_MAP_DIFFICULTY_IS_USED")]

// struct 0x51 System.Boolean hideEnemyLevels
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"hideEnemyLevels", "HIDE_ENEMY_LEVELS")]

// class 0x58 System.String scene
// [MonoCollectorSearchFieldAttribute(typeof(nint),"scene", "SCENE")]

// class 0x60 DatabaseTamers.Entry.Checkpoint checkpoint
// [MonoCollectorSearchFieldAttribute(typeof(nint),"checkpoint", "CHECKPOINT")]

// class 0x68 System.String comment
// [MonoCollectorSearchFieldAttribute(typeof(nint),"comment", "COMMENT")]

// struct 0x70 System.Single hp_percentage_modifier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"hp_percentage_modifier", "HP_PERCENTAGE_MODIFIER")]

// struct 0x74 System.Single sta_percentage_modifier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"sta_percentage_modifier", "STA_PERCENTAGE_MODIFIER")]

// class 0x78 System.Collections.Generic.List<DatabaseMonsters.Entry> doNotSkillPopulateList
// [MonoCollectorSearchFieldAttribute(typeof(nint),"doNotSkillPopulateList", "DO_NOT_SKILL_POPULATE_LIST")]

// class 0x80 System.String stringFolderOverride
// [MonoCollectorSearchFieldAttribute(typeof(nint),"stringFolderOverride", "STRING_FOLDER_OVERRIDE")]

// class 0x88 System.Collections.Generic.List<System.Int32> unitIndexesConsideredAsStoryBosses
// [MonoCollectorSearchFieldAttribute(typeof(nint),"unitIndexesConsideredAsStoryBosses", "UNIT_INDEXES_CONSIDERED_AS_STORY_BOSSES")]

// struct 0x90 System.Single experienceMultiplier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"experienceMultiplier", "EXPERIENCE_MULTIPLIER")]

// struct 0x94 System.Single coinsMultiplier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"coinsMultiplier", "COINS_MULTIPLIER")]

// struct 0x98 System.Boolean autoHealOnExitIfInitiallyAlive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"autoHealOnExitIfInitiallyAlive", "AUTO_HEAL_ON_EXIT_IF_INITIALLY_ALIVE")]

// struct 0x9C System.Int32 randomizationSeed
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"randomizationSeed", "RANDOMIZATION_SEED")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x020000BFU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Entry(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Entry(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Entry obj) => obj._ptr;
        public static implicit operator bool(Ptr_Entry obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Entry"]
/// </summary>
public partial class Entry
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    ///   System.Single GetCoinsMultiplier()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCoinsMultiplier")]
    ///  extern System.Single GET_COINS_MULTIPLIER ();


    /// <summary>
    ///   System.Single GetExperienceMultiplier()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetExperienceMultiplier")]
    ///  extern System.Single GET_EXPERIENCE_MULTIPLIER ();


    /// <summary>
    ///   System.Boolean IsCommonTamer()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCommonTamer")]
    ///  extern System.Boolean IS_COMMON_TAMER ();


    /// <summary>
    ///   System.Boolean IsThief()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsThief")]
    ///  extern System.Boolean IS_THIEF ();




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
