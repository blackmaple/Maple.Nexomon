namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredUInt"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>]=>[System.IComparable<System.UInt32>]=>[System.IComparable]
/// </summary>
public partial class ObscuredUInt
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredUInt
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.UInt32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.UInt32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 System.UInt32 hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public readonly System.UInt32 hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x18 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x1C System.UInt32 fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
        public readonly System.UInt32 fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x20 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredUInt"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>]=>[System.IComparable<System.UInt32>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x0200001DU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 85, 73, 110, 116])]


// struct 0x10 System.UInt32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 System.UInt32 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x18 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x1C System.UInt32 fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"fakeValue", "FAKE_VALUE")]

// struct 0x20 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredUInt
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredUInt";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 85, 73, 110, 116];

    //public const uint Const_TypeToken = 0x0200001DU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredUInt(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredUInt(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredUInt obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredUInt obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredUInt"]
/// </summary>
public partial class ObscuredUInt
{



    /// <summary>
    ///   System.Void .ctor(System.UInt32 value)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.UInt32 value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.UInt32 GenerateKey()
    /// </summary>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.UInt32 GENERATE_KEY ();


    /// <summary>
    ///   System.UInt32 GetDecrypted()
    /// </summary>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.UInt32 GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input, System.Int32 increment);


    /// <summary>
    ///   System.UInt32 InternalDecrypt()
    /// </summary>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.UInt32 INTERNAL_DECRYPT ();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.UInt32 newKey)
    /// </summary>
    /// <param name="newKey">struct System.UInt32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.UInt32 newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredInt OP_EXPLICIT (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt other);


    /// <summary>
    ///   System.Int32 CompareTo(System.UInt32 other)
    /// </summary>
    /// <param name="other">struct System.UInt32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.Int32 COMPARE_TO_01 (System.UInt32 other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.UInt32 Decrypt(System.UInt32 value, System.UInt32 key)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <param name="key">struct System.UInt32</param>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredUInt))]
    /// static extern System.UInt32 DECRYPT_00 (System.UInt32 value, System.UInt32 key);


    /// <summary>
    /// static  System.Int32 Decrypt(System.UInt32 value)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredUInt))]
    /// static extern System.Int32 DECRYPT_01 (System.UInt32 value);


    /// <summary>
    /// static  System.UInt32 Encrypt(System.UInt32 value, System.UInt32 key)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <param name="key">struct System.UInt32</param>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredUInt))]
    /// static extern System.UInt32 ENCRYPT_00 (System.UInt32 value, System.UInt32 key);


    /// <summary>
    /// static  System.Int32 Encrypt(System.UInt32 value)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredUInt))]
    /// static extern System.Int32 ENCRYPT_01 (System.UInt32 value);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FromEncrypted(System.UInt32 encrypted, System.UInt32 key)
    /// </summary>
    /// <param name="encrypted">struct System.UInt32</param>
    /// <param name="key">struct System.UInt32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredUInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FROM_ENCRYPTED_00 (System.UInt32 encrypted, System.UInt32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FromEncrypted(System.UInt32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.UInt32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredUInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FROM_ENCRYPTED_01 (System.UInt32 encrypted);


    /// <summary>
    ///   System.UInt32 GetEncrypted(System.UInt32& key)
    /// </summary>
    /// <param name="key">struct System.UInt32&</param>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.UInt32 GET_ENCRYPTED_00 (System.UInt32& key);


    /// <summary>
    ///   System.UInt32 GetEncrypted()
    /// </summary>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredUInt))]
    ///  extern System.UInt32 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.UInt32 encrypted, System.UInt32 key)
    /// </summary>
    /// <param name="encrypted">struct System.UInt32</param>
    /// <param name="key">struct System.UInt32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredUInt))]
    ///  extern void SET_ENCRYPTED_00 (System.UInt32 encrypted, System.UInt32 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.UInt32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.UInt32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredUInt))]
    ///  extern void SET_ENCRYPTED_01 (System.UInt32 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredUInt))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredUInt))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredUInt))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredUInt))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Implicit(System.UInt32 value)
    /// </summary>
    /// <param name="value">struct System.UInt32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredUInt))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt OP_IMPLICIT_00 (System.UInt32 value);


    /// <summary>
    /// static  System.UInt32 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt</param>
    /// <returns>struct System.UInt32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredUInt))]
    /// static extern System.UInt32 OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value);


    /// public static partial class Search_ObscuredUInt
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.UInt32 other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.UInt32");
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
    /// static  System.UInt32 Decrypt(System.UInt32 value, System.UInt32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.UInt32", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int32 Decrypt(System.UInt32 value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.UInt32 Encrypt(System.UInt32 value, System.UInt32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.UInt32", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int32 Encrypt(System.UInt32 value)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.UInt32");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FromEncrypted(System.UInt32 encrypted, System.UInt32 key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.UInt32", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt FromEncrypted(System.UInt32 encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.UInt32 GetEncrypted(System.UInt32& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.UInt32&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.UInt32 GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.UInt32 encrypted, System.UInt32 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.UInt32", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.UInt32 encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.UInt32");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Implicit(System.UInt32 value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.UInt32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.UInt32 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt");
    ///     
    ///  
    /// 
    /// 
    /// }

}
