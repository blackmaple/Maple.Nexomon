
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SaveDataHandlerSwitch"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200006AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 97, 118, 101, 68, 97, 116, 97, 72, 97, 110, 100, 108, 101, 114, 83, 119, 105, 116, 99, 104])]
    
    
    public partial class SaveDataHandlerSwitch
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SaveDataHandlerSwitch";
        //public static byte[] Static_ClassName { get; } = [83, 97, 118, 101, 68, 97, 116, 97, 72, 97, 110, 100, 108, 101, 114, 83, 119, 105, 116, 99, 104];

        //public const uint Const_TypeToken = 0x0200006AU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SaveDataHandlerSwitch(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SaveDataHandlerSwitch(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SaveDataHandlerSwitch obj) => obj._ptr;
            public static implicit operator bool(Ptr_SaveDataHandlerSwitch obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."SaveDataHandlerSwitch"]
        /// </summary>
        public partial class SaveDataHandlerSwitch
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            /// static  System.ValueTuple<System.Boolean,System.Boolean> CheckDataType(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>struct System.ValueTuple<System.Boolean,System.Boolean></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckDataType")]
            /// static extern System.ValueTuple<System.Boolean,System.Boolean> CHECK_DATA_TYPE (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Boolean CheckExistsBINARY(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckExistsBINARY")]
            /// static extern System.Boolean CHECK_EXISTS_BINARY (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Boolean CheckExistsJSON(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckExistsJSON")]
            /// static extern System.Boolean CHECK_EXISTS_JSON (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Boolean ExecuteDeleteBINARY(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteDeleteBINARY")]
            /// static extern System.Boolean EXECUTE_DELETE_BINARY (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Boolean ExecuteDeleteJSON(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteDeleteJSON")]
            /// static extern System.Boolean EXECUTE_DELETE_JSON (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Byte[] ExecuteLoadFromBINARY(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>class System.Byte[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteLoadFromBINARY")]
            /// static extern nint EXECUTE_LOAD_FROM_BINARY (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Byte[] ExecuteLoadFromJSON(System.Int32 slotNumber)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <returns>class System.Byte[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteLoadFromJSON")]
            /// static extern nint EXECUTE_LOAD_FROM_JSON (System.Int32 slotNumber);

            
            /// <summary>
            /// static  System.Boolean ExecuteSaveToBINARY(System.Int32 slotNumber, SaveData data)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteSaveToBINARY")]
            /// static extern System.Boolean EXECUTE_SAVE_TO_BINARY (System.Int32 slotNumber, nint data);

            
            /// <summary>
            /// static  System.Boolean ExecuteSaveToJSON(System.Int32 slotNumber, SaveData data)
            /// </summary>
            /// <param name="slotNumber">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ExecuteSaveToJSON")]
            /// static extern System.Boolean EXECUTE_SAVE_TO_JSON (System.Int32 slotNumber, nint data);
            
            

            
            /// public static partial class Search_SaveDataHandlerSwitch
            /// {
            /// 
            ///     
            /// 
            /// }

        }
