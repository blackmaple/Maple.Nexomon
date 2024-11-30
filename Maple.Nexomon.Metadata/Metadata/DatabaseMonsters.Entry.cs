using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;



/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000A0U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// struct 0x10 System.Int32 uniqueID
[MonoCollectorSearchFieldAttribute(typeof(System.Int32), "uniqueID", "UNIQUE_ID")]

// class 0x18 System.String name
[MonoCollectorSearchFieldAttribute(typeof(PMonoString), "name", "NAME")]

// class 0x20 System.String element
[MonoCollectorSearchFieldAttribute(typeof(PMonoString), "element", "ELEMENT")]

// struct 0x28 System.Int32 rarityIndex
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"rarityIndex", "RARITY_INDEX")]

// struct 0x2C System.Int32 baseHP
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"baseHP", "BASE_HP")]

// struct 0x30 System.Int32 baseSTA
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"baseSTA", "BASE_STA")]

// struct 0x34 System.Int32 baseATK
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"baseATK", "BASE_ATK")]

// struct 0x38 System.Int32 baseDEF
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"baseDEF", "BASE_DEF")]

// struct 0x3C System.Int32 baseSPD
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"baseSPD", "BASE_SPD")]

// struct 0x40 System.Int32 overridingTierNumber
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"overridingTierNumber", "OVERRIDING_TIER_NUMBER")]

// struct 0x44 DatabaseMonsters.Entry.BodyInfo bodyInfo
// [MonoCollectorSearchFieldAttribute(typeof(DatabaseMonsters.Entry.BodyInfo),"bodyInfo", "BODY_INFO")]

// struct 0x5C DatabaseMonsters.Entry.ShadowInfo shadowInfo
// [MonoCollectorSearchFieldAttribute(typeof(DatabaseMonsters.Entry.ShadowInfo),"shadowInfo", "SHADOW_INFO")]

// struct 0x80 System.ValueTuple<System.Int32,DatabaseMonsters.Entry,System.Int32> evolution
// [MonoCollectorSearchFieldAttribute(typeof(System.ValueTuple<System.Int32,DatabaseMonsters.Entry,System.Int32>),"evolution", "EVOLUTION")]

// class 0x98 System.Collections.Generic.List<DatabaseItems.Entry> favoriteFoods
// [MonoCollectorSearchFieldAttribute(typeof(nint),"favoriteFoods", "FAVORITE_FOODS")]

// class 0xA0 System.Collections.Generic.List<DatabaseMonsters.Entry> evolutionLine
// [MonoCollectorSearchFieldAttribute(typeof(nint),"evolutionLine", "EVOLUTION_LINE")]

// class 0xA8 System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry> skilltree
// [MonoCollectorSearchFieldAttribute(typeof(nint),"skilltree", "SKILLTREE")]

// class 0xB0 System.String gruntFile
// [MonoCollectorSearchFieldAttribute(typeof(nint),"gruntFile", "GRUNT_FILE")]

// struct 0xB8 System.Int32 distributionWeight
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"distributionWeight", "DISTRIBUTION_WEIGHT")]

// class 0xC0 System.Collections.Generic.List<DatabaseSkills.Entry> flattenedSkillTree
// [MonoCollectorSearchFieldAttribute(typeof(nint),"flattenedSkillTree", "FLATTENED_SKILL_TREE")]

