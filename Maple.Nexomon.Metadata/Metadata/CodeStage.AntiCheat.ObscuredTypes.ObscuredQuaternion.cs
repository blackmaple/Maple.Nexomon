namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredQuaternion"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
public partial class ObscuredQuaternion
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredQuaternion
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        //public readonly CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x24 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x28 UnityEngine.Quaternion fakeValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
        //public readonly UnityEngine.Quaternion fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x38 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredQuaternion"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000018U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110])]

//  struct static UnityEngine.Quaternion Identity
//  [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Quaternion),"Identity", "IDENTITY", true)]

// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x24 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x28 UnityEngine.Quaternion fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Quaternion),"fakeValue", "FAKE_VALUE")]

// struct 0x38 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredQuaternion
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredQuaternion";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 81, 117, 97, 116, 101, 114, 110, 105, 111, 110];

    //public const uint Const_TypeToken = 0x02000018U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredQuaternion(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredQuaternion(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredQuaternion obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredQuaternion obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredQuaternion"]
/// </summary>
public partial class ObscuredQuaternion
{



    /// <summary>
    /// static  System.Void .cctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
    /// static extern void .CCTOR ();


    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Boolean CompareQuaternionsWithTolerance(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2)
    /// </summary>
    /// <param name="q1">struct UnityEngine.Quaternion</param>
    /// <param name="q2">struct UnityEngine.Quaternion</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareQuaternionsWithTolerance")]
    /// static extern System.Boolean COMPARE_QUATERNIONS_WITH_TOLERANCE (UnityEngine.Quaternion q1, UnityEngine.Quaternion q2);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion FromEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion FROM_ENCRYPTED (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted, System.Int32 key);


    /// <summary>
    /// static  System.Int32 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int32 GENERATE_KEY ();


    /// <summary>
    ///   UnityEngine.Quaternion GetDecrypted()
    /// </summary>
    /// <returns>struct UnityEngine.Quaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern UnityEngine.Quaternion GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    ///   UnityEngine.Quaternion InternalDecrypt()
    /// </summary>
    /// <returns>struct UnityEngine.Quaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern UnityEngine.Quaternion INTERNAL_DECRYPT ();


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
    ///   System.Void .ctor(UnityEngine.Quaternion value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Quaternion</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern void .CTOR_00 (UnityEngine.Quaternion value);


    /// <summary>
    ///   System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
    /// </summary>
    /// <param name="x">struct System.Single</param>
    /// <param name="y">struct System.Single</param>
    /// <param name="z">struct System.Single</param>
    /// <param name="w">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern void .CTOR_01 (System.Single x, System.Single y, System.Single z, System.Single w);


    /// <summary>
    /// static  UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct UnityEngine.Quaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern UnityEngine.Quaternion DECRYPT_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, System.Int32 key);


    /// <summary>
    /// static  UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</param>
    /// <returns>struct UnityEngine.Quaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern UnityEngine.Quaternion DECRYPT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct UnityEngine.Quaternion</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion ENCRYPT_00 (UnityEngine.Quaternion value, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(System.Single x, System.Single y, System.Single z, System.Single w, System.Int32 key)
    /// </summary>
    /// <param name="x">struct System.Single</param>
    /// <param name="y">struct System.Single</param>
    /// <param name="z">struct System.Single</param>
    /// <param name="w">struct System.Single</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion ENCRYPT_01 (System.Single x, System.Single y, System.Single z, System.Single w, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Quaternion</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion ENCRYPT_02 (UnityEngine.Quaternion value);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern void SET_ENCRYPTED_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern void SET_ENCRYPTED_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredQuaternion))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion op_Implicit(UnityEngine.Quaternion value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Quaternion</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion OP_IMPLICIT_00 (UnityEngine.Quaternion value);


    /// <summary>
    /// static  UnityEngine.Quaternion op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion</param>
    /// <returns>struct UnityEngine.Quaternion</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredQuaternion))]
    /// static extern UnityEngine.Quaternion OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value);


    /// public static partial class Search_ObscuredQuaternion
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor(UnityEngine.Quaternion value)
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Quaternion");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Single", "System.Single", "System.Single", "System.Single");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, System.Int32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Quaternion", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(System.Single x, System.Single y, System.Single z, System.Single w, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Single", "System.Single", "System.Single", "System.Single", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value)
    /// </summary>
    /// public static bool ENCRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Quaternion");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted(System.Int32& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int32&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted, System.Int32 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion op_Implicit(UnityEngine.Quaternion value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "UnityEngine.Quaternion");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Quaternion op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion");
    ///     
    ///  
    /// 
    /// 
    /// }

}
