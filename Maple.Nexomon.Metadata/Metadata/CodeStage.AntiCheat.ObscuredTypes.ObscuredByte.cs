namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredByte"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>]=>[System.IComparable<System.Byte>]=>[System.IComparable]
/// </summary>
public partial class ObscuredByte
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredByte
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Byte currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Byte currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x11 System.Byte hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x1)]
        public readonly System.Byte hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x12 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x2)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x13 System.Byte fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x3)]
        public readonly System.Byte fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x14 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredByte"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>]=>[System.IComparable<System.Byte>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x0200000EU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 66, 121, 116, 101])]


// struct 0x10 System.Byte currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Byte),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x11 System.Byte hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Byte),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x12 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x13 System.Byte fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Byte),"fakeValue", "FAKE_VALUE")]

// struct 0x14 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredByte
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredByte";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 66, 121, 116, 101];

    //public const uint Const_TypeToken = 0x0200000EU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredByte(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredByte(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredByte obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredByte obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredByte"]
/// </summary>
public partial class ObscuredByte
{



    /// <summary>
    ///   System.Void .ctor(System.Byte value)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Byte value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Byte GenerateKey()
    /// </summary>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Byte GENERATE_KEY ();


    /// <summary>
    ///   System.Byte GetDecrypted()
    /// </summary>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Byte GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input, System.Int32 increment);


    /// <summary>
    ///   System.Byte InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Byte INTERNAL_DECRYPT ();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.Byte newKey)
    /// </summary>
    /// <param name="newKey">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.Byte newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Byte other)
    /// </summary>
    /// <param name="other">struct System.Byte</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Byte other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Byte Decrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte DECRYPT_00 (System.Byte value, System.Byte key);


    /// <summary>
    /// static  System.Void Decrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// <param name="value">class System.Byte[]</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern void DECRYPT_01 (nint value, System.Byte key);


    /// <summary>
    /// static  System.Byte Encrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte ENCRYPT_00 (System.Byte value, System.Byte key);


    /// <summary>
    /// static  System.Void Encrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// <param name="value">class System.Byte[]</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern void ENCRYPT_01 (nint value, System.Byte key);


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte value)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte ENCRYPT_DECRYPT_00 (System.Byte value);


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte[] value)
    /// </summary>
    /// <param name="value">class System.Byte[]</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte ENCRYPT_DECRYPT_01 (nint value);


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte ENCRYPT_DECRYPT_02 (System.Byte value, System.Byte key);


    /// <summary>
    /// static  System.Void EncryptDecrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// <param name="value">class System.Byte[]</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredByte))]
    /// static extern void ENCRYPT_DECRYPT_03 (nint value, System.Byte key);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FromEncrypted(System.Byte encrypted, System.Byte key)
    /// </summary>
    /// <param name="encrypted">struct System.Byte</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredByte))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FROM_ENCRYPTED_00 (System.Byte encrypted, System.Byte key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FromEncrypted(System.Byte encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Byte</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredByte))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FROM_ENCRYPTED_01 (System.Byte encrypted);


    /// <summary>
    ///   System.Byte GetEncrypted(System.Byte& key)
    /// </summary>
    /// <param name="key">struct System.Byte&</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Byte GET_ENCRYPTED_00 (System.Byte& key);


    /// <summary>
    ///   System.Byte GetEncrypted()
    /// </summary>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredByte))]
    ///  extern System.Byte GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Byte encrypted, System.Byte key)
    /// </summary>
    /// <param name="encrypted">struct System.Byte</param>
    /// <param name="key">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredByte))]
    ///  extern void SET_ENCRYPTED_00 (System.Byte encrypted, System.Byte key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Byte encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Byte</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredByte))]
    ///  extern void SET_ENCRYPTED_01 (System.Byte encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredByte))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredByte))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredByte))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredByte))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Implicit(System.Byte value)
    /// </summary>
    /// <param name="value">struct System.Byte</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredByte))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredByte OP_IMPLICIT_00 (System.Byte value);


    /// <summary>
    /// static  System.Byte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredByte</param>
    /// <returns>struct System.Byte</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredByte))]
    /// static extern System.Byte OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value);


    /// public static partial class Search_ObscuredByte
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredByte");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Byte other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Byte");
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
    /// static  System.Byte Decrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Byte", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Void Decrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Byte[]", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Byte Encrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Byte", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Void Encrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Byte[]", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte value)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte[] value)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Byte[]");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Byte EncryptDecrypt(System.Byte value, System.Byte key)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Byte", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Void EncryptDecrypt(System.Byte[] value, System.Byte key)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Byte[]", "System.Byte");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredByte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FromEncrypted(System.Byte encrypted, System.Byte key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Byte", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte FromEncrypted(System.Byte encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Byte GetEncrypted(System.Byte& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Byte&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Byte GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Byte encrypted, System.Byte key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Byte", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Byte encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Byte");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Implicit(System.Byte value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Byte");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Byte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredByte");
    ///     
    ///  
    /// 
    /// 
    /// }

}
