namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000AEU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// struct 0x10 System.Int32 questID
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"questID", "QUEST_ID")]

// class 0x18 System.String fileReference
// [MonoCollectorSearchFieldAttribute(typeof(nint),"fileReference", "FILE_REFERENCE")]

// class 0x20 System.Collections.Generic.List<DatabaseQuests.Entry.Objective> objectives
// [MonoCollectorSearchFieldAttribute(typeof(nint),"objectives", "OBJECTIVES")]

// class 0x28 System.Collections.Generic.List<DatabaseQuests.Entry.Reward> rewards
// [MonoCollectorSearchFieldAttribute(typeof(nint),"rewards", "REWARDS")]

// struct 0x30 System.Int32 reputation
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"reputation", "REPUTATION")]

// class 0x38 System.String body
// [MonoCollectorSearchFieldAttribute(typeof(nint),"body", "BODY")]

// class 0x40 System.String direction
// [MonoCollectorSearchFieldAttribute(typeof(nint),"direction", "DIRECTION")]

// struct 0x48 System.Boolean cyclic
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"cyclic", "CYCLIC")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x020000AEU;








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
    ///   System.String GetCodeText()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCodeText")]
    ///  extern nint GET_CODE_TEXT ();


    /// <summary>
    ///   DatabaseQuests.Entry.Objective GetCurrentObjective(SaveData data)
    /// </summary>
    /// <param name="data">class SaveData</param>
    /// <returns>class DatabaseQuests.Entry.Objective</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentObjective")]
    ///  extern nint GET_CURRENT_OBJECTIVE (nint data);


    /// <summary>
    ///   System.String GetLocalizedSummary()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedSummary")]
    ///  extern nint GET_LOCALIZED_SUMMARY ();


    /// <summary>
    ///   System.String GetLocalizedTitle()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedTitle")]
    ///  extern nint GET_LOCALIZED_TITLE ();


    /// <summary>
    ///   System.Void GiveRewardsToPlayer()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GiveRewardsToPlayer")]
    ///  extern void GIVE_REWARDS_TO_PLAYER ();


    /// <summary>
    ///   System.Boolean HasBegun(SaveData data)
    /// </summary>
    /// <param name="data">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasBegun")]
    ///  extern System.Boolean HAS_BEGUN (nint data);


    /// <summary>
    ///   System.Boolean IsCompleted(SaveData data)
    /// </summary>
    /// <param name="data">class SaveData</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCompleted")]
    ///  extern System.Boolean IS_COMPLETED (nint data);




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
