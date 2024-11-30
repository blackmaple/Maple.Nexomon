
    /// <summary>
    /// struct ["Assembly-CSharp-firstpass.dll".""."CustomTag"]
    /// 
    /// </summary>
    public partial class CustomTag
    { 

        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_CustomTag
        {
    
            
                        
            /// const string Name_Field_triggered = "<triggered>k__BackingField";
            /// <summary>
            /// struct 0x10 System.Boolean <triggered>k__BackingField
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Boolean triggered;

                        
            /// const string Name_Field_defaultFeature = "defaultFeature";
            /// <summary>
            /// enum 0x14 Febucci.UI.Core.DefaultFeature defaultFeature
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public readonly Febucci.UI.Core.DefaultFeature defaultFeature;

                        
            /// const string Name_Field_customFeature = "customFeature";
            /// <summary>
            /// enum 0x18 Febucci.UI.Core.CustomFeature customFeature
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public readonly Febucci.UI.Core.CustomFeature customFeature;

                        
            /// const string Name_Field_charIndex = "<charIndex>k__BackingField";
            /// <summary>
            /// struct 0x1C System.Int32 <charIndex>k__BackingField
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
            public readonly System.Int32 charIndex;

                        
            /// const string Name_Field_parameters = "parameters";
            /// <summary>
            /// class 0x20 System.Collections.Generic.List<System.String> parameters
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public readonly nint parameters;

        }

    }

    /// <summary>
    /// struct ["Assembly-CSharp-firstpass.dll".""."CustomTag"]
    /// 
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 45, 102, 105, 114, 115, 116, 112, 97, 115, 115, 46, 100, 108, 108], 0x020000BBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 45, 102, 105, 114, 115, 116, 112, 97, 115, 115, 46, 100, 108, 108], [], [67, 117, 115, 116, 111, 109, 84, 97, 103])]
    
                
    // struct 0x10 System.Boolean <triggered>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<triggered>k__BackingField", "TRIGGERED")]
            
    // enum 0x14 Febucci.UI.Core.DefaultFeature defaultFeature
    // [MonoCollectorSearchFieldAttribute(typeof(Febucci.UI.Core.DefaultFeature),"defaultFeature", "DEFAULT_FEATURE")]
            
    // enum 0x18 Febucci.UI.Core.CustomFeature customFeature
    // [MonoCollectorSearchFieldAttribute(typeof(Febucci.UI.Core.CustomFeature),"customFeature", "CUSTOM_FEATURE")]
            
    // struct 0x1C System.Int32 <charIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<charIndex>k__BackingField", "CHAR_INDEX")]
            
    // class 0x20 System.Collections.Generic.List<System.String> parameters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parameters", "PARAMETERS")]
    public partial class CustomTag
    { 
        //public const string Const_ImageName = "Assembly-CSharp-firstpass.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 45, 102, 105, 114, 115, 116, 112, 97, 115, 115, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "CustomTag";
        //public static byte[] Static_ClassName { get; } = [67, 117, 115, 116, 111, 109, 84, 97, 103];

        //public const uint Const_TypeToken = 0x020000BBU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CustomTag(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CustomTag(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CustomTag obj) => obj._ptr;
            public static implicit operator bool(Ptr_CustomTag obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp-firstpass.dll".""."CustomTag"]
        /// </summary>
        public partial class CustomTag
        { 

            
            
            /// <summary>
            ///   System.Int32 get_charIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_charIndex")]
            ///  extern System.Int32 GET_CHAR_INDEX ();

            
            /// <summary>
            ///   System.Boolean get_triggered()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_triggered")]
            ///  extern System.Boolean GET_TRIGGERED ();

            
            /// <summary>
            ///   System.Void set_charIndex(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_charIndex")]
            ///  extern void SET_CHAR_INDEX (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_triggered(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_triggered")]
            ///  extern void SET_TRIGGERED (System.Boolean value);
            
            

            
            /// public static partial class Search_CustomTag
            /// {
            /// 
            ///     
            /// 
            /// }

        }
