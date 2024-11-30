namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredShort"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>]=>[System.IComparable<System.Int16>]=>[System.IComparable]
/// </summary>
public partial class ObscuredShort
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredShort
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int16 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int16 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x12 System.Int16 hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x2)]
        public readonly System.Int16 hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x14 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x16 System.Int16 fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x6)]
        public readonly System.Int16 fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x18 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredShort"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>]=>[System.IComparable<System.Int16>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x0200001BU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 83, 104, 111, 114, 116])]


// struct 0x10 System.Int16 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x12 System.Int16 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x14 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x16 System.Int16 fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int16),"fakeValue", "FAKE_VALUE")]

// struct 0x18 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredShort
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredShort";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 83, 104, 111, 114, 116];

    //public const uint Const_TypeToken = 0x0200001BU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredShort(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredShort(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredShort obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredShort obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredShort"]
/// </summary>
public partial class ObscuredShort
{



    /// <summary>
    ///   System.Void .ctor(System.Int16 value)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Int16 value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Int16 Decrypt(System.Int16 value, System.Int16 key)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <param name="key">struct System.Int16</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt")]
    /// static extern System.Int16 DECRYPT (System.Int16 value, System.Int16 key);


    /// <summary>
    /// static  System.Int16 Encrypt(System.Int16 value, System.Int16 key)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <param name="key">struct System.Int16</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt")]
    /// static extern System.Int16 ENCRYPT (System.Int16 value, System.Int16 key);


    /// <summary>
    /// static  System.Int16 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int16 GENERATE_KEY ();


    /// <summary>
    ///   System.Int16 GetDecrypted()
    /// </summary>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Int16 GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input, System.Int32 increment);


    /// <summary>
    ///   System.Int16 InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Int16 INTERNAL_DECRYPT ();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.Int16 newKey)
    /// </summary>
    /// <param name="newKey">struct System.Int16</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.Int16 newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Int16 other)
    /// </summary>
    /// <param name="other">struct System.Int16</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Int16 other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Int16 EncryptDecrypt(System.Int16 value)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredShort))]
    /// static extern System.Int16 ENCRYPT_DECRYPT_00 (System.Int16 value);


    /// <summary>
    /// static  System.Int16 EncryptDecrypt(System.Int16 value, System.Int16 key)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <param name="key">struct System.Int16</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredShort))]
    /// static extern System.Int16 ENCRYPT_DECRYPT_01 (System.Int16 value, System.Int16 key);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FromEncrypted(System.Int16 encrypted, System.Int16 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int16</param>
    /// <param name="key">struct System.Int16</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredShort))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FROM_ENCRYPTED_00 (System.Int16 encrypted, System.Int16 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FromEncrypted(System.Int16 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int16</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredShort))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FROM_ENCRYPTED_01 (System.Int16 encrypted);


    /// <summary>
    ///   System.Int16 GetEncrypted(System.Int16& key)
    /// </summary>
    /// <param name="key">struct System.Int16&</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Int16 GET_ENCRYPTED_00 (System.Int16& key);


    /// <summary>
    ///   System.Int16 GetEncrypted()
    /// </summary>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredShort))]
    ///  extern System.Int16 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Int16 encrypted, System.Int16 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int16</param>
    /// <param name="key">struct System.Int16</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredShort))]
    ///  extern void SET_ENCRYPTED_00 (System.Int16 encrypted, System.Int16 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Int16 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int16</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredShort))]
    ///  extern void SET_ENCRYPTED_01 (System.Int16 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredShort))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredShort))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredShort))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredShort))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Implicit(System.Int16 value)
    /// </summary>
    /// <param name="value">struct System.Int16</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredShort))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredShort OP_IMPLICIT_00 (System.Int16 value);


    /// <summary>
    /// static  System.Int16 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredShort</param>
    /// <returns>struct System.Int16</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredShort))]
    /// static extern System.Int16 OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value);


    /// public static partial class Search_ObscuredShort
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredShort");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Int16 other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Int16");
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
    /// static  System.Int16 EncryptDecrypt(System.Int16 value)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Int16");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int16 EncryptDecrypt(System.Int16 value, System.Int16 key)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Int16", "System.Int16");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredShort");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FromEncrypted(System.Int16 encrypted, System.Int16 key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int16", "System.Int16");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort FromEncrypted(System.Int16 encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int16");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int16 GetEncrypted(System.Int16& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int16&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int16 GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Int16 encrypted, System.Int16 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int16", "System.Int16");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Int16 encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int16");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Implicit(System.Int16 value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Int16");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int16 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredShort");
    ///     
    ///  
    /// 
    /// 
    /// }

}
