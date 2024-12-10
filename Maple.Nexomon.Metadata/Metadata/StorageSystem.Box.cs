namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Box"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200006EU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [66, 111, 120])]


// class 0x10 System.String name
// [MonoCollectorSearchFieldAttribute(typeof(nint),"name", "NAME")]

// class 0x18 System.Collections.Generic.List<Unit> units
// [MonoCollectorSearchFieldAttribute(typeof(nint),"units", "UNITS")]

// struct 0x20 System.Int32 capacity
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"capacity", "CAPACITY")]
public partial class Box
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Box";
    //public static byte[] Static_ClassName { get; } = [66, 111, 120];

    //public const uint Const_TypeToken = 0x0200006EU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Box(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Box(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Box obj) => obj._ptr;
        public static implicit operator bool(Ptr_Box obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Box"]
/// </summary>
public partial class Box
{



    /// <summary>
    ///   System.Int32 CountUnits()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountUnits")]
    ///  extern System.Int32 COUNT_UNITS ();


    /// <summary>
    ///   System.Boolean DepositUnit(System.Int32 index, Unit unit)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <param name="unit">class Unit</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DepositUnit")]
    ///  extern System.Boolean DEPOSIT_UNIT (System.Int32 index, nint unit);


    /// <summary>
    ///   System.Int32 GetFirstAvailableIndex()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFirstAvailableIndex")]
    ///  extern System.Int32 GET_FIRST_AVAILABLE_INDEX ();


    /// <summary>
    ///   System.String GetName()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
    ///  extern nint GET_NAME ();


    /// <summary>
    ///   System.Void ReleaseAllUnits()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReleaseAllUnits")]
    ///  extern void RELEASE_ALL_UNITS ();


    /// <summary>
    ///   System.Boolean ReleaseUnit(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReleaseUnit")]
    ///  extern System.Boolean RELEASE_UNIT (System.Int32 index);


    /// <summary>
    ///   System.Void SetName(System.String newName)
    /// </summary>
    /// <param name="newName">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
    ///  extern void SET_NAME (nint newName);


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
    ///   System.Boolean WithdrawUnitToParty(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
   /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WithdrawUnitToParty")]
  ///  extern System.Boolean WITHDRAW_UNIT_TO_PARTY(System.Int32 index);



    /// <summary>
    ///   System.Void .ctor(System.Int32 capacity, System.String name)
    /// </summary>
    /// <param name="capacity">struct System.Int32</param>
    /// <param name="name">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Box))]
    ///  extern void .CTOR_00 (System.Int32 capacity, nint name);


    /// <summary>
    ///   System.Void .ctor(StorageSystem.Box other, StorageSystem.CustomModeCopyInfo copyInfo)
    /// </summary>
    /// <param name="other">class StorageSystem.Box</param>
    /// <param name="copyInfo">class StorageSystem.CustomModeCopyInfo</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Box))]
    ///  extern void .CTOR_01 (nint other, nint copyInfo);


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONClass json)
    /// </summary>
    /// <param name="json">class SimpleJSON.JSONClass</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Box))]
    ///  extern void .CTOR_02 (nint json);


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader, System.Int32 incomingBuildVersion)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <param name="incomingBuildVersion">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Box))]
    ///  extern void .CTOR_03 (nint reader, System.Int32 incomingBuildVersion);


    /// public static partial class Search_Box
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor(System.Int32 capacity, System.String name)
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(StorageSystem.Box other, StorageSystem.CustomModeCopyInfo copyInfo)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "StorageSystem.Box", "StorageSystem.CustomModeCopyInfo");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONClass json)
    /// </summary>
    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SimpleJSON.JSONClass");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader, System.Int32 incomingBuildVersion)
    /// </summary>
    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.IO.BinaryReader", "System.Int32");
    ///     
    ///  
    /// 
    /// 
    /// }

}
