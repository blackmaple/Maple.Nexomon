using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200008FU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// class 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredString id
[MonoCollectorSearchFieldAttribute(typeof(ObscuredString.Ptr_ObscuredString), "id", "ID")]

// class 0x18 CodeStage.AntiCheat.ObscuredTypes.ObscuredString category
[MonoCollectorSearchFieldAttribute(typeof(ObscuredString.Ptr_ObscuredString), "category", "CATEGORY")]

// class 0x20 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt[] effectValues
// [MonoCollectorSearchFieldAttribute(typeof(nint),"effectValues", "EFFECT_VALUES")]

// struct 0x28 System.Boolean vowelSound
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"vowelSound", "VOWEL_SOUND")]

// struct 0x2C System.Int32 serializationID
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"serializationID", "SERIALIZATION_ID")]

// class 0x30 System.String stringFolderOverride
// [MonoCollectorSearchFieldAttribute(typeof(nint),"stringFolderOverride", "STRING_FOLDER_OVERRIDE")]

// struct 0x38 System.Boolean isEquippable
[MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "isEquippable", "IS_EQUIPPABLE")]

// struct 0x39 System.Boolean isEquippedByDefault
[MonoCollectorSearchFieldAttribute(typeof(System.Boolean), "isEquippedByDefault", "IS_EQUIPPED_BY_DEFAULT")]

// struct 0x3C CodeStage.AntiCheat.ObscuredTypes.ObscuredBool canBeCopiedByCustomMode
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool),"canBeCopiedByCustomMode", "CAN_BE_COPIED_BY_CUSTOM_MODE")]

// struct 0x48 CodeStage.AntiCheat.ObscuredTypes.ObscuredBool canRandomizerFind
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool),"canRandomizerFind", "CAN_RANDOMIZER_FIND")]
public partial class DatabaseItems_Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x0200008FU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_DatabaseItems_Entry(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_DatabaseItems_Entry(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_DatabaseItems_Entry obj) => obj._ptr;
        public static implicit operator bool(Ptr_DatabaseItems_Entry obj) => obj.Valid();

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
public partial class DatabaseItems_Entry
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    ///   System.String GetCoreAuraPrefabName()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCoreAuraPrefabName")]
    ///  extern nint GET_CORE_AURA_PREFAB_NAME ();


    /// <summary>
    ///   System.String GetLocalizeNotNeeded(System.String unitNickname)
    /// </summary>
    /// <param name="unitNickname">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizeNotNeeded")]
    ///  extern nint GET_LOCALIZE_NOT_NEEDED (nint unitNickname);


    /// <summary>
    ///   System.String GetLocalizeUsage(System.Boolean player, System.String unitNickname)
    /// </summary>
    /// <param name="player">struct System.Boolean</param>
    /// <param name="unitNickname">class System.String</param>
    /// <returns>class System.String</returns>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizeUsage")]
    //extern PMonoString GET_LOCALIZE_USAGE(System.Boolean player, nint unitNickname);


    /// <summary>
    ///   System.String GetLocalizedCategoryName(System.Boolean singular)
    /// </summary>
    /// <param name="singular">struct System.Boolean</param>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedCategoryName")]
    extern PMonoString GET_LOCALIZED_CATEGORY_NAME(System.Boolean singular);


    /// <summary>
    ///   System.String GetLocalizedDescription()
    /// </summary>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription")]
    extern PMonoString GET_LOCALIZED_DESCRIPTION();


    /// <summary>
    ///   System.String GetLocalizedEquipLine(System.Boolean equipped)
    /// </summary>
    /// <param name="equipped">struct System.Boolean</param>
    /// <returns>class System.String</returns>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedEquipLine")]
    //extern PMonoString GET_LOCALIZED_EQUIP_LINE(System.Boolean equipped);


    /// <summary>
    ///   System.String GetLocalizedFind(System.Int32 amount)
    /// </summary>
    /// <param name="amount">struct System.Int32</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedFind")]
    ///  extern nint GET_LOCALIZED_FIND (System.Int32 amount);


    /// <summary>
    ///   System.String GetLocalizedName()
    /// </summary>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
    extern PMonoString GET_LOCALIZED_NAME();


    /// <summary>
    ///   System.String GetLocalizedPluralName()
    /// </summary>
    /// <returns>class System.String</returns>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedPluralName")]
    //extern PMonoString GET_LOCALIZED_PLURAL_NAME();


    /// <summary>
    ///   System.String GetLocalizedReceive(System.Int32 amount)
    /// </summary>
    /// <param name="amount">struct System.Int32</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedReceive")]
    ///  extern nint GET_LOCALIZED_RECEIVE (System.Int32 amount);


    /// <summary>
    ///   System.String GetLocalizedSingularName()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedSingularName")]
    ///  extern nint GET_LOCALIZED_SINGULAR_NAME ();


    /// <summary>
    ///   System.String GetStringFolder()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStringFolder")]
    ///  extern nint GET_STRING_FOLDER ();


    /// <summary>
    ///   System.Int32 GetWhistleEffectForElement(DatabaseElements.Entry element)
    /// </summary>
    /// <param name="element">class DatabaseElements.Entry</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetWhistleEffectForElement")]
    ///  extern System.Int32 GET_WHISTLE_EFFECT_FOR_ELEMENT (nint element);


    /// <summary>
    ///   System.Boolean IsCore()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCore")]
    extern System.Boolean IS_CORE();


    /// <summary>
    ///   System.Boolean IsNexotrap()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNexotrap")]
    extern System.Boolean IS_NEXOTRAP();


    /// <summary>
    ///   System.Boolean IsShard()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsShard")]
    extern System.Boolean IS_SHARD();


    /// <summary>
    ///   System.Boolean IsWhistle()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsWhistle")]
    extern System.Boolean IS_WHISTLE();




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
