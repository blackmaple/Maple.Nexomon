namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000095U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// struct 0x10 System.Int32 id
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"id", "ID")]

// class 0x18 System.String parallax
// [MonoCollectorSearchFieldAttribute(typeof(nint),"parallax", "PARALLAX")]

// class 0x20 System.String autobgm
// [MonoCollectorSearchFieldAttribute(typeof(nint),"autobgm", "AUTOBGM")]

// class 0x28 System.String background
// [MonoCollectorSearchFieldAttribute(typeof(nint),"background", "BACKGROUND")]

// class 0x30 System.String liquid
// [MonoCollectorSearchFieldAttribute(typeof(nint),"liquid", "LIQUID")]

// class 0x38 System.String weather
// [MonoCollectorSearchFieldAttribute(typeof(nint),"weather", "WEATHER")]

// struct 0x40 System.Boolean arePetsAllowed
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"arePetsAllowed", "ARE_PETS_ALLOWED")]

// struct 0x41 System.Boolean checkpointAllowed
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"checkpointAllowed", "CHECKPOINT_ALLOWED")]

// class 0x48 DatabaseMaps.Entry.Autosave autosave
// [MonoCollectorSearchFieldAttribute(typeof(nint),"autosave", "AUTOSAVE")]

// class 0x50 System.Collections.Generic.List<DatabaseMaps.Entry.SmartAutoBGM> smartAutoBGMs
// [MonoCollectorSearchFieldAttribute(typeof(nint),"smartAutoBGMs", "SMART_AUTO_BG_MS")]

// class 0x58 System.Collections.Generic.List<DatabaseMaps.Entry.Reposition> repositions
// [MonoCollectorSearchFieldAttribute(typeof(nint),"repositions", "REPOSITIONS")]

// class 0x60 System.Collections.Generic.List<DatabaseMaps.Entry.HeadIcon> headIcons
// [MonoCollectorSearchFieldAttribute(typeof(nint),"headIcons", "HEAD_ICONS")]

// class 0x68 System.Collections.Generic.List<DatabaseMaps.Entry.AutoFade> autoFades
// [MonoCollectorSearchFieldAttribute(typeof(nint),"autoFades", "AUTO_FADES")]

// class 0x70 System.Collections.Generic.List<DatabaseMaps.Entry.Checkpoint> checkpoints
// [MonoCollectorSearchFieldAttribute(typeof(nint),"checkpoints", "CHECKPOINTS")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x02000095U;








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
    ///   DatabaseMaps.Entry.Checkpoint GetActiveCheckpoint()
    /// </summary>
    /// <returns>class DatabaseMaps.Entry.Checkpoint</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetActiveCheckpoint")]
    ///  extern nint GET_ACTIVE_CHECKPOINT ();


    /// <summary>
    ///   DatabaseMaps.Entry.Reposition GetActiveRepositionData(System.Int32 entityID)
    /// </summary>
    /// <param name="entityID">struct System.Int32</param>
    /// <returns>class DatabaseMaps.Entry.Reposition</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetActiveRepositionData")]
    ///  extern nint GET_ACTIVE_REPOSITION_DATA (System.Int32 entityID);


    /// <summary>
    ///   System.Boolean IsCave()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCave")]
    ///  extern System.Boolean IS_CAVE ();




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
