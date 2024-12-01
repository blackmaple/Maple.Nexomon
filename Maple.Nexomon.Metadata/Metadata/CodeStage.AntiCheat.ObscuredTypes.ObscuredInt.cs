namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredInt"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>]=>[System.IComparable<System.Int32>]=>[System.IComparable]
/// </summary>
public partial class ObscuredInt
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public unsafe partial struct Ref_ObscuredInt
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 System.Int32 hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public System.Int32 hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x18 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x1C System.Int32 fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
        public readonly System.Int32 fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x20 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredInt"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>]=>[System.IComparable<System.Int32>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000016U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 73, 110, 116])]


// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 System.Int32 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x18 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x1C System.Int32 fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"fakeValue", "FAKE_VALUE")]

// struct 0x20 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredInt
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredInt";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 73, 110, 116];

    //public const uint Const_TypeToken = 0x02000016U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredInt(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredInt(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredInt obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredInt obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredInt"]
/// </summary>
public partial class ObscuredInt
{



    /// <summary>
    ///   System.Void .ctor(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    extern void CTOR(System.Int32 value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Int32 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int32 GENERATE_KEY ();


    /// <summary>
    ///   System.Int32 GetDecrypted()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    extern System.Int32 GET_DECRYPTED();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    static extern ObscuredInt.Ref_ObscuredInt INCREMENT(ObscuredInt.Ref_ObscuredInt input, System.Int32 increment);


    /// <summary>
    ///   System.Int32 InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    extern System.Int32 INTERNAL_DECRYPT();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.Int32 newKey)
    /// </summary>
    /// <param name="newKey">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.Int32 newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt OP_EXPLICIT (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Int32 other)
    /// </summary>
    /// <param name="other">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Int32 other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Int32 Decrypt(System.Int32 value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredInt))]
    static extern System.Int32 DECRYPT_00(System.Int32 value, System.Int32 key);


    /// <summary>
    /// static  System.Int32 Decrypt(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredInt))]
    /// static extern System.Int32 DECRYPT_01 (System.Int32 value);


    /// <summary>
    /// static  System.Int32 Encrypt(System.Int32 value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredInt))]
    static extern System.Int32 ENCRYPT_00(System.Int32 value, System.Int32 key);


    /// <summary>
    /// static  System.Int32 Encrypt(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredInt))]
    /// static extern System.Int32 ENCRYPT_01 (System.Int32 value);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FromEncrypted(System.Int32 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FROM_ENCRYPTED_00 (System.Int32 encrypted, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FromEncrypted(System.Int32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FROM_ENCRYPTED_01 (System.Int32 encrypted);


    /// <summary>
    ///   System.Int32 GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Int32 GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   System.Int32 GetEncrypted()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredInt))]
    ///  extern System.Int32 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Int32 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredInt))]
    ///  extern void SET_ENCRYPTED_00 (System.Int32 encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Int32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredInt))]
    ///  extern void SET_ENCRYPTED_01 (System.Int32 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredInt))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredInt))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredInt))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredInt))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Implicit(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OP_IMPLICIT_00 (System.Int32 value);


    /// <summary>
    /// static  System.Int32 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredInt))]
    /// static extern System.Int32 OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat OP_IMPLICIT_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble OP_IMPLICIT_03 (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);


    public static partial class Search_ObscuredInt
    {
        /// 
        ///     

        /// <summary>
        ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt other)
        /// </summary>
        /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 CompareTo(System.Int32 other)
        /// </summary>
        /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Int32");
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
        /// static  System.Int32 Decrypt(System.Int32 value, System.Int32 key)
        /// </summary>
        public static bool DECRYPT_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Int32 Decrypt(System.Int32 value)
        /// </summary>
        /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Int32 Encrypt(System.Int32 value, System.Int32 key)
        /// </summary>
        public static bool ENCRYPT_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Int32 Encrypt(System.Int32 value)
        /// </summary>
        /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Int32");
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
        ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj)
        /// </summary>
        /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FromEncrypted(System.Int32 encrypted, System.Int32 key)
        /// </summary>
        /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt FromEncrypted(System.Int32 encrypted)
        /// </summary>
        /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetEncrypted(System.Int32& key)
        /// </summary>
        /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int32&");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetEncrypted()
        /// </summary>
        /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetEncrypted(System.Int32 encrypted, System.Int32 key)
        /// </summary>
        /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetEncrypted(System.Int32 encrypted)
        /// </summary>
        /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int32");
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
        /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Implicit(System.Int32 value)
        /// </summary>
        /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Int32 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        /// </summary>
        /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        /// </summary>
        /// public static bool OP_IMPLICIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value)
        /// </summary>
        /// public static bool OP_IMPLICIT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt");
        ///     
        ///  
        /// 
        /// 
    }

}
