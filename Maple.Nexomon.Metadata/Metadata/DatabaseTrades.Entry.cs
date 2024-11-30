namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000C6U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// class 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredString id
// [MonoCollectorSearchFieldAttribute(typeof(nint),"id", "ID")]

// class 0x18 System.Collections.Generic.List<DatabaseTrades.Entry.Offer> playerOffers
// [MonoCollectorSearchFieldAttribute(typeof(nint),"playerOffers", "PLAYER_OFFERS")]

// class 0x20 System.Collections.Generic.List<DatabaseTrades.Entry.Offer> npcOffers
// [MonoCollectorSearchFieldAttribute(typeof(nint),"npcOffers", "NPC_OFFERS")]

// class 0x28 System.String npcBody
// [MonoCollectorSearchFieldAttribute(typeof(nint),"npcBody", "NPC_BODY")]

// class 0x30 System.String npcDirection
// [MonoCollectorSearchFieldAttribute(typeof(nint),"npcDirection", "NPC_DIRECTION")]

// struct 0x38 System.Boolean npcCyclicAnimation
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"npcCyclicAnimation", "NPC_CYCLIC_ANIMATION")]

// struct 0x39 System.Boolean autoTriggerTraderSwitch
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"autoTriggerTraderSwitch", "AUTO_TRIGGER_TRADER_SWITCH")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x020000C6U;








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




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
