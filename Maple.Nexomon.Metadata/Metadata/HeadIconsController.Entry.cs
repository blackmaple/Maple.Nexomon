
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."Entry"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000F4U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]
    
                
    // struct 0x10 System.Int32 mapID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"mapID", "MAP_ID")]
            
    // class 0x18 Entity entity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"entity", "ENTITY")]
            
    // class 0x20 System.String currentIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"currentIcon", "CURRENT_ICON")]
            
    // class 0x28 HeadIcon component
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"component", "COMPONENT")]
            
    // class 0x30 ManagerMap mapManager
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"mapManager", "MAP_MANAGER")]
            
    // struct 0x38 System.Boolean terminated
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"terminated", "TERMINATED")]
    public partial class Entry
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Entry";
        //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

        //public const uint Const_TypeToken = 0x020000F4U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Entry(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Entry(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Entry obj) => obj._ptr;
            public static implicit operator bool(Ptr_Entry obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."Entry"]
        /// </summary>
        public partial class Entry
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Boolean <Refresh>b__7_0(DatabaseMaps.Entry.HeadIcon entry)
            /// </summary>
            /// <param name="entry">class DatabaseMaps.Entry.HeadIcon</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Refresh>b__7_0")]
            ///  extern System.Boolean <REFRESH>B__7_0 (nint entry);

            
            /// <summary>
            ///   System.Void ClearComponent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearComponent")]
            ///  extern void CLEAR_COMPONENT ();

            
            /// <summary>
            ///   System.Void Refresh()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Refresh")]
            ///  extern void REFRESH ();

            
            /// <summary>
            ///   System.Void Setup(ManagerMap mapManager, System.Int32 mapID, Entity entity)
            /// </summary>
            /// <param name="mapManager">class ManagerMap</param>
            /// <param name="mapID">struct System.Int32</param>
            /// <param name="entity">class Entity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Setup")]
            ///  extern void SETUP (nint mapManager, System.Int32 mapID, nint entity);

            
            /// <summary>
            ///   System.Void Terminate()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Terminate")]
            ///  extern void TERMINATE ();
            
            

            
            /// public static partial class Search_Entry
            /// {
            /// 
            ///     
            /// 
            /// }

        }
