using Maple.MonoGameAssistant.Core;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Unit"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000071U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [85, 110, 105, 116])]


// class 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredString name
// [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

// class 0x18 CodeStage.AntiCheat.ObscuredTypes.ObscuredString nickname
// [MonoCollectorSearchFieldAttribute(typeof(nint),"nickname", "NICKNAME")]

// struct 0x20 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt level
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"level", "LEVEL")]

// struct 0x34 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt hp
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"hp", "HP")]

// struct 0x48 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt maxHP
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"maxHP", "MAX_HP")]

// struct 0x5C CodeStage.AntiCheat.ObscuredTypes.ObscuredInt sta
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"sta", "STA")]

// struct 0x70 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt maxSTA
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"maxSTA", "MAX_STA")]

// struct 0x84 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt attack
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"attack", "ATTACK")]

// struct 0x98 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt defense
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"defense", "DEFENSE")]

// struct 0xAC CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat speed
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat),"speed", "SPEED")]

// struct 0xC4 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt exp
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"exp", "EXP")]

// struct 0xD8 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt nextEXP
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt),"nextEXP", "NEXT_EXP")]

// struct 0xEC CodeStage.AntiCheat.ObscuredTypes.ObscuredBool cosmic
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool),"cosmic", "COSMIC")]

// struct 0xF8 CodeStage.AntiCheat.ObscuredTypes.ObscuredByte harmony
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte),"harmony", "HARMONY")]

// class 0x100 System.Collections.Generic.List<System.Int32> skills
// [MonoCollectorSearchFieldAttribute(typeof(nint),"skills", "SKILLS")]

// class 0x108 System.Collections.Generic.List<DatabaseItems.Entry> cores
// [MonoCollectorSearchFieldAttribute(typeof(nint),"cores", "CORES")]

// class 0x110 Unit.BattleStatus battleStatus
// [MonoCollectorSearchFieldAttribute(typeof(nint),"battleStatus", "BATTLE_STATUS")]

// struct 0x118 System.Single _hpPercentageModifier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"_hpPercentageModifier", "_HP_PERCENTAGE_MODIFIER")]

