using Maple.MonoGameAssistant.Core;

namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredString"]
/// [System.Object]
/// [CodeStage.AntiCheat.ObscuredTypes.IObscuredType]=>[System.IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredString>]=>[System.IComparable<System.String>]=>[System.IComparable]
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], 0x0200001CU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108], [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115], [79, 98, 115, 99, 117, 114, 101, 100, 83, 116, 114, 105, 110, 103])]


// class 0x10 System.String currentCryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(nint),"currentCryptoKey", "CURRENT_CRYPTO_KEY")]

// class 0x18 System.Byte[] hiddenValue
// [MonoCollectorSearchFieldAttribute(typeof(nint),"hiddenValue", "HIDDEN_VALUE")]

// class 0x20 System.Char[] cryptoKey
// [MonoCollectorSearchFieldAttribute(typeof(nint),"cryptoKey", "CRYPTO_KEY")]

// class 0x28 System.Char[] hiddenChars
// [MonoCollectorSearchFieldAttribute(typeof(nint),"hiddenChars", "HIDDEN_CHARS")]

// struct 0x30 System.Boolean inited
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"inited", "INITED")]

// class 0x38 System.String fakeValue
// [MonoCollectorSearchFieldAttribute(typeof(nint),"fakeValue", "FAKE_VALUE")]

// struct 0x40 System.Boolean fakeValueActive
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"fakeValueActive", "FAKE_VALUE_ACTIVE")]
public partial class ObscuredString
{
    //public const string Const_ImageName = "ACTk.Runtime.dll";
    //public static byte[] Static_ImageName { get; } = [65, 67, 84, 107, 46, 82, 117, 110, 116, 105, 109, 101, 46, 100, 108, 108];

    //public const string Const_Namespace = "CodeStage.AntiCheat.ObscuredTypes";
    //public static byte[] Static_Namespace { get; } = [67, 111, 100, 101, 83, 116, 97, 103, 101, 46, 65, 110, 116, 105, 67, 104, 101, 97, 116, 46, 79, 98, 115, 99, 117, 114, 101, 100, 84, 121, 112, 101, 115];

    //public const string Const_ClassName = "ObscuredString";
    //public static byte[] Static_ClassName { get; } = [79, 98, 115, 99, 117, 114, 101, 100, 83, 116, 114, 105, 110, 103];

    //public const uint Const_TypeToken = 0x0200001CU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_ObscuredString(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_ObscuredString(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_ObscuredString obj) => obj._ptr;
        public static implicit operator bool(Ptr_ObscuredString obj) => obj.Valid();

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;



    }

}

/// <summary>
/// ["ACTk.Runtime.dll"."CodeStage.AntiCheat.ObscuredTypes"."ObscuredString"]
/// </summary>
public partial class ObscuredString
{



    /// <summary>
    ///   System.Void ApplyNewCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyNewCryptoKey")]
    ///  extern void APPLY_NEW_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Boolean ArraysEquals(System.Char[] a1, System.Char[] a2)
    /// </summary>
    /// <param name="a1">class System.Char[]</param>
    /// <param name="a2">class System.Char[]</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ArraysEquals")]
    /// static extern System.Boolean ARRAYS_EQUALS (nint a1, nint a2);


    /// <summary>
    ///   System.Boolean CompareCharsToString(System.Char[] chars, System.String s)
    /// </summary>
    /// <param name="chars">class System.Char[]</param>
    /// <param name="s">class System.String</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareCharsToString")]
    ///  extern System.Boolean COMPARE_CHARS_TO_STRING (nint chars, nint s);


    /// <summary>
    /// static  System.String EncryptDecryptObsolete(System.String value, System.String key)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="key">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecryptObsolete")]
    /// static extern nint ENCRYPT_DECRYPT_OBSOLETE (nint value, nint key);


    /// <summary>
    ///   System.Boolean EndsWith(System.String value, System.StringComparison comparisonType)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="comparisonType">enum System.StringComparison</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EndsWith")]
    ///  extern System.Boolean ENDS_WITH (nint value, System.StringComparison comparisonType);


    /// <summary>
    /// static  System.Byte[] GetBytesObsolete(System.String str)
    /// </summary>
    /// <param name="str">class System.String</param>
    /// <returns>class System.Byte[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBytesObsolete")]
    /// static extern nint GET_BYTES_OBSOLETE (nint str);


