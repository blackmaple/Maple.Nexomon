using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Equipment"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000056U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 113, 117, 105, 112, 109, 101, 110, 116])]


// class 0x10 System.Collections.Generic.Dictionary<DatabaseItems.Entry,System.Boolean> data
[MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_OptimizationSpeed<DatabaseItems_Entry.Ptr_DatabaseItems_Entry, bool>), "data", "DATA")]
public partial class Equipment
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Equipment";
    //public static byte[] Static_ClassName { get; } = [69, 113, 117, 105, 112, 109, 101, 110, 116];

    //public const uint Const_TypeToken = 0x02000056U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Equipment(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Equipment(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Equipment obj) => obj._ptr;
        public static implicit operator bool(Ptr_Equipment obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Equipment"]
/// </summary>
public partial class Equipment
{



    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (nint reader);


    /// <summary>
    ///   System.Boolean IsItemEquipped(DatabaseItems.Entry itemData, SaveData currentData)
    /// </summary>
    /// <param name="itemData">class DatabaseItems.Entry</param>
    /// <param name="currentData">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsItemEquipped")]
    ///  extern System.Boolean IS_ITEM_EQUIPPED (nint itemData, nint currentData);


    /// <summary>
    ///   System.Void ResetEquipment()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetEquipment")]
    ///  extern void RESET_EQUIPMENT ();


    /// <summary>
    ///   System.Void SetItemEquipped(DatabaseItems.Entry itemData, System.Boolean value, SaveData currentData)
    /// </summary>
    /// <param name="itemData">class DatabaseItems.Entry</param>
    /// <param name="value">struct System.Boolean</param>
    /// <param name="currentData">class SaveData</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItemEquipped")]
    extern void SET_ITEM_EQUIPPED(DatabaseItems_Entry.Ptr_DatabaseItems_Entry itemData, System.Boolean value, nint currentData);


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   System.Void ToggleItemEquipment(DatabaseItems.Entry itemData, SaveData currentData)
    /// </summary>
    /// <param name="itemData">class DatabaseItems.Entry</param>
    /// <param name="currentData">class SaveData</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToggleItemEquipment")]
    ///  extern void TOGGLE_ITEM_EQUIPMENT (nint itemData, nint currentData);




    /// public static partial class Search_Equipment
    /// {
    /// 
    ///     
    /// 
    /// }

}