// struct 0x11C System.Single _staminaPercentageModifier
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"_staminaPercentageModifier", "_STAMINA_PERCENTAGE_MODIFIER")]
public partial class Unit
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Unit";
    //public static byte[] Static_ClassName { get; } = [85, 110, 105, 116];

    //public const uint Const_TypeToken = 0x02000071U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Unit(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Unit(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Unit obj) => obj._ptr;
        public static implicit operator bool(Ptr_Unit obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Unit"]
/// </summary>
public partial class Unit
{



    /// <summary>
    /// static  System.Void <Equivalent>g__Check|76_0(System.Boolean condition, System.String errorMessage, Unit.<>c__DisplayClass76_0& )
    /// </summary>
    /// <param name="condition">struct System.Boolean</param>
    /// <param name="errorMessage">class System.String</param>
    /// <param name="">struct Unit.<>c__DisplayClass76_0&</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Equivalent>g__Check|76_0")]
    /// static extern void <EQUIVALENT>G__CHECK|76_0 (System.Boolean condition, nint errorMessage, Unit.<>c__DisplayClass76_0& );


    /// <summary>
    ///   Unit.ExperienceApplicationResult ApplyEXP(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>class Unit.ExperienceApplicationResult</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyEXP")]
    ///  extern nint APPLY_EXP (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount);


    /// <summary>
    ///   System.Boolean ApplyEvolution()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyEvolution")]
    ///  extern System.Boolean APPLY_EVOLUTION ();


    /// <summary>
    ///   System.Void ChangeLevel(System.Int32 value, SaveData saveData, System.Boolean forceNewSkills, System.Boolean revertEvolution)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <param name="saveData">class SaveData</param>
    /// <param name="forceNewSkills">struct System.Boolean</param>
    /// <param name="revertEvolution">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeLevel")]
    ///  extern void CHANGE_LEVEL (System.Int32 value, nint saveData, System.Boolean forceNewSkills, System.Boolean revertEvolution);


    /// <summary>
    ///   System.Void ClearBattleStatus()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearBattleStatus")]
    ///  extern void CLEAR_BATTLE_STATUS ();


    /// <summary>
    /// static  System.Int32 ComputeExperienceNeededAtLevel(System.Int32 givenLevel)
    /// </summary>
    /// <param name="givenLevel">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeExperienceNeededAtLevel")]
    /// static extern System.Int32 COMPUTE_EXPERIENCE_NEEDED_AT_LEVEL (System.Int32 givenLevel);


    /// <summary>
    /// static  Unit Create(System.String name, System.Int32 level, System.Boolean cosmic)
    /// </summary>
    /// <param name="name">class System.String</param>
    /// <param name="level">struct System.Int32</param>
    /// <param name="cosmic">struct System.Boolean</param>
    /// <returns>class Unit</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Create")]
    static extern nint CREATE(PMonoString name, System.Int32 level, System.Boolean cosmic);


    /// <summary>
    /// static  Unit Duplicate(Unit original, System.Boolean includeBattleStatus)
    /// </summary>
    /// <param name="original">class Unit</param>
    /// <param name="includeBattleStatus">struct System.Boolean</param>
    /// <returns>class Unit</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Duplicate")]
    /// static extern nint DUPLICATE (nint original, System.Boolean includeBattleStatus);


    /// <summary>
    ///   System.Void EquipCore(DatabaseItems.Entry core, System.Int32 index)
    /// </summary>
    /// <param name="core">class DatabaseItems.Entry</param>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EquipCore")]
    ///  extern void EQUIP_CORE (nint core, System.Int32 index);


    /// <summary>
    /// static  System.ValueTuple<System.Boolean,System.Collections.Generic.List<System.String>> Equivalent(Unit first, Unit second)
    /// </summary>
    /// <param name="first">class Unit</param>
    /// <param name="second">class Unit</param>
    /// <returns>struct System.ValueTuple<System.Boolean,System.Collections.Generic.List<System.String>></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equivalent")]
    /// static extern System.ValueTuple<System.Boolean,System.Collections.Generic.List<System.String>> EQUIVALENT (nint first, nint second);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetATK()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetATK")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_ATK ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetATKBonusFromCores()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetATKBonusFromCores")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_ATK_BONUS_FROM_CORES ();


    /// <summary>
    ///   Unit.BattleStatus GetBattleStatus()
    /// </summary>
    /// <returns>class Unit.BattleStatus</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBattleStatus")]
    ///  extern nint GET_BATTLE_STATUS ();


    /// <summary>
    ///   DatabaseItems.Entry GetCore(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>class DatabaseItems.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCore")]
    ///  extern nint GET_CORE (System.Int32 index);


    /// <summary>
    ///   CoreUsage.StatChanges GetCoreStatChanges()
    /// </summary>
    /// <returns>struct CoreUsage.StatChanges</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCoreStatChanges")]
    ///  extern CoreUsage.StatChanges GET_CORE_STAT_CHANGES ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetDEF()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDEF")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_DEF ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetDEFBonusFromCores()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDEFBonusFromCores")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_DEF_BONUS_FROM_CORES ();


    /// <summary>
    ///   DatabaseMonsters.Entry GetData()
    /// </summary>
    /// <returns>class DatabaseMonsters.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetData")]
    ///  extern nint GET_DATA ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetEXP()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEXP")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_EXP ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetHP()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHP")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_HP ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetHPBonusFromCores()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHPBonusFromCores")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_HP_BONUS_FROM_CORES ();


    /// <summary>
    ///   System.Int32 GetHarmony()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHarmony")]
    ///  extern System.Int32 GET_HARMONY ();


    /// <summary>
    ///   System.String GetLocalizedDisplayNameFromBaseData()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDisplayNameFromBaseData")]
    ///  extern nint GET_LOCALIZED_DISPLAY_NAME_FROM_BASE_DATA ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetMaxHP()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMaxHP")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_MAX_HP ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetMaxSTA()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMaxSTA")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_MAX_STA ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetNextEXP()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextEXP")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_NEXT_EXP ();


    /// <summary>
    ///   System.String GetNickname()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNickname")]
    ///  extern nint GET_NICKNAME ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetRawATK()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRawATK")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_RAW_ATK ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetRawDEF()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRawDEF")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_RAW_DEF ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetRawMaxHP()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRawMaxHP")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_RAW_MAX_HP ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetRawMaxSTA()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRawMaxSTA")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_RAW_MAX_STA ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GetRawSPD()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRawSPD")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GET_RAW_SPD ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GetSPD()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSPD")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GET_SPD ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GetSPDBonusFromCores()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSPDBonusFromCores")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat GET_SPD_BONUS_FROM_CORES ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSTA()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSTA")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_STA ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetSTABonusFromCores()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSTABonusFromCores")]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GET_STA_BONUS_FROM_CORES ();


    /// <summary>
    ///   System.Single GetSuperChargeMultiplier()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSuperChargeMultiplier")]
    ///  extern System.Single GET_SUPER_CHARGE_MULTIPLIER ();


    /// <summary>
    ///   System.String GetSystemName()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSystemName")]
    ///  extern nint GET_SYSTEM_NAME ();


    /// <summary>
    ///   System.Boolean HasCustomNickname()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasCustomNickname")]
    ///  extern System.Boolean HAS_CUSTOM_NICKNAME ();


    /// <summary>
    ///   System.Boolean IsCosmic()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCosmic")]
    ///  extern System.Boolean IS_COSMIC ();


    /// <summary>
    ///   System.Boolean IsPermanentlyFainted(SaveData ownerData)
    /// </summary>
    /// <param name="ownerData">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPermanentlyFainted")]
    ///  extern System.Boolean IS_PERMANENTLY_FAINTED (nint ownerData);


    /// <summary>
    ///   System.Void PartiallyHeal(System.Single percentage, System.Boolean ignoreCustomMode)
    /// </summary>
    /// <param name="percentage">struct System.Single</param>
    /// <param name="ignoreCustomMode">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PartiallyHeal")]
    ///  extern void PARTIALLY_HEAL (System.Single percentage, System.Boolean ignoreCustomMode);


    /// <summary>
    ///   System.Void PartiallyRestore(System.Single percentage, System.Boolean ignoreCustomMode)
    /// </summary>
    /// <param name="percentage">struct System.Single</param>
    /// <param name="ignoreCustomMode">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PartiallyRestore")]
    ///  extern void PARTIALLY_RESTORE (System.Single percentage, System.Boolean ignoreCustomMode);


    /// <summary>
    ///   System.Void RecalculateInternalStats()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RecalculateInternalStats")]
    ///  extern void RECALCULATE_INTERNAL_STATS ();


    /// <summary>
    ///   System.Void RemoveAllCores(System.Boolean restoreToInventory)
    /// </summary>
    /// <param name="restoreToInventory">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllCores")]
    ///  extern void REMOVE_ALL_CORES (System.Boolean restoreToInventory);


    /// <summary>
    ///   System.Void ResetNickname()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetNickname")]
    ///  extern void RESET_NICKNAME ();


    /// <summary>
    ///   System.Void Restore(System.Boolean ignoreCustomMode)
    /// </summary>
    /// <param name="ignoreCustomMode">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Restore")]
    ///  extern void RESTORE (System.Boolean ignoreCustomMode);


    /// <summary>
    ///   System.Void RevertEvolutionStageToMatchCurrentLevel()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RevertEvolutionStageToMatchCurrentLevel")]
    ///  extern void REVERT_EVOLUTION_STAGE_TO_MATCH_CURRENT_LEVEL ();


    /// <summary>
    ///   System.Void SetCosmic(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCosmic")]
    ///  extern void SET_COSMIC (CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);


    /// <summary>
    ///   System.Void SetHarmony(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHarmony")]
    ///  extern void SET_HARMONY (System.Int32 value);


    /// <summary>
    ///   System.Boolean SetNickname(System.String desiredNickname)
    /// </summary>
    /// <param name="desiredNickname">class System.String</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNickname")]
    ///  extern System.Boolean SET_NICKNAME (nint desiredNickname);


    /// <summary>
    ///   System.Void SetupRandomSkills(System.Int32 minimumDamageSkills)
    /// </summary>
    /// <param name="minimumDamageSkills">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetupRandomSkills")]
    ///  extern void SETUP_RANDOM_SKILLS (System.Int32 minimumDamageSkills);


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   SimpleJSON.JSONNode ToJSON()
    /// </summary>
    /// <returns>abstract class SimpleJSON.JSONNode</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToJSON")]
    ///  extern nint TO_JSON ();



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Unit))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONNode node)
    /// </summary>
    /// <param name="node">abstract class SimpleJSON.JSONNode</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Unit))]
    ///  extern void .CTOR_01 (nint node);


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader, System.Int32 incomingBuildVersion)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <param name="incomingBuildVersion">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Unit))]
    ///  extern void .CTOR_02 (nint reader, System.Int32 incomingBuildVersion);


    /// public static partial class Search_Unit
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
    ///   System.Void .ctor(SimpleJSON.JSONNode node)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SimpleJSON.JSONNode");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader, System.Int32 incomingBuildVersion)
    /// </summary>
    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.IO.BinaryReader", "System.Int32");
    ///     
    ///  
    /// 
    /// 
    /// }

}
