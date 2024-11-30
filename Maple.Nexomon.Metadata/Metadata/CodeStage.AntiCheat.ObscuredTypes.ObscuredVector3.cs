namespace Maple.Nexomon.Metadata;

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3"]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
public partial class ObscuredVector3
{






    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_ObscuredVector3
    {



        /// const string Name_Field_currentCryptoKey = "currentCryptoKey";
        /// <summary>
        /// struct 0x10 System.Int32 currentCryptoKey
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
        public readonly System.Int32 currentCryptoKey;


        /// const string Name_Field_hiddenValue = "hiddenValue";
        /// <summary>
        /// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
        //public readonly CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue;


        /// const string Name_Field_inited = "inited";
        /// <summary>
        /// struct 0x20 System.Boolean inited
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
        public readonly System.Boolean inited;


        /// const string Name_Field_fakeValue = "fakeValue";
        /// <summary>
        /// struct 0x24 UnityEngine.Vector3 fakeValue
        /// </summary>
        //[System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
        //public readonly UnityEngine.Vector3 fakeValue;


        /// const string Name_Field_fakeValueActive = "fakeValueActive";
        /// <summary>
        /// struct 0x30 System.Boolean fakeValueActive
        /// </summary>
        [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
        public readonly System.Boolean fakeValueActive;

    }

}

/// <summary>
/// struct ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3"]
/// 
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x02000024U)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 51])]

//  struct static UnityEngine.Vector3 Zero
//  [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector3),"Zero", "ZERO", true)]

// struct 0x10 System.Int32 currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// struct 0x14 CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3),"hiddenValue", "HIDDEN_VALUE")]

// struct 0x20 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// struct 0x24 UnityEngine.Vector3 fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Vector3),"fakeValue", "FAKE_VALUE")]

// struct 0x30 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredVector3
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredVector3";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 86, 101, 99, 116, 111, 114, 51];

    //public const uint Const_TypeToken = 0x02000024U;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredVector3(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredVector3(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredVector3 obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredVector3 obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredVector3"]
