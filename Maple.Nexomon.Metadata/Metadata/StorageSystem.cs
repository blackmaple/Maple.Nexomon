namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."StorageSystem"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200006CU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 116, 111, 114, 97, 103, 101, 83, 121, 115, 116, 101, 109])]


// class 0x10 System.Collections.Generic.List<StorageSystem.Box> boxes
// [MonoCollectorSearchFieldAttribute(typeof(nint),"boxes", "BOXES")]
public partial class StorageSystem
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "StorageSystem";
    //public static byte[] Static_ClassName { get; } = [83, 116, 111, 114, 97, 103, 101, 83, 121, 115, 116, 101, 109];

    //public const uint Const_TypeToken = 0x0200006CU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_StorageSystem(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_StorageSystem(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_StorageSystem obj) => obj._ptr;
        public static implicit operator bool(Ptr_StorageSystem obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."StorageSystem"]
/// </summary>
public partial class StorageSystem
{



    /// <summary>
    ///   System.Int32 CountUnits()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CountUnits")]
    ///  extern System.Int32 COUNT_UNITS ();


    /// <summary>
    ///   StorageSystem.Box DepositAnywhere(Unit unit, System.Boolean createBoxIfNecessary)
    /// </summary>
    /// <param name="unit">class Unit</param>
    /// <param name="createBoxIfNecessary">struct System.Boolean</param>
    /// <returns>class StorageSystem.Box</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DepositAnywhere")]
    extern Box.Ptr_Box DEPOSIT_ANYWHERE(Unit.Ptr_Unit unit, System.Boolean createBoxIfNecessary);


    /// <summary>
    ///   System.Void ToBinary(System.IO.BinaryWriter writer)
    /// </summary>
    /// <param name="writer">class System.IO.BinaryWriter</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToBinary")]
    ///  extern void TO_BINARY (nint writer);


    /// <summary>
    ///   SimpleJSON.JSONArray ToJSON()
    /// </summary>
    /// <returns>class SimpleJSON.JSONArray</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToJSON")]
    ///  extern nint TO_JSON ();



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StorageSystem))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(StorageSystem other, StorageSystem.CustomModeCopyInfo copyInfo)
    /// </summary>
    /// <param name="other">class StorageSystem</param>
    /// <param name="copyInfo">class StorageSystem.CustomModeCopyInfo</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StorageSystem))]
    ///  extern void .CTOR_01 (nint other, nint copyInfo);


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONArray json)
    /// </summary>
    /// <param name="json">class SimpleJSON.JSONArray</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StorageSystem))]
    ///  extern void .CTOR_02 (nint json);


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader, System.Int32 incomingBuildVersion)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <param name="incomingBuildVersion">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_StorageSystem))]
    ///  extern void .CTOR_03 (nint reader, System.Int32 incomingBuildVersion);


    /// public static partial class Search_StorageSystem
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
    ///   System.Void .ctor(StorageSystem other, StorageSystem.CustomModeCopyInfo copyInfo)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "StorageSystem", "StorageSystem.CustomModeCopyInfo");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONArray json)
    /// </summary>
    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "SimpleJSON.JSONArray");
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
