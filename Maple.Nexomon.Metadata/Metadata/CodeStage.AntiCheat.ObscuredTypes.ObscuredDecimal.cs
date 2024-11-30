using System.Runtime.InteropServices;

namespace Maple.Nexomon.Metadata;
/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDecimal"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>]=>[System.IComparable<System.Decimal>]=>[System.IComparable]
/// </summary>
public partial class ObscuredDecimal
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredDecimal
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int64 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int64 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x18 CodeStage.AntiCheat.Common.ACTkByte16 hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly  ACTkByte16 hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x28 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x2C System.Decimal fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x1C)]
        public readonly System.Decimal fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x3C System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x2C)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDecimal"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>]=>[System.IComparable<System.Decimal>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000010U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 68, 101, 99, 105, 109, 97, 108])]


// struct 0x10 System.Int64 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int64),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x18 CodeStage.AntiCheat.Common.ACTkByte16 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.Common.ACTkByte16),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x28 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x2C System.Decimal fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Decimal),"fakeValue", "FAKE_VALUE")]

// struct 0x3C System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredDecimal
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredDecimal";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 68, 101, 99, 105, 109, 97, 108];

    //public const uint Const_TypeToken = 0x02000010U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredDecimal(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredDecimal(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredDecimal obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredDecimal obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDecimal"]
/// </summary>
public partial class ObscuredDecimal
{



    /// <summary>
    ///   System.Void .ctor(System.Decimal value)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Decimal value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Int64 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int64 GENERATE_KEY ();


    /// <summary>
    ///   System.Decimal GetDecrypted()
    /// </summary>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Decimal GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input, System.Decimal increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <param name="increment">struct System.Decimal</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input, System.Decimal increment);


    /// <summary>
    ///   System.Decimal InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Decimal INTERNAL_DECRYPT ();


    /// <summary>
    /// static  CodeStage.AntiCheat.Common.ACTkByte16 InternalEncrypt(System.Decimal value, System.Int64 key)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct CodeStage.AntiCheat.Common.ACTkByte16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalEncrypt")]
    /// static extern CodeStage.AntiCheat.Common.ACTkByte16 INTERNAL_ENCRYPT (System.Decimal value, System.Int64 key);


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.Int64 newKey)
    /// </summary>
    /// <param name="newKey">struct System.Int64</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.Int64 newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f)
    /// </summary>
    /// <param name="f">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal OP_EXPLICIT (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Decimal other)
    /// </summary>
    /// <param name="other">struct System.Decimal</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Decimal other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Decimal Decrypt(System.Decimal value, System.Int64 key)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredDecimal))]
    /// static extern System.Decimal DECRYPT_00 (System.Decimal value, System.Int64 key);


    /// <summary>
    /// static  System.Decimal Decrypt(System.Decimal value)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredDecimal))]
    /// static extern System.Decimal DECRYPT_01 (System.Decimal value);


    /// <summary>
    /// static  System.Decimal Encrypt(System.Decimal value, System.Int64 key)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredDecimal))]
    /// static extern System.Decimal ENCRYPT_00 (System.Decimal value, System.Int64 key);


    /// <summary>
    /// static  System.Decimal Encrypt(System.Decimal value)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredDecimal))]
    /// static extern System.Decimal ENCRYPT_01 (System.Decimal value);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FromEncrypted(System.Decimal encrypted, System.Int64 key)
    /// </summary>
    /// <param name="encrypted">struct System.Decimal</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredDecimal))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FROM_ENCRYPTED_00 (System.Decimal encrypted, System.Int64 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FromEncrypted(System.Decimal encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Decimal</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredDecimal))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FROM_ENCRYPTED_01 (System.Decimal encrypted);


    /// <summary>
    ///   System.Decimal GetEncrypted(System.Int64& key)
    /// </summary>
    /// <param name="key">struct System.Int64&</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Decimal GET_ENCRYPTED_00 (System.Int64& key);


    /// <summary>
    ///   System.Decimal GetEncrypted()
    /// </summary>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredDecimal))]
    ///  extern System.Decimal GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Decimal encrypted, System.Int64 key)
    /// </summary>
    /// <param name="encrypted">struct System.Decimal</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredDecimal))]
    ///  extern void SET_ENCRYPTED_00 (System.Decimal encrypted, System.Int64 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Decimal encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Decimal</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredDecimal))]
    ///  extern void SET_ENCRYPTED_01 (System.Decimal encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDecimal))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDecimal))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDecimal))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDecimal))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Implicit(System.Decimal value)
    /// </summary>
    /// <param name="value">struct System.Decimal</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredDecimal))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal OP_IMPLICIT_00 (System.Decimal value);


    /// <summary>
    /// static  System.Decimal op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal</param>
    /// <returns>struct System.Decimal</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredDecimal))]
    /// static extern System.Decimal OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value);


    /// public static partial class Search_ObscuredDecimal
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Decimal other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// public static bool COMPARE_TO_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Object");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Decimal Decrypt(System.Decimal value, System.Int64 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Decimal", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Decimal Decrypt(System.Decimal value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Decimal Encrypt(System.Decimal value, System.Int64 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Decimal", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Decimal Encrypt(System.Decimal value)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// public static bool EQUALS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "System.Object");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FromEncrypted(System.Decimal encrypted, System.Int64 key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Decimal", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal FromEncrypted(System.Decimal encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Decimal GetEncrypted(System.Int64& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int64&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Decimal GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Decimal encrypted, System.Int64 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Decimal", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Decimal encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// public static bool TO_STRING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.IFormatProvider");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// public static bool TO_STRING_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.String", "System.IFormatProvider");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Implicit(System.Decimal value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Decimal");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Decimal op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal");
    ///     
    ///  
    /// 
    /// 
    /// }

}
