using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Runtime.InteropServices;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Inventory"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000058U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [73, 110, 118, 101, 110, 116, 111, 114, 121])]


// class 0x10 System.Collections.Generic.Dictionary<CodeStage.AntiCheat.ObscuredTypes.ObscuredString,CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> content
[MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_Ghostmon<ObscuredString.Ptr_ObscuredString, ObscuredInt.Ref_ObscuredInt>), "content", "CONTENT")]
public partial class Inventory
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Inventory";
    //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121];

    //public const uint Const_TypeToken = 0x02000058U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Inventory(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Inventory(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Inventory obj) => obj._ptr;
        public static implicit operator bool(Ptr_Inventory obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Inventory"]
/// </summary>
public partial class Inventory
{



    /// <summary>
    ///   System.Void Cleanup()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Cleanup")]
    ///  extern void CLEANUP ();


    /// <summary>
    ///   System.Int32 ComputeChecksum()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ComputeChecksum")]
    ///  extern System.Int32 COMPUTE_CHECKSUM ();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool Consume(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="itemKey">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    ///[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Consume")]
    ///extern ObscuredBool.Ref_ObscuredBool CONSUME(ObscuredString.Ptr_ObscuredString itemKey, ObscuredInt.Ref_ObscuredInt amount);


    /// <summary>
    ///   System.Int32 CountItems()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountItems")]
    ///  extern System.Int32 COUNT_ITEMS ();


    /// <summary>
    ///   System.Boolean EnsureItem(System.String itemKey, System.Int32 amount)
    /// </summary>
    /// <param name="itemKey">class System.String</param>
    /// <param name="amount">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureItem")]
    ///  extern System.Boolean ENSURE_ITEM (nint itemKey, System.Int32 amount);


    /// <summary>
    ///   System.Void RemoveItemsThatCannotBeCopiedByCustomMode()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemsThatCannotBeCopiedByCustomMode")]
    ///  extern void REMOVE_ITEMS_THAT_CANNOT_BE_COPIED_BY_CUSTOM_MODE ();


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   SimpleJSON.JSONClass ToJSON()
    /// </summary>
    /// <returns>class SimpleJSON.JSONClass</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToJSON")]
    ///  extern nint TO_JSON ();



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(Inventory other)
    /// </summary>
    /// <param name="other">class Inventory</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
    ///  extern void .CTOR_01 (nint other);


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONClass preloadedData)
    /// </summary>
    /// <param name="preloadedData">class SimpleJSON.JSONClass</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
    ///  extern void .CTOR_02 (nint preloadedData);


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Inventory))]
    ///  extern void .CTOR_03 (nint reader);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool AddItem(DatabaseItems.Entry itemData, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="itemData">class DatabaseItems.Entry</param>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItem", Search = typeof(Search_Inventory))]
    //extern ObscuredBool.Ref_ObscuredBool ADD_ITEM_00(DatabaseItems_Entry.Ptr_DatabaseItems_Entry itemData, ObscuredInt.Ref_ObscuredInt amount);
    extern ObscuredBool.Ref_ObscuredBool ADD_ITEM_00(DatabaseItems_Entry.Ptr_DatabaseItems_Entry itemData, MapleRef<ObscuredInt.Ref_ObscuredInt> amount);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool AddItem(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="itemKey">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
 //   [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItem", Search = typeof(Search_Inventory))]
    //extern ObscuredBool.Ref_ObscuredBool ADD_ITEM_01(ObscuredString.Ptr_ObscuredString itemKey, ObscuredInt.Ref_ObscuredInt amount);
 //   extern ObscuredBool.Ref_ObscuredBool ADD_ITEM_01(ObscuredString.Ptr_ObscuredString itemKey, MapleRef<ObscuredInt.Ref_ObscuredInt> amount);


    /// <summary>
    ///   System.Void CompletelyRemoveItem(DatabaseItems.Entry itemData)
    /// </summary>
    /// <param name="itemData">class DatabaseItems.Entry</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompletelyRemoveItem", Search = typeof(Search_Inventory))]
    extern void COMPLETELY_REMOVE_ITEM_00(DatabaseItems_Entry.Ptr_DatabaseItems_Entry itemData);


    /// <summary>
    ///   System.Void CompletelyRemoveItem(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey)
    /// </summary>
    /// <param name="itemKey">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct System.Void</returns>
    ///   [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompletelyRemoveItem", Search = typeof(Search_Inventory))]
    ///  extern void COMPLETELY_REMOVE_ITEM_01(nint itemKey);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetQuantity(DatabaseItems.Entry info)
    /// </summary>
    /// <param name="info">class DatabaseItems.Entry</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    ///    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetQuantity", Search = typeof(Search_Inventory))]
    //extern ObscuredInt.Ref_ObscuredInt GET_QUANTITY_00(DatabaseItems_Entry.Ptr_DatabaseItems_Entry info);
    ///   extern ObscuredInt.Ptr_ObscuredInt GET_QUANTITY_00(MapleOut<ObscuredInt.Ref_ObscuredInt> val,DatabaseItems_Entry.Ptr_DatabaseItems_Entry info);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetQuantity(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey)
    /// </summary>
    /// <param name="itemKey">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetQuantity", Search = typeof(Search_Inventory))]
    //extern ObscuredInt.Ref_ObscuredInt GET_QUANTITY_01(ObscuredString.Ptr_ObscuredString itemKey);
    /// extern ObscuredInt.Ptr_ObscuredInt GET_QUANTITY_01(MapleOut<ObscuredInt.Ref_ObscuredInt> val, ObscuredString.Ptr_ObscuredString itemKey);


    public static partial class Search_Inventory
    {
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
        ///   System.Void .ctor(Inventory other)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Inventory");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(SimpleJSON.JSONClass preloadedData)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SimpleJSON.JSONClass");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.IO.BinaryReader reader)
        /// </summary>
        /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.IO.BinaryReader");
        ///     
        ///  
        /// 


        /// <summary>
        ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool AddItem(DatabaseItems.Entry itemData, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
        /// </summary>
        public static bool ADD_ITEM_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItem", "DatabaseItems.Entry", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");





        /// <summary>
        ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool AddItem(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
        /// </summary>
        public static bool ADD_ITEM_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItem", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");





        /// <summary>
        ///   System.Void CompletelyRemoveItem(DatabaseItems.Entry itemData)
        /// </summary>
        public static bool COMPLETELY_REMOVE_ITEM_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompletelyRemoveItem", "DatabaseItems.Entry");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CompletelyRemoveItem(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey)
        /// </summary>
        public static bool COMPLETELY_REMOVE_ITEM_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompletelyRemoveItem", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString");
        ///     
        ///  
        /// 


        /// <summary>
        ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetQuantity(DatabaseItems.Entry info)
        /// </summary>
        public static bool GET_QUANTITY_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
          => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetQuantity", "DatabaseItems.Entry");





        /// <summary>
        ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetQuantity(CodeStage.AntiCheat.ObscuredTypes.ObscuredString itemKey)
        /// </summary>
        public static bool GET_QUANTITY_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetQuantity", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString");




    }

}