    /// <summary>
    ///   System.String GetDecrypted()
    /// </summary>
    /// <returns>class System.String</returns>
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecrypted")]
    extern PMonoString GET_DECRYPTED();


    /// <summary>
    ///   System.Char[] GetDecryptedToChars()
    /// </summary>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetDecryptedToChars")]
    ///  extern nint GET_DECRYPTED_TO_CHARS ();


    /// <summary>
    ///   System.Int32 GetHashCode()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
    ///  extern System.Int32 GET_HASH_CODE ();


    /// <summary>
    /// static  System.String GetStringObsolete(System.Byte[] bytes)
    /// </summary>
    /// <param name="bytes">class System.Byte[]</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStringObsolete")]
    /// static extern nint GET_STRING_OBSOLETE (nint bytes);


    /// <summary>
    ///   System.Char[] InternalDecrypt()
    /// </summary>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecrypt")]
    ///  extern nint INTERNAL_DECRYPT ();


    /// <summary>
    ///   System.String InternalDecryptToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDecryptToString")]
    ///  extern nint INTERNAL_DECRYPT_TO_STRING ();


    /// <summary>
    /// static  System.Char[] InternalEncryptDecrypt(System.Char[] value, System.Char[] key)
    /// </summary>
    /// <param name="value">class System.Char[]</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalEncryptDecrypt")]
    /// static extern nint INTERNAL_ENCRYPT_DECRYPT (nint value, nint key);


    /// <summary>
    ///   System.Void MigrateFromACTkV1()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MigrateFromACTkV1")]
    ///  extern void MIGRATE_FROM_AC_TK_V1 ();


    /// <summary>
    ///   System.Void RandomizeCryptoKey()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RandomizeCryptoKey")]
    ///  extern void RANDOMIZE_CRYPTO_KEY ();


    /// <summary>
    /// static  System.Void SetNewCryptoKey(System.String newKey)
    /// </summary>
    /// <param name="newKey">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetNewCryptoKey")]
    /// static extern void SET_NEW_CRYPTO_KEY (nint newKey);


    /// <summary>
    ///   System.Boolean StartsWith(System.String value, System.StringComparison comparisonType)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="comparisonType">enum System.StringComparison</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartsWith")]
    ///  extern System.Boolean STARTS_WITH (nint value, System.StringComparison comparisonType);


    /// <summary>
    ///   System.String ToString()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
    ///  extern nint TO_STRING ();


    /// <summary>
    ///   System.Char get_Item(System.Int32 index)
    /// </summary>
    /// <param name="index">struct System.Int32</param>
    /// <returns>struct System.Char</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
    ///  extern System.Char GET_ITEM (System.Int32 index);


    /// <summary>
    ///   System.Int32 get_Length()
    /// </summary>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Length")]
    ///  extern System.Int32 GET_LENGTH ();


    /// <summary>
    /// static  System.Boolean op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
    /// </summary>
    /// <param name="a">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <param name="b">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
    /// static extern System.Boolean OP_EQUALITY (nint a, nint b);


