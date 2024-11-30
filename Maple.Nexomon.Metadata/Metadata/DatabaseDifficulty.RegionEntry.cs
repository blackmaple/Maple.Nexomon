namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."RegionEntry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000085U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [82, 101, 103, 105, 111, 110, 69, 110, 116, 114, 121])]


// class 0x10 System.Int32[] onSwitches
// [MonoCollectorSearchFieldAttribute(typeof(nint),"onSwitches", "ON_SWITCHES")]

// class 0x18 System.Int32[] offSwitches
// [MonoCollectorSearchFieldAttribute(typeof(nint),"offSwitches", "OFF_SWITCHES")]

// struct 0x20 System.Single weight
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"weight", "WEIGHT")]
public partial class RegionEntry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "RegionEntry";
    //public static byte[] Static_ClassName { get; } = [82, 101, 103, 105, 111, 110, 69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x02000085U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_RegionEntry(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_RegionEntry(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_RegionEntry obj) => obj._ptr;
        public static implicit operator bool(Ptr_RegionEntry obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."RegionEntry"]
/// </summary>
public partial class RegionEntry
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    ///   System.Boolean IsActive(SaveData data)
    /// </summary>
    /// <param name="data">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsActive")]
    ///  extern System.Boolean IS_ACTIVE (nint data);




    /// public static partial class Search_RegionEntry
    /// {
    /// 
    ///     
    /// 
    /// }

}
