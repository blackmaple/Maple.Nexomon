
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SaveDataMigration"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x0200006BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 97, 118, 101, 68, 97, 116, 97, 77, 105, 103, 114, 97, 116, 105, 111, 110])]
    
    
    public partial class SaveDataMigration
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SaveDataMigration";
        //public static byte[] Static_ClassName { get; } = [83, 97, 118, 101, 68, 97, 116, 97, 77, 105, 103, 114, 97, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x0200006BU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SaveDataMigration(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SaveDataMigration(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SaveDataMigration obj) => obj._ptr;
            public static implicit operator bool(Ptr_SaveDataMigration obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."SaveDataMigration"]
        /// </summary>
        public partial class SaveDataMigration
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            /// static  System.Boolean AWARD_MISISNG_VAULT_KEY_FOR_COMPLETING_TREE_OF_GIFTS_QUEST_BEFORE_B17(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AWARD_MISISNG_VAULT_KEY_FOR_COMPLETING_TREE_OF_GIFTS_QUEST_BEFORE_B17")]
            /// static extern System.Boolean AWARD_MISISNG_VAULT_KEY_FOR_COMPLETING_TREE_OF_GIFTS_QUEST_BEFORE_B17 (System.Int32 incomingBuildVersion, nint data);

            
            /// <summary>
            /// static  System.Boolean COMPENSATE_ORE_BOULDERS_BEFORE_B19(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("COMPENSATE_ORE_BOULDERS_BEFORE_B19")]
            /// static extern System.Boolean COMPENSATE_ORE_BOULDERS_BEFORE_B19 (System.Int32 incomingBuildVersion, nint data);

            
            /// <summary>
            /// static  System.Boolean DOES_SETTING_AUTOSAVE_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SETTING_AUTOSAVE_EXIST")]
            /// static extern System.Boolean DOES_SETTING_AUTOSAVE_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SETTING_LANGUAGE_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SETTING_LANGUAGE_EXIST")]
            /// static extern System.Boolean DOES_SETTING_LANGUAGE_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SYSTEM_ACHIEVEMENTS_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SYSTEM_ACHIEVEMENTS_EXIST")]
            /// static extern System.Boolean DOES_SYSTEM_ACHIEVEMENTS_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SYSTEM_BEATENMONSTERS_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SYSTEM_BEATENMONSTERS_EXIST")]
            /// static extern System.Boolean DOES_SYSTEM_BEATENMONSTERS_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SYSTEM_CUSTOM_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SYSTEM_CUSTOM_EXIST")]
            /// static extern System.Boolean DOES_SYSTEM_CUSTOM_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SYSTEM_EQUIPMENT_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SYSTEM_EQUIPMENT_EXIST")]
            /// static extern System.Boolean DOES_SYSTEM_EQUIPMENT_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_SYSTEM_LURING_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_SYSTEM_LURING_EXIST")]
            /// static extern System.Boolean DOES_SYSTEM_LURING_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_UNIT_PROPERTY_COSMIC_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_UNIT_PROPERTY_COSMIC_EXIST")]
            /// static extern System.Boolean DOES_UNIT_PROPERTY_COSMIC_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean DOES_UNIT_PROPERTY_HARMONY_EXIST(System.Int32 incomingBuildVersion)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DOES_UNIT_PROPERTY_HARMONY_EXIST")]
            /// static extern System.Boolean DOES_UNIT_PROPERTY_HARMONY_EXIST (System.Int32 incomingBuildVersion);

            
            /// <summary>
            /// static  System.Boolean REPOSITION_PLAYER_FOR_NEW_SHOPS(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("REPOSITION_PLAYER_FOR_NEW_SHOPS")]
            /// static extern System.Boolean REPOSITION_PLAYER_FOR_NEW_SHOPS (System.Int32 incomingBuildVersion, nint data);

            
            /// <summary>
            /// static  System.Void TURN_ABYSSAL_CONTENT_SWITCH_AT_BUILD_60_OR_GREATER(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TURN_ABYSSAL_CONTENT_SWITCH_AT_BUILD_60_OR_GREATER")]
            /// static extern void TURN_ABYSSAL_CONTENT_SWITCH_AT_BUILD_60_OR_GREATER (System.Int32 incomingBuildVersion, nint data);

            
            /// <summary>
            /// static  System.Void TURN_OFF_ABYSSAL_SWITCHES_IF_INCOMING_BUILD_IS_LESS_THAN_60(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TURN_OFF_ABYSSAL_SWITCHES_IF_INCOMING_BUILD_IS_LESS_THAN_60")]
            /// static extern void TURN_OFF_ABYSSAL_SWITCHES_IF_INCOMING_BUILD_IS_LESS_THAN_60 (System.Int32 incomingBuildVersion, nint data);

            
            /// <summary>
            /// static  System.Boolean TURN_OMNISUN_SOLUS_MIRROR_SWITCH_680_AND_681_OFF_BEFORE_B33(System.Int32 incomingBuildVersion, SaveData data)
            /// </summary>
            /// <param name="incomingBuildVersion">struct System.Int32</param>
            /// <param name="data">class SaveData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TURN_OMNISUN_SOLUS_MIRROR_SWITCH_680_AND_681_OFF_BEFORE_B33")]
            /// static extern System.Boolean TURN_OMNISUN_SOLUS_MIRROR_SWITCH_680_AND_681_OFF_BEFORE_B33 (System.Int32 incomingBuildVersion, nint data);
            
            

            
            /// public static partial class Search_SaveDataMigration
            /// {
            /// 
            ///     
            /// 
            /// }

        }
