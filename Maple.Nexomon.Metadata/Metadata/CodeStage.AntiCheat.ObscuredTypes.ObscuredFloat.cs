namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredFloat"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>]=>[System.IComparable<System.Single>]=>[System.IComparable]
/// </summary>
public partial class ObscuredFloat
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredFloat
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
        public readonly System.Int32 hiddenValue;


        /// const string Name_Field_hiddenValueOldByte4 = "hiddenValueOldByte4";
        /// <summary>
        /// struct 0x18 ACTkByte4 hiddenValueOldByte4
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly ACTkByte4 hiddenValueOldByte4;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x1C System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x20 System.Single fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly System.Single fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x24 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredFloat"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>]=>[System.IComparable<System.Single>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000014U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 70, 108, 111, 97, 116])]


// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 System.Int32 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x18 ACTkByte4 hiddenValueOldByte4
// [MonoCollectorSearchFieldAttribute(typeof(ACTkByte4),"hiddenValueOldByte4", "HIDDEN_VALUE_OLD_BYTE4")]

// struct 0x1C System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x20 System.Single fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"fakeValue", "FAKE_VALUE")]

// struct 0x24 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredFloat
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredFloat";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 70, 108, 111, 97, 116];

    //public const uint Const_TypeToken = 0x02000014U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredFloat(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredFloat(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredFloat obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredFloat obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredFloat"]
/// </summary>
public partial class ObscuredFloat
{



    /// <summary>
    ///   System.Void .ctor(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Single value);


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
    ///   System.Single GetDecrypted()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Single GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input, System.Int32 increment);


    /// <summary>
    ///   System.Single InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Single INTERNAL_DECRYPT ();


    /// <summary>
    /// static  System.Int32 MigrateEncrypted(System.Int32 encrypted, System.Byte fromVersion, System.Byte toVersion)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <param name="fromVersion">struct System.Byte</param>
    /// <param name="toVersion">struct System.Byte</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MigrateEncrypted")]
    /// static extern System.Int32 MIGRATE_ENCRYPTED (System.Int32 encrypted, System.Byte fromVersion, System.Byte toVersion);


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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Single other)
    /// </summary>
    /// <param name="other">struct System.Single</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Single other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Single Decrypt(System.Int32 value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredFloat))]
    /// static extern System.Single DECRYPT_00 (System.Int32 value, System.Int32 key);


    /// <summary>
    /// static  System.Single Decrypt(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredFloat))]
    /// static extern System.Single DECRYPT_01 (System.Int32 value);


    /// <summary>
    /// static  System.Int32 Encrypt(System.Single value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredFloat))]
    /// static extern System.Int32 ENCRYPT_00 (System.Single value, System.Int32 key);


    /// <summary>
    /// static  System.Int32 Encrypt(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredFloat))]
    /// static extern System.Int32 ENCRYPT_01 (System.Single value);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FromEncrypted(System.Int32 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredFloat))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FROM_ENCRYPTED_00 (System.Int32 encrypted, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FromEncrypted(System.Int32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredFloat))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FROM_ENCRYPTED_01 (System.Int32 encrypted);


    /// <summary>
    ///   System.Int32 GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Int32 GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   System.Int32 GetEncrypted()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredFloat))]
    ///  extern System.Int32 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Int32 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredFloat))]
    ///  extern void SET_ENCRYPTED_00 (System.Int32 encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Int32 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredFloat))]
    ///  extern void SET_ENCRYPTED_01 (System.Int32 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredFloat))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredFloat))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredFloat))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredFloat))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredFloat))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat OP_IMPLICIT_00 (System.Single value);


    /// <summary>
    /// static  System.Single op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredFloat))]
    /// static extern System.Single OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);


    /// public static partial class Search_ObscuredFloat
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Single other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Single");
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
    /// static  System.Single Decrypt(System.Int32 value, System.Int32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Single Decrypt(System.Int32 value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int32 Encrypt(System.Single value, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Single", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int32 Encrypt(System.Single value)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Single");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FromEncrypted(System.Int32 encrypted, System.Int32 key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat FromEncrypted(System.Int32 encrypted)
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(System.Single value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Single");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Single op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat");
    ///     
    ///  
    /// 
    /// 
    /// }

}
