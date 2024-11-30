namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredChar"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>]=>[System.IComparable<System.Char>]=>[System.IComparable]
/// </summary>
public partial class ObscuredChar
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredChar
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Char currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Char currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x12 System.Char hiddenValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x2)]
        public readonly System.Char hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x14 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x16 System.Char fakeValue
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x6)]
        public readonly System.Char fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x18 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredChar"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>]=>[System.IComparable<System.Char>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x0200000FU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 67, 104, 97, 114])]


// struct 0x10 System.Char currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Char),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x12 System.Char hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Char),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x14 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x16 System.Char fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(System.Char),"fakeValue", "FAKE_VALUE")]

// struct 0x18 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredChar
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredChar";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 67, 104, 97, 114];

    //public const uint Const_TypeToken = 0x0200000FU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredChar(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredChar(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredChar obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredChar obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredChar"]
/// </summary>
public partial class ObscuredChar
{



    /// <summary>
    ///   System.Void .ctor(System.Char value)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
    ///  extern void .CTOR (System.Char value);


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Char Decrypt(System.Char value, System.Char key)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <param name="key">struct System.Char</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt")]
    /// static extern System.Char DECRYPT (System.Char value, System.Char key);


    /// <summary>
    /// static  System.Char Encrypt(System.Char value, System.Char key)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <param name="key">struct System.Char</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt")]
    /// static extern System.Char ENCRYPT (System.Char value, System.Char key);


    /// <summary>
    /// static  System.Char GenerateKey()
    /// </summary>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Char GENERATE_KEY ();


    /// <summary>
    ///   System.Char GetDecrypted()
    /// </summary>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern System.Char GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input, System.Int32 increment)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <param name="increment">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input, System.Int32 increment);


    /// <summary>
    ///   System.Char InternalDecrypt()
    /// </summary>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern System.Char INTERNAL_DECRYPT ();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.Char newKey)
    /// </summary>
    /// <param name="newKey">struct System.Char</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (System.Char newKey);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Decrement")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar OP_DECREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input)
    /// </summary>
    /// <param name="input">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Increment")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar OP_INCREMENT (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input);



    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar other)
    /// </summary>
    /// <param name="other">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Int32 COMPARE_TO_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Char other)
    /// </summary>
    /// <param name="other">struct System.Char</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Int32 COMPARE_TO_01 (System.Char other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.Char EncryptDecrypt(System.Char value)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredChar))]
    /// static extern System.Char ENCRYPT_DECRYPT_00 (System.Char value);


    /// <summary>
    /// static  System.Char EncryptDecrypt(System.Char value, System.Char key)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <param name="key">struct System.Char</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredChar))]
    /// static extern System.Char ENCRYPT_DECRYPT_01 (System.Char value, System.Char key);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj)
    /// </summary>
    /// <param name="obj">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Boolean EQUALS_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FromEncrypted(System.Char encrypted, System.Char key)
    /// </summary>
    /// <param name="encrypted">struct System.Char</param>
    /// <param name="key">struct System.Char</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredChar))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FROM_ENCRYPTED_00 (System.Char encrypted, System.Char key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FromEncrypted(System.Char encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Char</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredChar))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FROM_ENCRYPTED_01 (System.Char encrypted);


    /// <summary>
    ///   System.Char GetEncrypted(System.Char& key)
    /// </summary>
    /// <param name="key">struct System.Char&</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Char GET_ENCRYPTED_00 (System.Char& key);


    /// <summary>
    ///   System.Char GetEncrypted()
    /// </summary>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredChar))]
    ///  extern System.Char GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Char encrypted, System.Char key)
    /// </summary>
    /// <param name="encrypted">struct System.Char</param>
    /// <param name="key">struct System.Char</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredChar))]
    ///  extern void SET_ENCRYPTED_00 (System.Char encrypted, System.Char key);


    /// <summary>
    ///   System.Void SetEncrypted(System.Char encrypted)
    /// </summary>
    /// <param name="encrypted">struct System.Char</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredChar))]
    ///  extern void SET_ENCRYPTED_01 (System.Char encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredChar))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// <param name="provider">interface System.IFormatProvider</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredChar))]
    ///  extern nint TO_STRING_01 (nint provider);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Implicit(System.Char value)
    /// </summary>
    /// <param name="value">struct System.Char</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredChar))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredChar OP_IMPLICIT_00 (System.Char value);


    /// <summary>
    /// static  System.Char op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredChar</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredChar))]
    /// static extern System.Char OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value);


    /// public static partial class Search_ObscuredChar
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredChar");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.Char other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.Char");
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
    /// static  System.Char EncryptDecrypt(System.Char value)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Char");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char EncryptDecrypt(System.Char value, System.Char key)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.Char", "System.Char");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredChar");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FromEncrypted(System.Char encrypted, System.Char key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Char", "System.Char");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar FromEncrypted(System.Char encrypted)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Char");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Char GetEncrypted(System.Char& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Char&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Char GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Char encrypted, System.Char key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Char", "System.Char");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Char encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Char");
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
    ///   System.String ToString(System.IFormatProvider provider)
    /// </summary>
    /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "System.IFormatProvider");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Implicit(System.Char value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Char");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredChar");
    ///     
    ///  
    /// 
    /// 
    /// }

}
