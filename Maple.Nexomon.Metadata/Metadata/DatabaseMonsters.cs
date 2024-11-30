using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."DatabaseMonsters"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200009FU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [68, 97, 116, 97, 98, 97, 115, 101, 77, 111, 110, 115, 116, 101, 114, 115])]

//  class static System.Collections.Generic.List<DatabaseMonsters.Entry> data
[MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry>), "data", "DATA", true)]

//  class static System.Collections.Generic.Dictionary<System.Int32,DatabaseMonsters.Entry> uniqueIDMapping
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"uniqueIDMapping", "UNIQUE_ID_MAPPING", true)]

//  class static System.Collections.Generic.List<System.Collections.Generic.List<DatabaseMonsters.Entry>> evolutionLines
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"evolutionLines", "EVOLUTION_LINES", true)]

//  class static System.Collections.Generic.HashSet<DatabaseMonsters.Entry> specifiedModernTyrants
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"specifiedModernTyrants", "SPECIFIED_MODERN_TYRANTS", true)]

//  class static System.Collections.Generic.HashSet<DatabaseMonsters.Entry> specifiedPrimordialTyrants
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"specifiedPrimordialTyrants", "SPECIFIED_PRIMORDIAL_TYRANTS", true)]

//  class static System.Collections.Generic.HashSet<DatabaseMonsters.Entry> specifiedGreaterDrakes
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"specifiedGreaterDrakes", "SPECIFIED_GREATER_DRAKES", true)]

//  class static System.Collections.Generic.List<DatabaseMonsters.Entry> cachedTier1Entries
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"cachedTier1Entries", "CACHED_TIER1_ENTRIES", true)]

//  class static System.Collections.Generic.List<DatabaseMonsters.Entry> cachedTier2Entries
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"cachedTier2Entries", "CACHED_TIER2_ENTRIES", true)]

//  class static System.Collections.Generic.List<DatabaseMonsters.Entry> cachedTier3Entries
//  [MonoCollectorSearchFieldAttribute(typeof(nint),"cachedTier3Entries", "CACHED_TIER3_ENTRIES", true)]

public partial class DatabaseMonsters
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "DatabaseMonsters";
    //public static byte[] Static_ClassName { get; } = [68, 97, 116, 97, 98, 97, 115, 101, 77, 111, 110, 115, 116, 101, 114, 115];

    //public const uint Const_TypeToken = 0x0200009FU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_DatabaseMonsters(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_DatabaseMonsters(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_DatabaseMonsters obj) => obj._ptr;
        public static implicit operator bool(Ptr_DatabaseMonsters obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."DatabaseMonsters"]
/// </summary>
public partial class DatabaseMonsters
{



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR ();


    /// <summary>
    /// static  System.Collections.Generic.List<DatabaseMonsters.Entry> GetAllEntries()
    /// </summary>
    /// <returns>class System.Collections.Generic.List<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllEntries")]
    /// static extern nint GET_ALL_ENTRIES ();


    /// <summary>
    /// static  System.Collections.Generic.HashSet<DatabaseMonsters.Entry> GetSpecifiedGreaterDrakes()
    /// </summary>
    /// <returns>class System.Collections.Generic.HashSet<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpecifiedGreaterDrakes")]
    /// static extern nint GET_SPECIFIED_GREATER_DRAKES ();


    /// <summary>
    /// static  System.Collections.Generic.HashSet<DatabaseMonsters.Entry> GetSpecifiedModernTyrants()
    /// </summary>
    /// <returns>class System.Collections.Generic.HashSet<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpecifiedModernTyrants")]
    /// static extern nint GET_SPECIFIED_MODERN_TYRANTS ();


    /// <summary>
    /// static  System.Collections.Generic.HashSet<DatabaseMonsters.Entry> GetSpecifiedPrimordialTyrants()
    /// </summary>
    /// <returns>class System.Collections.Generic.HashSet<DatabaseMonsters.Entry></returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpecifiedPrimordialTyrants")]
    /// static extern nint GET_SPECIFIED_PRIMORDIAL_TYRANTS ();


    /// <summary>
    /// static  System.Collections.IEnumerator Initialize(UnityEngine.Events.UnityAction callback)
    /// </summary>
    /// <param name="callback">class UnityEngine.Events.UnityAction</param>
    /// <returns>interface System.Collections.IEnumerator</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
    /// static extern nint INITIALIZE (nint callback);



    /// <summary>
    /// static  System.Boolean Exists(System.String monsterName)
    /// </summary>
    /// <param name="monsterName">class System.String</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Exists", Search = typeof(Search_DatabaseMonsters))]
    /// static extern System.Boolean EXISTS_00 (nint monsterName);


    /// <summary>
    /// static  System.Boolean Exists(System.Int32 uniqueID)
    /// </summary>
    /// <param name="uniqueID">struct System.Int32</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Exists", Search = typeof(Search_DatabaseMonsters))]
    /// static extern System.Boolean EXISTS_01 (System.Int32 uniqueID);


    /// <summary>
    /// static  DatabaseMonsters.Entry GetEntry(System.String monsterName)
    /// </summary>
    /// <param name="monsterName">class System.String</param>
    /// <returns>class DatabaseMonsters.Entry</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntry", Search = typeof(Search_DatabaseMonsters))]
    static extern DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry GET_ENTRY_00(nint monsterName);


    /// <summary>
    /// static  DatabaseMonsters.Entry GetEntry(System.Int32 uniqueID)
    /// </summary>
    /// <param name="uniqueID">struct System.Int32</param>
    /// <returns>class DatabaseMonsters.Entry</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntry", Search = typeof(Search_DatabaseMonsters))]
    static extern DatabaseMonsters_Entry.Ptr_DatabaseMonsters_Entry GET_ENTRY_01(System.Int32 uniqueID);


    public static partial class Search_DatabaseMonsters
    {
        /// 
        ///     

        /// <summary>
        /// static  System.Boolean Exists(System.String monsterName)
        /// </summary>
        /// public static bool EXISTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Exists", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Boolean Exists(System.Int32 uniqueID)
        /// </summary>
        /// public static bool EXISTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Exists", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  DatabaseMonsters.Entry GetEntry(System.String monsterName)
        /// </summary>
        public static bool GET_ENTRY_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntry", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  DatabaseMonsters.Entry GetEntry(System.Int32 uniqueID)
        /// </summary>
        public static bool GET_ENTRY_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntry", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }
}