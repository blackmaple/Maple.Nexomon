using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."DatabaseItems"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200008EU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [68, 97, 116, 97, 98, 97, 115, 101, 73, 116, 101, 109, 115])]

//  class static System.Collections.Generic.Dictionary<System.String,DatabaseItems.Entry> data
[MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<PMonoString, DatabaseItems_Entry.Ptr_DatabaseItems_Entry>), "data", "DATA", true)]

public partial class DatabaseItems
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "DatabaseItems";
    //public static byte[] Static_ClassName { get; } = [68, 97, 116, 97, 98, 97, 115, 101, 73, 116, 101, 109, 115];

    //public const uint Const_TypeToken = 0x0200008EU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_DatabaseItems(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_DatabaseItems(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_DatabaseItems obj) => obj._ptr;
        public static implicit operator bool(Ptr_DatabaseItems obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."DatabaseItems"]
/// </summary>
public partial class DatabaseItems
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    /// static  System.Boolean Exists(System.String itemKey)
    /// </summary>
    /// <param name="itemKey">class System.String</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Exists")]
    /// static extern System.Boolean EXISTS (nint itemKey);


    /// <summary>
    /// static  System.Boolean ExistsWithSerializationCode(System.Int32 serializationCode)
    /// </summary>
    /// <param name="serializationCode">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExistsWithSerializationCode")]
    /// static extern System.Boolean EXISTS_WITH_SERIALIZATION_CODE (System.Int32 serializationCode);


    /// <summary>
    /// static  System.Collections.Generic.List<DatabaseItems.Entry> GetEntriesForCategory(System.String category)
    /// </summary>
    /// <param name="category">class System.String</param>
    /// <returns>class System.Collections.Generic.List<DatabaseItems.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntriesForCategory")]
    /// static extern nint GET_ENTRIES_FOR_CATEGORY (nint category);


    /// <summary>
    /// static  DatabaseItems.Entry GetEntry(System.String itemKey)
    /// </summary>
    /// <param name="itemKey">class System.String</param>
    /// <returns>class DatabaseItems.Entry</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntry")]
    static extern DatabaseItems_Entry.Ptr_DatabaseItems_Entry GET_ENTRY(nint itemKey);


    /// <summary>
    /// static  DatabaseItems.Entry GetEntryBySerializationCode(System.Int32 serializationCode)
    /// </summary>
    /// <param name="serializationCode">struct System.Int32</param>
    /// <returns>class DatabaseItems.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntryBySerializationCode")]
    /// static extern nint GET_ENTRY_BY_SERIALIZATION_CODE (System.Int32 serializationCode);


    /// <summary>
    /// static  System.Collections.Generic.List<DatabaseItems.Entry> GetItemsThatCanBeFoundByRandomizer()
    /// </summary>
    /// <returns>class System.Collections.Generic.List<DatabaseItems.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemsThatCanBeFoundByRandomizer")]
    /// static extern nint GET_ITEMS_THAT_CAN_BE_FOUND_BY_RANDOMIZER ();


    /// <summary>
    /// static  System.Void Initialize()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
    /// static extern void INITIALIZE ();




    /// public static partial class Search_DatabaseItems
    /// {
    /// 
    ///     
    /// 
    /// }

}
