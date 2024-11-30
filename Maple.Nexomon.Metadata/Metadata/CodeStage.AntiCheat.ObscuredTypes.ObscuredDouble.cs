namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDouble"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>]=>[System.IComparable<System.Double>]=>[System.IComparable]
/// </summary>
public partial class ObscuredDouble
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredDouble
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int64 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int64 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x18 System.Int64 hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly System.Int64 hiddenValue;


        /// const string Name_Field_hiddenValueOldByte8 = "hiddenValueOldByte8";
        /// <summary>
        /// struct 0x20 ACTkByte8 hiddenValueOldByte8
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly ACTkByte8 hiddenValueOldByte8;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x28 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x30 System.Double fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
        public readonly System.Double fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x38 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDouble"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IFormattable]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>]=>[System.IComparable<System.Double>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000012U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 68, 111, 117, 98, 108, 101])]


// struct 0x10 System.Int64 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int64),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x18 System.Int64 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Int64),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x20 ACTkByte8 hiddenValueOldByte8
// [MonoCollectorSearchFieldAttribute(typeof(ACTkByte8),"hiddenValueOldByte8", "HIDDEN_VALUE_OLD_BYTE8")]

// struct 0x28 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x30 System.Double fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Double),"fakeValue", "FAKE_VALUE")]

// struct 0x38 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredDouble
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredDouble";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 68, 111, 117, 98, 108, 101];

    //public const uint Const_TypeToken = 0x02000012U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredDouble(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredDouble(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredDouble obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredDouble obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredDouble"]
/// </summary>
public partial class ObscuredDouble
{



    /// <summary>
    ///   System.Void .ctor(System.Double value)
    /// </summary>
    /// <param name="value">struct System.Double</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Double value);


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
    ///   System.Double GetDecrypted()
    /// </summary>
    /// <returns>struct System.Double</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Double GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input, System.Double increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <param name="increment">struct System.Double</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input, System.Double increment);


    /// <summary>
    ///   System.Double InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Double</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Double INTERNAL_DECRYPT ();


    /// <summary>
    /// static  System.Int64 MigrateEncrypted(System.Int64 encrypted, System.Byte fromVersion, System.Byte toVersion)
    /// </summary>
    /// <param name="encrypted">struct System.Int64</param>
    /// <param name="fromVersion">struct System.Byte</param>
    /// <param name="toVersion">struct System.Byte</param>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MigrateEncrypted")]
    /// static extern System.Int64 MIGRATE_ENCRYPTED (System.Int64 encrypted, System.Byte fromVersion, System.Byte toVersion);


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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f)
    /// </summary>
    /// <param name="f">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Explicit")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble OP_EXPLICIT (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Double other)
    /// </summary>
    /// <param name="other">struct System.Double</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Double other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Double Decrypt(System.Int64 value, System.Int64 key)
    /// </summary>
    /// <param name="value">struct System.Int64</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Double</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredDouble))]
    /// static extern System.Double DECRYPT_00 (System.Int64 value, System.Int64 key);


    /// <summary>
    /// static  System.Double Decrypt(System.Int64 value)
    /// </summary>
    /// <param name="value">struct System.Int64</param>
    /// <returns>struct System.Double</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredDouble))]
    /// static extern System.Double DECRYPT_01 (System.Int64 value);


    /// <summary>
    /// static  System.Int64 Encrypt(System.Double value, System.Int64 key)
    /// </summary>
    /// <param name="value">struct System.Double</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredDouble))]
    /// static extern System.Int64 ENCRYPT_00 (System.Double value, System.Int64 key);


    /// <summary>
    /// static  System.Int64 Encrypt(System.Double value)
    /// </summary>
    /// <param name="value">struct System.Double</param>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredDouble))]
    /// static extern System.Int64 ENCRYPT_01 (System.Double value);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FromEncrypted(System.Int64 encrypted, System.Int64 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int64</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredDouble))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FROM_ENCRYPTED_00 (System.Int64 encrypted, System.Int64 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FromEncrypted(System.Int64 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int64</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredDouble))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FROM_ENCRYPTED_01 (System.Int64 encrypted);


    /// <summary>
    ///   System.Int64 GetEncrypted(System.Int64& key)
    /// </summary>
    /// <param name="key">struct System.Int64&</param>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Int64 GET_ENCRYPTED_00 (System.Int64& key);


    /// <summary>
    ///   System.Int64 GetEncrypted()
    /// </summary>
    /// <returns>struct System.Int64</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredDouble))]
    ///  extern System.Int64 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Int64 encrypted, System.Int64 key)
    /// </summary>
    /// <param name="encrypted">struct System.Int64</param>
    /// <param name="key">struct System.Int64</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredDouble))]
    ///  extern void SET_ENCRYPTED_00 (System.Int64 encrypted, System.Int64 key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Int64 encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Int64</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredDouble))]
    ///  extern void SET_ENCRYPTED_01 (System.Int64 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDouble))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDouble))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDouble))]
    ///  extern nint TO_STRING_02 (nint provider);


    /// <summary>
    ///   System.String ToString(System.String format, System.IFormatProvider provider)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredDouble))]
    ///  extern nint TO_STRING_03 (nint format, nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(System.Double value)
    /// </summary>
    /// <param name="value">struct System.Double</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredDouble))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble OP_IMPLICIT_00 (System.Double value);


    /// <summary>
    /// static  System.Double op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble</param>
    /// <returns>struct System.Double</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredDouble))]
    /// static extern System.Double OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);


    /// public static partial class Search_ObscuredDouble
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Double other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Double");
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
    /// static  System.Double Decrypt(System.Int64 value, System.Int64 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int64", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Double Decrypt(System.Int64 value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int64 Encrypt(System.Double value, System.Int64 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Double", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Int64 Encrypt(System.Double value)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Double");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FromEncrypted(System.Int64 encrypted, System.Int64 key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int64", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble FromEncrypted(System.Int64 encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int64 GetEncrypted(System.Int64& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int64&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int64 GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Int64 encrypted, System.Int64 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int64", "System.Int64");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Int64 encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Int64");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(System.Double value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Double");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Double op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble");
    ///     
    ///  
    /// 
    /// 
    /// }

}