// class 0xC8 System.Collections.Generic.List<System.Int32> flatSkillLevels
// [MonoCollectorSearchFieldAttribute(typeof(nint),"flatSkillLevels", "FLAT_SKILL_LEVELS")]
public partial class DatabaseMonsters_Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x020000A0U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_DatabaseMonsters_Entry(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_DatabaseMonsters_Entry(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_DatabaseMonsters_Entry obj) => obj._ptr;
        public static implicit operator bool(Ptr_DatabaseMonsters_Entry obj) => obj.Valid();

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
public partial class DatabaseMonsters_Entry
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    /// static  System.Boolean <RandomizeSkilltree>g__ConfirmNoDuplicates|28_0(System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry> tree)
    /// </summary>
    /// <param name="tree">class System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry></param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<RandomizeSkilltree>g__ConfirmNoDuplicates|28_0")]
    /// static extern System.Boolean <RANDOMIZE_SKILLTREE>G__CONFIRM_NO_DUPLICATES|28_0 (nint tree);


    /// <summary>
    ///   System.Collections.Generic.List<DatabaseSkills.Entry> GetAllPossibleSkills(System.Int32 level, Custom customData)
    /// </summary>
    /// <param name="level">struct System.Int32</param>
    /// <param name="customData">class Custom</param>
    /// <returns>class System.Collections.Generic.List<DatabaseSkills.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllPossibleSkills")]
    ///  extern nint GET_ALL_POSSIBLE_SKILLS (System.Int32 level, nint customData);


    /// <summary>
    ///   DatabaseMonsters.Entry GetBaseMonster()
    /// </summary>
    /// <returns>class DatabaseMonsters.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBaseMonster")]
    ///  extern nint GET_BASE_MONSTER ();


    /// <summary>
    ///   System.Int32 GetDistributionWeight(System.Boolean forceCalculation)
    /// </summary>
    /// <param name="forceCalculation">struct System.Boolean</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDistributionWeight")]
    ///  extern System.Int32 GET_DISTRIBUTION_WEIGHT (System.Boolean forceCalculation);


    /// <summary>
    ///   System.String GetElement()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetElement")]
    ///  extern nint GET_ELEMENT ();


    /// <summary>
    ///   DatabaseElements.Entry GetElementData()
    /// </summary>
    /// <returns>class DatabaseElements.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetElementData")]
    ///  extern nint GET_ELEMENT_DATA ();


    /// <summary>
    ///   System.Collections.Generic.List<DatabaseMonsters.Entry> GetEvolutionLine()
    /// </summary>
    /// <returns>class System.Collections.Generic.List<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEvolutionLine")]
    ///  extern nint GET_EVOLUTION_LINE ();


    /// <summary>
    ///   System.Collections.Generic.List<DatabaseItems.Entry> GetFavoriteFoods()
    /// </summary>
    /// <returns>class System.Collections.Generic.List<DatabaseItems.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFavoriteFoods")]
    ///  extern nint GET_FAVORITE_FOODS ();


    /// <summary>
    ///   System.Collections.Generic.List<DatabaseSkills.Entry> GetFlattenedSkillTree(Custom customData)
    /// </summary>
    /// <param name="customData">class Custom</param>
    /// <returns>class System.Collections.Generic.List<DatabaseSkills.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFlattenedSkillTree")]
    ///  extern nint GET_FLATTENED_SKILL_TREE (nint customData);


    /// <summary>
    ///   System.String GetGruntFilename()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGruntFilename")]
    ///  extern nint GET_GRUNT_FILENAME ();


    /// <summary>
    ///   System.String GetLocalizedDescription()
    /// </summary>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription")]
    extern PMonoString GET_LOCALIZED_DESCRIPTION();


    /// <summary>
    ///   System.String GetLocalizedName()
    /// </summary>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
    extern PMonoString GET_LOCALIZED_NAME();


    /// <summary>
    ///   System.Collections.Generic.List<DatabaseMonsters.Entry> GetLowerTierEntries()
    /// </summary>
    /// <returns>class System.Collections.Generic.List<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLowerTierEntries")]
    ///  extern nint GET_LOWER_TIER_ENTRIES ();


    /// <summary>
    ///   DatabaseSkills.Entry GetNextPossibleFlatSkill(System.Int32 monsterLevel, Custom customData, System.Collections.Generic.List<DatabaseSkills.Entry> excluded)
    /// </summary>
    /// <param name="monsterLevel">struct System.Int32</param>
    /// <param name="customData">class Custom</param>
    /// <param name="excluded">class System.Collections.Generic.List<DatabaseSkills.Entry></param>
    /// <returns>class DatabaseSkills.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextPossibleFlatSkill")]
    ///  extern nint GET_NEXT_POSSIBLE_FLAT_SKILL (System.Int32 monsterLevel, nint customData, nint excluded);


    /// <summary>
    ///   System.Collections.Generic.List<System.Int32> GetRandomSkills(System.Int32 level, System.Int32 max, Custom customData)
    /// </summary>
    /// <param name="level">struct System.Int32</param>
    /// <param name="max">struct System.Int32</param>
    /// <param name="customData">class Custom</param>
    /// <returns>class System.Collections.Generic.List<System.Int32></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRandomSkills")]
    ///  extern nint GET_RANDOM_SKILLS (System.Int32 level, System.Int32 max, nint customData);


    /// <summary>
    ///   DatabaseRarity.Entry GetRarityData()
    /// </summary>
    /// <returns>class DatabaseRarity.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRarityData")]
    ///  extern nint GET_RARITY_DATA ();


    /// <summary>
    ///   System.Int32 GetRarityIndex()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRarityIndex")]
    ///  extern System.Int32 GET_RARITY_INDEX ();


    /// <summary>
    ///   System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry> GetSkilltree(Custom customData)
    /// </summary>
    /// <param name="customData">class Custom</param>
    /// <returns>class System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSkilltree")]
    ///  extern nint GET_SKILLTREE (nint customData);


    /// <summary>
    ///   System.Int32 GetTierNumber()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTierNumber")]
    ///  extern System.Int32 GET_TIER_NUMBER ();


    /// <summary>
    ///   System.Boolean IsDragon()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsDragon")]
    ///  extern System.Boolean IS_DRAGON ();


    /// <summary>
    ///   System.Boolean IsUnique()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsUnique")]
    ///  extern System.Boolean IS_UNIQUE ();


    /// <summary>
    ///   System.Boolean LikesFood(DatabaseItems.Entry foodItem)
    /// </summary>
    /// <param name="foodItem">class DatabaseItems.Entry</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LikesFood")]
    ///  extern System.Boolean LIKES_FOOD (nint foodItem);


    /// <summary>
    ///   System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry> RandomizeSkilltree(System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry> original, System.Boolean keepOriginalElement, System.Int32 baseSeed)
    /// </summary>
    /// <param name="original">class System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry></param>
    /// <param name="keepOriginalElement">struct System.Boolean</param>
    /// <param name="baseSeed">struct System.Int32</param>
    /// <returns>class System.Collections.Generic.Dictionary<System.Int32,DatabaseSkills.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeSkilltree")]
    ///  extern nint RANDOMIZE_SKILLTREE (nint original, System.Boolean keepOriginalElement, System.Int32 baseSeed);




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
