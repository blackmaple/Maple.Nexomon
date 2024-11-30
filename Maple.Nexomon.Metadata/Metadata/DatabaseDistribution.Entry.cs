namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200008AU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// class 0x10 System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<DatabaseMonsters.Entry>> blocks
// [MonoCollectorSearchFieldAttribute(typeof(nint),"blocks", "BLOCKS")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x0200008AU;








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
    ///   System.Collections.Generic.List<DatabaseMonsters.Entry> GetPossibleEncounters(System.Int32 blockID, SaveData saveData)
    /// </summary>
    /// <param name="blockID">struct System.Int32</param>
    /// <param name="saveData">class SaveData</param>
    /// <returns>class System.Collections.Generic.List<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPossibleEncounters")]
    ///  extern nint GET_POSSIBLE_ENCOUNTERS (System.Int32 blockID, nint saveData);


    /// <summary>
    ///   System.Void PrintBlocks()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PrintBlocks")]
    ///  extern void PRINT_BLOCKS ();



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Entry))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONClass json)
    /// </summary>
    /// <param name="json">class SimpleJSON.JSONClass</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Entry))]
    ///  extern void .CTOR_01 (nint json);


    /// public static partial class Search_Entry
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
    ///   System.Void .ctor(SimpleJSON.JSONClass json)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SimpleJSON.JSONClass");
    ///     
    ///  
    /// 
    /// 
    /// }

}
