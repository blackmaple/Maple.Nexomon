namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200008DU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// class 0x10 System.String id
// [MonoCollectorSearchFieldAttribute(typeof(nint),"id", "ID")]

// class 0x18 System.Collections.Generic.Dictionary<System.String,System.Single> matchups
// [MonoCollectorSearchFieldAttribute(typeof(nint),"matchups", "MATCHUPS")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x0200008DU;








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
    ///   UnityEngine.Sprite GetIcon()
    /// </summary>
    /// <returns>class UnityEngine.Sprite</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIcon", Search = typeof(Search_Entry))]
    ///  extern nint GET_ICON_00 ();


    /// <summary>
    ///   UnityEngine.Sprite GetIcon(System.String variant)
    /// </summary>
    /// <param name="variant">class System.String</param>
    /// <returns>class UnityEngine.Sprite</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIcon", Search = typeof(Search_Entry))]
    ///  extern nint GET_ICON_01 (nint variant);


    /// <summary>
    ///   System.Single GetMatchupValue(DatabaseElements.Entry otherElement)
    /// </summary>
    /// <param name="otherElement">class DatabaseElements.Entry</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMatchupValue", Search = typeof(Search_Entry))]
    ///  extern System.Single GET_MATCHUP_VALUE_00 (nint otherElement);


    /// <summary>
    ///   System.Single GetMatchupValue(System.String otherElement)
    /// </summary>
    /// <param name="otherElement">class System.String</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMatchupValue", Search = typeof(Search_Entry))]
    ///  extern System.Single GET_MATCHUP_VALUE_01 (nint otherElement);


    /// public static partial class Search_Entry
    /// {
    /// 
    ///     

    /// <summary>
    ///   UnityEngine.Sprite GetIcon()
    /// </summary>
    /// public static bool GET_ICON_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetIcon");
    ///     
    ///  
    /// 


    /// <summary>
    ///   UnityEngine.Sprite GetIcon(System.String variant)
    /// </summary>
    /// public static bool GET_ICON_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetIcon", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Single GetMatchupValue(DatabaseElements.Entry otherElement)
    /// </summary>
    /// public static bool GET_MATCHUP_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatchupValue", "DatabaseElements.Entry");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Single GetMatchupValue(System.String otherElement)
    /// </summary>
    /// public static bool GET_MATCHUP_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetMatchupValue", "System.String");
    ///     
    ///  
    /// 
    /// 
    /// }

}
