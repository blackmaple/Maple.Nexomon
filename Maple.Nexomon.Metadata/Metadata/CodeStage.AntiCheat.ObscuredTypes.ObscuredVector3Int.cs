namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3Int"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
public partial class ObscuredVector3Int
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredVector3Int
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int hiddenValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        //public readonly CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x20 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x24 UnityEngine.Vector3Int fakeValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
        //public readonly UnityEngine.Vector3Int fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x30 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3Int"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000026U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 51, 73, 110, 116])]

//  struct static UnityEngine.Vector3Int Zero
//  [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector3Int),"Zero", "ZERO", true)]

// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x20 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x24 UnityEngine.Vector3Int fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector3Int),"fakeValue", "FAKE_VALUE")]

// struct 0x30 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredVector3Int
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredVector3Int";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 51, 73, 110, 116];

    //public const uint Const_TypeToken = 0x02000026U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredVector3Int(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredVector3Int(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredVector3Int obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredVector3Int obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3Int"]
/// </summary>
public partial class ObscuredVector3Int
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
    ///   System.Boolean Equals(System.Object other)
    /// </summary>
    /// <param name="other">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
    ///  extern System.Boolean EQUALS (nint other);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int FromEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int FROM_ENCRYPTED (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted, System.Int32 key);


    /// <summary>
    /// static  System.Int32 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int32 GENERATE_KEY ();


    /// <summary>
    ///   UnityEngine.Vector3Int GetDecrypted()
    /// </summary>
    /// <returns>struct UnityEngine.Vector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern UnityEngine.Vector3Int GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    ///   UnityEngine.Vector3Int InternalDecrypt()
    /// </summary>
    /// <returns>struct UnityEngine.Vector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern UnityEngine.Vector3Int INTERNAL_DECRYPT ();


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
    ///   System.Int32 get_z()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_z")]
    ///  extern System.Int32 GET_Z ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, System.Int32 d)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="d">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Multiply")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_MULTIPLY (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, System.Int32 d);


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
    ///   System.Void set_z(System.Int32 value)
    /// </summary>
    /// <param name="value">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_z")]
    ///  extern void SET_Z (System.Int32 value);



    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector3Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3Int</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern void .CTOR_00 (UnityEngine.Vector3Int value);


    /// <summary>
    ///   System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z)
    /// </summary>
    /// <param name="x">struct System.Int32</param>
    /// <param name="y">struct System.Int32</param>
    /// <param name="z">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern void .CTOR_01 (System.Int32 x, System.Int32 y, System.Int32 z);


    /// <summary>
    /// static  UnityEngine.Vector3Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct UnityEngine.Vector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern UnityEngine.Vector3Int DECRYPT_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value, System.Int32 key);


    /// <summary>
    /// static  UnityEngine.Vector3Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</param>
    /// <returns>struct UnityEngine.Vector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern UnityEngine.Vector3Int DECRYPT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(UnityEngine.Vector3Int value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int ENCRYPT_00 (UnityEngine.Vector3Int value, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 key)
    /// </summary>
    /// <param name="x">struct System.Int32</param>
    /// <param name="y">struct System.Int32</param>
    /// <param name="z">struct System.Int32</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int ENCRYPT_01 (System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(UnityEngine.Vector3Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int ENCRYPT_02 (UnityEngine.Vector3Int value);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern void SET_ENCRYPTED_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern void SET_ENCRYPTED_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredVector3Int))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_ADDITION_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// <param name="a">struct UnityEngine.Vector3Int</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_ADDITION_01 (UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="b">struct UnityEngine.Vector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_ADDITION_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b);


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_EQUALITY_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs);


    /// <summary>
    /// static  System.Boolean op_Equality(UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct UnityEngine.Vector3Int</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_EQUALITY_01 (UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs);


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="rhs">struct UnityEngine.Vector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_EQUALITY_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Implicit(UnityEngine.Vector3Int value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_IMPLICIT_00 (UnityEngine.Vector3Int value);


    /// <summary>
    /// static  UnityEngine.Vector3Int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct UnityEngine.Vector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern UnityEngine.Vector3Int OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value);


    /// <summary>
    /// static  UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern UnityEngine.Vector3 OP_IMPLICIT_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value);


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_INEQUALITY_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs);


    /// <summary>
    /// static  System.Boolean op_Inequality(UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct UnityEngine.Vector3Int</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_INEQUALITY_01 (UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs);


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="rhs">struct UnityEngine.Vector3Int</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern System.Boolean OP_INEQUALITY_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_SUBTRACTION_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// <param name="a">struct UnityEngine.Vector3Int</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_SUBTRACTION_01 (UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</param>
    /// <param name="b">struct UnityEngine.Vector3Int</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3Int))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int OP_SUBTRACTION_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b);


    /// public static partial class Search_ObscuredVector3Int
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector3Int value)
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value, System.Int32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3Int Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(UnityEngine.Vector3Int value, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector3Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Int32", "System.Int32", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int Encrypt(UnityEngine.Vector3Int value)
    /// </summary>
    /// public static bool ENCRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted(System.Int32& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int32&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted, System.Int32 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int.RawEncryptedVector3Int");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// public static bool OP_ADDITION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// public static bool OP_ADDITION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "UnityEngine.Vector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b)
    /// </summary>
    /// public static bool OP_ADDITION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "UnityEngine.Vector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Implicit(UnityEngine.Vector3Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3Int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int value)
    /// </summary>
    /// public static bool OP_IMPLICIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(UnityEngine.Vector3Int lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "UnityEngine.Vector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int lhs, UnityEngine.Vector3Int rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(UnityEngine.Vector3Int a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "UnityEngine.Vector3Int", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int a, UnityEngine.Vector3Int b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int", "UnityEngine.Vector3Int");
    ///     
    ///  
    /// 
    /// 
    /// }

}
