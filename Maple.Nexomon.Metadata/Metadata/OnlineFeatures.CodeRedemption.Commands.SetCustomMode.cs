
    /// <summary>
    /// struct ["Assembly-CSharp.dll"."OnlineFeatures.CodeRedemption.Commands"."SetCustomMode"]
    /// [OnlineFeatures.CodeRedemption.Commands.IRemoteCommand]
    /// </summary>
    public partial class SetCustomMode
    { 

        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_SetCustomMode
        {
    
            
                        
            /// const string Name_Field__active = "_active";
            /// <summary>
            /// struct 0x10 System.Boolean _active
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Boolean _active;

        }

    }

    /// <summary>
    /// struct ["Assembly-CSharp.dll"."OnlineFeatures.CodeRedemption.Commands"."SetCustomMode"]
    /// 
    /// [OnlineFeatures.CodeRedemption.Commands.IRemoteCommand]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200056EU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [79, 110, 108, 105, 110, 101, 70, 101, 97, 116, 117, 114, 101, 115, 46, 67, 111, 100, 101, 82, 101, 100, 101, 109, 112, 116, 105, 111, 110, 46, 67, 111, 109, 109, 97, 110, 100, 115], [83, 101, 116, 67, 117, 115, 116, 111, 109, 77, 111, 100, 101])]
    
                
    // struct 0x10 System.Boolean _active
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_active", "_ACTIVE")]
    public partial class SetCustomMode
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "OnlineFeatures.CodeRedemption.Commands";
        //public static byte[] Static_Namespace { get; } = [79, 110, 108, 105, 110, 101, 70, 101, 97, 116, 117, 114, 101, 115, 46, 67, 111, 100, 101, 82, 101, 100, 101, 109, 112, 116, 105, 111, 110, 46, 67, 111, 109, 109, 97, 110, 100, 115];

        //public const string Const_ClassName = "SetCustomMode";
        //public static byte[] Static_ClassName { get; } = [83, 101, 116, 67, 117, 115, 116, 111, 109, 77, 111, 100, 101];

        //public const uint Const_TypeToken = 0x0200056EU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SetCustomMode(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SetCustomMode(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SetCustomMode obj) => obj._ptr;
            public static implicit operator bool(Ptr_SetCustomMode obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }
