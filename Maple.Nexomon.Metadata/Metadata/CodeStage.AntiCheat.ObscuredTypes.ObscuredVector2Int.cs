namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector2Int"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
public partial class ObscuredVector2Int
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredVector2Int
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int hiddenValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        //public readonly CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x1C System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x20 UnityEngine.Vector2Int fakeValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        //public readonly UnityEngine.Vector2Int fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x28 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector2Int"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000022U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 50, 73, 110, 116])]

//  struct static UnityEngine.Vector2Int Zero
//  [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector2Int),"Zero", "ZERO", true)]

// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x1C System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x20 UnityEngine.Vector2Int fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector2Int),"fakeValue", "FAKE_VALUE")]

// struct 0x28 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredVector2Int
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredVector2Int";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 50, 73, 110, 116];

    //public const uint Const_TypeToken = 0x02000022U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredVector2Int(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredVector2Int(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredVector2Int obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredVector2Int obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector2Int"]
/// </summary>
public partial class ObscuredVector2Int
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int FromEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int FROM_ENCRYPTED (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted, System.Int32 key);


    /// <summary>
    /// static  System.Int32 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int32 GENERATE_KEY ();


    /// <summary>
    ///   UnityEngine.Vector2Int GetDecrypted()
    /// </summary>
    /// <returns>struct UnityEngine.Vector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern UnityEngine.Vector2Int GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    ///   UnityEngine.Vector2Int InternalDecrypt()
    /// </summary>
    /// <returns>struct UnityEngine.Vector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern UnityEngine.Vector2Int INTERNAL_DECRYPT ();


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
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
    ///  extern nint TO_STRING ();


    /// <summary>
    ///   System.Int32 get_Item(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
    ///  extern System.Int32 GET_ITEM (System.Int32 index);


    /// <summary>
    ///   System.Int32 get_x()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_x")]
    ///  extern System.Int32 GET_X ();


    /// <summary>
    ///   System.Int32 get_y()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_y")]
    ///  extern System.Int32 GET_Y ();


    /// <summary>
    ///   System.Void set_Item(System.Int32 index, System.Int32 value)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
    ///  extern void SET_ITEM (System.Int32 index, System.Int32 value);


    /// <summary>
    ///   System.Void set_x(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_x")]
    ///  extern void SET_X (System.Int32 value);


    /// <summary>
    ///   System.Void set_y(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_y")]
    ///  extern void SET_Y (System.Int32 value);



    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector2Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector2Int</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern void .CTOR_00 (UnityEngine.Vector2Int value);


    /// <summary>
    ///   System.Void .ctor(System.Int32 x, System.Int32 y)
    /// </summary>
    /// <param name="x">struct System.Int32</param>
    /// <param name="y">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern void .CTOR_01 (System.Int32 x, System.Int32 y);


    /// <summary>
    /// static  UnityEngine.Vector2Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct UnityEngine.Vector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern UnityEngine.Vector2Int DECRYPT_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value, System.Int32 key);


    /// <summary>
    /// static  UnityEngine.Vector2Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</param>
    /// <returns>struct UnityEngine.Vector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern UnityEngine.Vector2Int DECRYPT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(UnityEngine.Vector2Int value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector2Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int ENCRYPT_00 (UnityEngine.Vector2Int value, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(System.Int32 x, System.Int32 y, System.Int32 key)
    /// </summary>
    /// <param name="x">struct System.Int32</param>
    /// <param name="y">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int ENCRYPT_01 (System.Int32 x, System.Int32 y, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(UnityEngine.Vector2Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector2Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int ENCRYPT_02 (UnityEngine.Vector2Int value);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern void SET_ENCRYPTED_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector2Int))]
    ///  extern void SET_ENCRYPTED_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int op_Implicit(UnityEngine.Vector2Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector2Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int OP_IMPLICIT_00 (UnityEngine.Vector2Int value);


    /// <summary>
    /// static  UnityEngine.Vector2Int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int</param>
    /// <returns>struct UnityEngine.Vector2Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern UnityEngine.Vector2Int OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value);


    /// <summary>
    /// static  UnityEngine.Vector2 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int</param>
    /// <returns>struct UnityEngine.Vector2</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector2Int))]
    /// static extern UnityEngine.Vector2 OP_IMPLICIT_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value);


    /// public static partial class Search_ObscuredVector2Int
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector2Int value)
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Vector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.Int32 x, System.Int32 y)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector2Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value, System.Int32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector2Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(UnityEngine.Vector2Int value, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector2Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(System.Int32 x, System.Int32 y, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Int32", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int Encrypt(UnityEngine.Vector2Int value)
    /// </summary>
    /// public static bool ENCRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted(System.Int32& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int32&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted, System.Int32 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int.RawEncryptedVector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int op_Implicit(UnityEngine.Vector2Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "UnityEngine.Vector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector2Int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector2 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int");
    ///     
    ///  
    /// 
    /// 
    /// }

}