/// </summary>
public partial class ObscuredVector3
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
    /// static  System.Boolean CompareVectorsWithTolerance(UnityEngine.Vector3 vector1, UnityEngine.Vector3 vector2)
    /// </summary>
    /// <param name="vector1">struct UnityEngine.Vector3</param>
    /// <param name="vector2">struct UnityEngine.Vector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareVectorsWithTolerance")]
    /// static extern System.Boolean COMPARE_VECTORS_WITH_TOLERANCE (UnityEngine.Vector3 vector1, UnityEngine.Vector3 vector2);


    /// <summary>
    ///   System.Boolean Equals(System.Object other)
    /// </summary>
    /// <param name="other">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
    ///  extern System.Boolean EQUALS (nint other);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 FromEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 FROM_ENCRYPTED (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted, System.Int32 key);


    /// <summary>
    /// static  System.Int32 GenerateKey()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey")]
    /// static extern System.Int32 GENERATE_KEY ();


    /// <summary>
    ///   UnityEngine.Vector3 GetDecrypted()
    /// </summary>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    ///  extern UnityEngine.Vector3 GET_DECRYPTED ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    ///   UnityEngine.Vector3 InternalDecrypt()
    /// </summary>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern UnityEngine.Vector3 INTERNAL_DECRYPT ();


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
    ///   System.Single get_Item(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
    ///  extern System.Single GET_ITEM (System.Int32 index);


    /// <summary>
    ///   System.Single get_x()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_x")]
    ///  extern System.Single GET_X ();


    /// <summary>
    ///   System.Single get_y()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_y")]
    ///  extern System.Single GET_Y ();


    /// <summary>
    ///   System.Single get_z()
    /// </summary>
    /// <returns>struct System.Single</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_z")]
    ///  extern System.Single GET_Z ();


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Division(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, System.Single d)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="d">struct System.Single</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Division")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_DIVISION (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, System.Single d);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_UnaryNegation(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_UnaryNegation")]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_UNARY_NEGATION (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a);


    /// <summary>
    ///   System.Void set_Item(System.Int32 index, System.Single value)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
    ///  extern void SET_ITEM (System.Int32 index, System.Single value);


    /// <summary>
    ///   System.Void set_x(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_x")]
    ///  extern void SET_X (System.Single value);


    /// <summary>
    ///   System.Void set_y(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_y")]
    ///  extern void SET_Y (System.Single value);


    /// <summary>
    ///   System.Void set_z(System.Single value)
    /// </summary>
    /// <param name="value">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_z")]
    ///  extern void SET_Z (System.Single value);



    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector3 value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector3))]
    ///  extern void .CTOR_00 (UnityEngine.Vector3 value);


    /// <summary>
    ///   System.Void .ctor(System.Single x, System.Single y, System.Single z)
    /// </summary>
    /// <param name="x">struct System.Single</param>
    /// <param name="y">struct System.Single</param>
    /// <param name="z">struct System.Single</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredVector3))]
    ///  extern void .CTOR_01 (System.Single x, System.Single y, System.Single z);


    /// <summary>
    /// static  UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector3))]
    /// static extern UnityEngine.Vector3 DECRYPT_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, System.Int32 key);


    /// <summary>
    /// static  UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</param>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredVector3))]
    /// static extern UnityEngine.Vector3 DECRYPT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value, System.Int32 key)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 ENCRYPT_00 (UnityEngine.Vector3 value, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(System.Single x, System.Single y, System.Single z, System.Int32 key)
    /// </summary>
    /// <param name="x">struct System.Single</param>
    /// <param name="y">struct System.Single</param>
    /// <param name="z">struct System.Single</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 ENCRYPT_01 (System.Single x, System.Single y, System.Single z, System.Int32 key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 ENCRYPT_02 (UnityEngine.Vector3 value);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted(System.Int32& key)
    /// </summary>
    /// <param name="key">struct System.Int32&</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector3))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GET_ENCRYPTED_00 (System.Int32& key);


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted()
    /// </summary>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredVector3))]
    ///  extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted, System.Int32 key)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</param>
    /// <param name="key">struct System.Int32</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector3))]
    ///  extern void SET_ENCRYPTED_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted, System.Int32 key);


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted)
    /// </summary>
    /// <param name="encrypted">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredVector3))]
    ///  extern void SET_ENCRYPTED_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredVector3))]
    ///  extern nint TO_STRING_00 ();


    /// <summary>
    ///   System.String ToString(System.String format)
    /// </summary>
    /// <param name="format">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_ObscuredVector3))]
    ///  extern nint TO_STRING_01 (nint format);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_ADDITION_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// <param name="a">struct UnityEngine.Vector3</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_ADDITION_01 (UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="b">struct UnityEngine.Vector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Addition", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_ADDITION_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b);


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_EQUALITY_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);


    /// <summary>
    /// static  System.Boolean op_Equality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// <param name="lhs">struct UnityEngine.Vector3</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_EQUALITY_01 (UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="rhs">struct UnityEngine.Vector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_EQUALITY_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Implicit(UnityEngine.Vector3 value)
    /// </summary>
    /// <param name="value">struct UnityEngine.Vector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_IMPLICIT_00 (UnityEngine.Vector3 value);


    /// <summary>
    /// static  UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value)
    /// </summary>
    /// <param name="value">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct UnityEngine.Vector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredVector3))]
    /// static extern UnityEngine.Vector3 OP_IMPLICIT_01 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value);


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_INEQUALITY_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);


    /// <summary>
    /// static  System.Boolean op_Inequality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// <param name="lhs">struct UnityEngine.Vector3</param>
    /// <param name="rhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_INEQUALITY_01 (UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
    /// </summary>
    /// <param name="lhs">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="rhs">struct UnityEngine.Vector3</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality", Search = typeof(Search_ObscuredVector3))]
    /// static extern System.Boolean OP_INEQUALITY_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, System.Single d)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="d">struct System.Single</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Multiply", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_MULTIPLY_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, System.Single d);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(System.Single d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
    /// </summary>
    /// <param name="d">struct System.Single</param>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Multiply", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_MULTIPLY_01 (System.Single d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_SUBTRACTION_00 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// <param name="a">struct UnityEngine.Vector3</param>
    /// <param name="b">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_SUBTRACTION_01 (UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
    /// </summary>
    /// <param name="a">struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</param>
    /// <param name="b">struct UnityEngine.Vector3</param>
    /// <returns>struct CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Subtraction", Search = typeof(Search_ObscuredVector3))]
    /// static extern CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 OP_SUBTRACTION_02 (CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b);


    /// public static partial class Search_ObscuredVector3
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor(UnityEngine.Vector3 value)
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.Single x, System.Single y, System.Single z)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Single", "System.Single", "System.Single");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, System.Int32 key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector3", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(System.Single x, System.Single y, System.Single z, System.Int32 key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Single", "System.Single", "System.Single", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value)
    /// </summary>
    /// public static bool ENCRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted(System.Int32& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Int32&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted, System.Int32 key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3");
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
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// public static bool OP_ADDITION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// public static bool OP_ADDITION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "UnityEngine.Vector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
    /// </summary>
    /// public static bool OP_ADDITION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Addition", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "UnityEngine.Vector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
    /// </summary>
    /// public static bool OP_EQUALITY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Equality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Implicit(UnityEngine.Vector3 value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "UnityEngine.Vector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs)
    /// </summary>
    /// public static bool OP_INEQUALITY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Inequality", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "UnityEngine.Vector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, System.Single d)
    /// </summary>
    /// public static bool OP_MULTIPLY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Multiply", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "System.Single");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(System.Single d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a)
    /// </summary>
    /// public static bool OP_MULTIPLY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Multiply", "System.Single", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "UnityEngine.Vector3", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b)
    /// </summary>
    /// public static bool OP_SUBTRACTION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Subtraction", "CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3", "UnityEngine.Vector3");
    ///     
    ///  
    /// 
    /// 
    /// }

}