    /// <summary>
    /// static  System.Boolean op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b)
    /// </summary>
    /// <param name="a">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <param name="b">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
    /// static extern System.Boolean OP_INEQUALITY (nint a, nint b);



    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredString))]
    ///  extern void .CTOR_00 ();


    /// <summary>
    ///   System.Void .ctor(System.String value)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ObscuredString))]
    ///  extern void .CTOR_01 (nint value);


    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredString other)
    /// </summary>
    /// <param name="other">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredString))]
    ///  extern System.Int32 COMPARE_TO_00 (nint other);


    /// <summary>
    ///   System.Int32 CompareTo(System.String other)
    /// </summary>
    /// <param name="other">class System.String</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredString))]
    ///  extern System.Int32 COMPARE_TO_01 (nint other);


    /// <summary>
    ///   System.Int32 CompareTo(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Int32</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTo", Search = typeof(Search_ObscuredString))]
    ///  extern System.Int32 COMPARE_TO_02 (nint obj);


    /// <summary>
    /// static  System.String Decrypt(System.Char[] value, System.String key)
    /// </summary>
    /// <param name="value">class System.Char[]</param>
    /// <param name="key">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint DECRYPT_00 (nint value, nint key);


    /// <summary>
    /// static  System.String Decrypt(System.Char[] value, System.Char[] key)
    /// </summary>
    /// <param name="value">class System.Char[]</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint DECRYPT_01 (nint value, nint key);


    /// <summary>
    /// static  System.Char[] Encrypt(System.String value, System.String key)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="key">class System.String</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint ENCRYPT_00 (nint value, nint key);


    /// <summary>
    /// static  System.Char[] Encrypt(System.String value, System.Char[] key)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint ENCRYPT_01 (nint value, nint key);


    /// <summary>
    /// static  System.Char[] Encrypt(System.Char[] value, System.Char[] key)
    /// </summary>
    /// <param name="value">class System.Char[]</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint ENCRYPT_02 (nint value, nint key);


    /// <summary>
    /// static  System.String EncryptDecrypt(System.String value)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint ENCRYPT_DECRYPT_00 (nint value);


    /// <summary>
    /// static  System.String EncryptDecrypt(System.String value, System.String key)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <param name="key">class System.String</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EncryptDecrypt", Search = typeof(Search_ObscuredString))]
    /// static extern nint ENCRYPT_DECRYPT_01 (nint value, nint key);


    /// <summary>
    ///   System.Boolean Equals(System.Object obj)
    /// </summary>
    /// <param name="obj">class System.Object</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredString))]
    ///  extern System.Boolean EQUALS_00 (nint obj);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
    /// </summary>
    /// <param name="value">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredString))]
    ///  extern System.Boolean EQUALS_01 (nint value);


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value, System.StringComparison comparisonType)
    /// </summary>
    /// <param name="value">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <param name="comparisonType">enum System.StringComparison</param>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals", Search = typeof(Search_ObscuredString))]
    ///  extern System.Boolean EQUALS_02 (nint value, System.StringComparison comparisonType);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString FromEncrypted(System.Char[] encrypted, System.Char[] key)
    /// </summary>
    /// <param name="encrypted">class System.Char[]</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredString))]
    /// static extern nint FROM_ENCRYPTED_00 (nint encrypted, nint key);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString FromEncrypted(System.String encrypted, System.String key)
    /// </summary>
    /// <param name="encrypted">class System.String</param>
    /// <param name="key">class System.String</param>
    /// <returns>class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FromEncrypted", Search = typeof(Search_ObscuredString))]
    /// static extern nint FROM_ENCRYPTED_01 (nint encrypted, nint key);


    /// <summary>
    /// static  System.Char[] GenerateKey()
    /// </summary>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey", Search = typeof(Search_ObscuredString))]
    /// static extern nint GENERATE_KEY_00 ();


    /// <summary>
    /// static  System.Char[] GenerateKey(System.Char[] arrayToFill)
    /// </summary>
    /// <param name="arrayToFill">class System.Char[]</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GenerateKey", Search = typeof(Search_ObscuredString))]
    /// static extern nint GENERATE_KEY_01 (nint arrayToFill);


    /// <summary>
    ///   System.Char[] GetEncrypted(System.Char[]& key)
    /// </summary>
    /// <param name="key">class System.Char[]&</param>
    /// <returns>class System.Char[]</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredString))]
    ///  extern nint GET_ENCRYPTED_00 (nint key);


    /// <summary>
    ///   System.String GetEncrypted()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEncrypted", Search = typeof(Search_ObscuredString))]
    ///  extern nint GET_ENCRYPTED_01 ();


    /// <summary>
    ///   System.Void SetEncrypted(System.Char[] encrypted, System.Char[] key)
    /// </summary>
    /// <param name="encrypted">class System.Char[]</param>
    /// <param name="key">class System.Char[]</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredString))]
    ///  extern void SET_ENCRYPTED_00 (nint encrypted, nint key);


    /// <summary>
    ///   System.Void SetEncrypted(System.String encrypted, System.String key)
    /// </summary>
    /// <param name="encrypted">class System.String</param>
    /// <param name="key">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredString))]
    ///  extern void SET_ENCRYPTED_01 (nint encrypted, nint key);


    /// <summary>
    ///   System.Void SetEncrypted(System.String encrypted)
    /// </summary>
    /// <param name="encrypted">class System.String</param>
    /// <returns>struct System.Void</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEncrypted", Search = typeof(Search_ObscuredString))]
    ///  extern void SET_ENCRYPTED_02 (nint encrypted);


    /// <summary>
    ///   System.String Substring(System.Int32 startIndex)
    /// </summary>
    /// <param name="startIndex">struct System.Int32</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Substring", Search = typeof(Search_ObscuredString))]
    ///  extern nint SUBSTRING_00 (System.Int32 startIndex);


    /// <summary>
    ///   System.String Substring(System.Int32 startIndex, System.Int32 length)
    /// </summary>
    /// <param name="startIndex">struct System.Int32</param>
    /// <param name="length">struct System.Int32</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Substring", Search = typeof(Search_ObscuredString))]
    ///  extern nint SUBSTRING_01 (System.Int32 startIndex, System.Int32 length);


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString op_Implicit(System.String value)
    /// </summary>
    /// <param name="value">class System.String</param>
    /// <returns>class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredString))]
    /// static extern nint OP_IMPLICIT_00 (nint value);


    /// <summary>
    /// static  System.String op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
    /// </summary>
    /// <param name="value">class CodeStage.AntiCheat.ObscuredTypes.ObscuredString</param>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_ObscuredString))]
    /// static extern nint OP_IMPLICIT_01 (nint value);


    /// public static partial class Search_ObscuredString
    /// {
    /// 
    ///     

    /// <summary>
    ///   System.Void .ctor()
    /// </summary>
    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void .ctor(System.String value)
    /// </summary>
    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(CodeStage.AntiCheat.ObscuredTypes.ObscuredString other)
    /// </summary>
    /// public static bool COMPARE_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Int32 CompareTo(System.String other)
    /// </summary>
    /// public static bool COMPARE_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CompareTo", "System.String");
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
    /// static  System.String Decrypt(System.Char[] value, System.String key)
    /// </summary>
    /// public static bool DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Char[]", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.String Decrypt(System.Char[] value, System.Char[] key)
    /// </summary>
    /// public static bool DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrypt", "System.Char[]", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char[] Encrypt(System.String value, System.String key)
    /// </summary>
    /// public static bool ENCRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.String", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char[] Encrypt(System.String value, System.Char[] key)
    /// </summary>
    /// public static bool ENCRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.String", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char[] Encrypt(System.Char[] value, System.Char[] key)
    /// </summary>
    /// public static bool ENCRYPT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Encrypt", "System.Char[]", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.String EncryptDecrypt(System.String value)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.String EncryptDecrypt(System.String value, System.String key)
    /// </summary>
    /// public static bool ENCRYPT_DECRYPT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EncryptDecrypt", "System.String", "System.String");
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
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
    /// </summary>
    /// public static bool EQUALS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Boolean Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value, System.StringComparison comparisonType)
    /// </summary>
    /// public static bool EQUALS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Equals", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString", "System.StringComparison");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString FromEncrypted(System.Char[] encrypted, System.Char[] key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.Char[]", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString FromEncrypted(System.String encrypted, System.String key)
    /// </summary>
    /// public static bool FROM_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FromEncrypted", "System.String", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char[] GenerateKey()
    /// </summary>
    /// public static bool GENERATE_KEY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateKey");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.Char[] GenerateKey(System.Char[] arrayToFill)
    /// </summary>
    /// public static bool GENERATE_KEY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GenerateKey", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Char[] GetEncrypted(System.Char[]& key)
    /// </summary>
    /// public static bool GET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted", "System.Char[]&");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String GetEncrypted()
    /// </summary>
    /// public static bool GET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEncrypted");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.Char[] encrypted, System.Char[] key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.Char[]", "System.Char[]");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.String encrypted, System.String key)
    /// </summary>
    /// public static bool SET_ENCRYPTED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.String", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.Void SetEncrypted(System.String encrypted)
    /// </summary>
    /// public static bool SET_ENCRYPTED_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetEncrypted", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String Substring(System.Int32 startIndex)
    /// </summary>
    /// public static bool SUBSTRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Substring", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    ///   System.String Substring(System.Int32 startIndex, System.Int32 length)
    /// </summary>
    /// public static bool SUBSTRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Substring", "System.Int32", "System.Int32");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  CodeStage.AntiCheat.ObscuredTypes.ObscuredString op_Implicit(System.String value)
    /// </summary>
    /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.String");
    ///     
    ///  
    /// 


    /// <summary>
    /// static  System.String op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value)
    /// </summary>
    /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "CodeStage.AntiCheat.ObscuredTypes.ObscuredString");
    ///     
    ///  
    /// 
    /// 
    /// }

}
