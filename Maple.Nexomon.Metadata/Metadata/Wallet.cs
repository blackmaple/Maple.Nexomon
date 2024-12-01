using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Wallet"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200007DU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [87, 97, 108, 108, 101, 116])]


// struct 0x10 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt coins
[MonoCollectorSearchFieldAttribute(typeof(ObscuredInt.Ref_ObscuredInt), "coins", "COINS", IsReadOnly = false)]

// struct 0x24 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt diamonds
[MonoCollectorSearchFieldAttribute(typeof(ObscuredInt.Ref_ObscuredInt), "diamonds", "DIAMONDS", IsReadOnly = false)]

// struct 0x38 CodeStage.AntiCheat.ObscuredTypes.ObscuredInt tokens
[MonoCollectorSearchFieldAttribute(typeof(ObscuredInt.Ref_ObscuredInt), "tokens", "TOKENS", IsReadOnly = false)]
public partial class Wallet
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Wallet";
    //public static byte[] Static_ClassName { get; } = [87, 97, 108, 108, 101, 116];

    //public const uint Const_TypeToken = 0x0200007DU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Wallet(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Wallet(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Wallet obj) => obj._ptr;
        public static implicit operator bool(Ptr_Wallet obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["Assembly-CSharp.dll".""."Wallet"]
/// </summary>
public partial class Wallet
{



    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetCoins()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCoins")]
    //extern ObscuredInt.Ref_ObscuredInt GET_COINS();
    //extern void GET_COINS(MapleOut<ObscuredInt.Ref_ObscuredInt> val);
    extern ObscuredInt.Ref_ObscuredInt GET_COINS();


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetDiamonds()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDiamonds")]
    //extern ObscuredInt.Ref_ObscuredInt GET_DIAMONDS();
    extern void GET_DIAMONDS(MapleOut<ObscuredInt.Ref_ObscuredInt> val);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredInt GetTokens()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTokens")]
    //extern ObscuredInt.Ref_ObscuredInt GET_TOKENS();
    extern void GET_TOKENS(MapleOut<ObscuredInt.Ref_ObscuredInt> val);


    /// <summary>
    ///   System.Void ReceiveCoins(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount, System.Boolean countTowardsAchievements)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <param name="countTowardsAchievements">struct System.Boolean</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveCoins")]
    extern void RECEIVE_COINS(MapleRef<ObscuredInt.Ref_ObscuredInt> amount, System.Boolean countTowardsAchievements);


    /// <summary>
    ///   System.Void ReceiveDiamonds(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveDiamonds")]
    extern void RECEIVE_DIAMONDS(MapleRef<ObscuredInt.Ref_ObscuredInt> amount);


    /// <summary>
    ///   System.Void ReceiveTokens(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReceiveTokens")]
    extern void RECEIVE_TOKENS(MapleRef<ObscuredInt.Ref_ObscuredInt> amount);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SpendCoins(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SpendCoins")]
    extern ObscuredBool.Ref_ObscuredBool SPEND_COINS(ObscuredInt.Ref_ObscuredInt amount);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SpendDiamonds(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SpendDiamonds")]
    extern ObscuredBool.Ref_ObscuredBool SPEND_DIAMONDS(ObscuredInt.Ref_ObscuredInt amount);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredBool SpendTokens(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amount)
    /// </summary>
    /// <param name="amount">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredBool</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SpendTokens")]
    extern ObscuredBool.Ref_ObscuredBool SPEND_TOKENS(ObscuredInt.Ref_ObscuredInt amount);


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
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Wallet))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(Wallet other)
    /// </summary>
    /// <param name="other">class Wallet</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Wallet))]
    ///  extern void .CTOR_01 (nint other);


    /// <summary>
    ///   System.Void .ctor(SimpleJSON.JSONClass preloadedData)
    /// </summary>
    /// <param name="preloadedData">class SimpleJSON.JSONClass</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Wallet))]
    ///  extern void .CTOR_02 (nint preloadedData);


    /// <summary>
    ///   System.Void .ctor(System.IO.BinaryReader reader)
    /// </summary>
    /// <param name="reader">class System.IO.BinaryReader</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Wallet))]
    ///  extern void .CTOR_03 (nint reader);


    /// public static partial class Search_Wallet
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
    ///   System.Void .ctor(Wallet other)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Wallet");
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
    /// 
    /// }

}
