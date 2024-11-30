
    /// <summary>
    /// class ["Assembly-CSharp.dll"."OSA_NEXOMON"."OSA_ViewHolder_UICustomConfiguration"]
    /// [Com.TheFallenGames.OSA.Core.BaseItemViewsHolder]=>[Com.TheFallenGames.OSA.Core.AbstractViewsHolder]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020005B8U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [79, 83, 65, 95, 78, 69, 88, 79, 77, 79, 78], [79, 83, 65, 95, 86, 105, 101, 119, 72, 111, 108, 100, 101, 114, 95, 85, 73, 67, 117, 115, 116, 111, 109, 67, 111, 110, 102, 105, 103, 117, 114, 97, 116, 105, 111, 110])]
    
                
    // class 0x10 UnityEngine.RectTransform root
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"root", "ROOT")]
            
    // struct 0x18 System.Int32 <ItemIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<ItemIndex>k__BackingField", "ITEM_INDEX")]
            
    // struct 0x1C System.Int32 itemIndexInView
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"itemIndexInView", "ITEM_INDEX_IN_VIEW")]
            
    // abstract class 0x20 TMPro.TMP_Text labelTitle
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"labelTitle", "LABEL_TITLE")]
            
    // abstract class 0x28 TMPro.TMP_Text labelDescription
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"labelDescription", "LABEL_DESCRIPTION")]
            
    // class 0x30 UnityEngine.UI.Image displayBackground
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"displayBackground", "DISPLAY_BACKGROUND")]
            
    // class 0x38 UnityEngine.UI.Image displayIcon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"displayIcon", "DISPLAY_ICON")]
            
    // class 0x40 UnityEngine.RectTransform containerIndicators
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"containerIndicators", "CONTAINER_INDICATORS")]
            
    // class 0x48 UnityEngine.RectTransform templateIndicatorDot
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"templateIndicatorDot", "TEMPLATE_INDICATOR_DOT")]
            
    // class 0x50 UnityEngine.RectTransform indicatorArrowLeft
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"indicatorArrowLeft", "INDICATOR_ARROW_LEFT")]
            
    // class 0x58 UnityEngine.RectTransform indicatorArrowRight
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"indicatorArrowRight", "INDICATOR_ARROW_RIGHT")]
            
    // class 0x60 UnityEngine.GameObject cursor
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cursor", "CURSOR")]
    public partial class OSA_ViewHolder_UICustomConfiguration
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "OSA_NEXOMON";
        //public static byte[] Static_Namespace { get; } = [79, 83, 65, 95, 78, 69, 88, 79, 77, 79, 78];

        //public const string Const_ClassName = "OSA_ViewHolder_UICustomConfiguration";
        //public static byte[] Static_ClassName { get; } = [79, 83, 65, 95, 86, 105, 101, 119, 72, 111, 108, 100, 101, 114, 95, 85, 73, 67, 117, 115, 116, 111, 109, 67, 111, 110, 102, 105, 103, 117, 114, 97, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x020005B8U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_OSA_ViewHolder_UICustomConfiguration(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_OSA_ViewHolder_UICustomConfiguration(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_OSA_ViewHolder_UICustomConfiguration obj) => obj._ptr;
            public static implicit operator bool(Ptr_OSA_ViewHolder_UICustomConfiguration obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."OSA_NEXOMON"."OSA_ViewHolder_UICustomConfiguration"]
        /// </summary>
        public partial class OSA_ViewHolder_UICustomConfiguration
        { 

            
            
            /// <summary>
            ///   System.Void MarkForRebuild()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkForRebuild")]
            ///  extern void MARK_FOR_REBUILD ();

            
            /// <summary>
            ///   System.Void OnBeforeDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnBeforeDestroy")]
            ///  extern void ON_BEFORE_DESTROY ();

            
            /// <summary>
            ///   System.Void ShiftIndex(System.Int32 shift, System.Int32 modulo)
            /// </summary>
            /// <param name="shift">struct System.Int32</param>
            /// <param name="modulo">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShiftIndex")]
            ///  extern void SHIFT_INDEX (System.Int32 shift, System.Int32 modulo);

            
            /// <summary>
            ///   System.Void ShiftIndexInView(System.Int32 shift, System.Int32 modulo)
            /// </summary>
            /// <param name="shift">struct System.Int32</param>
            /// <param name="modulo">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShiftIndexInView")]
            ///  extern void SHIFT_INDEX_IN_VIEW (System.Int32 shift, System.Int32 modulo);

            
            /// <summary>
            ///   System.Int32 ShiftIntWithOverflowCheck(System.Int32 value, System.Int32 shift, System.Int32 modulo)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="shift">struct System.Int32</param>
            /// <param name="modulo">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShiftIntWithOverflowCheck")]
            ///  extern System.Int32 SHIFT_INT_WITH_OVERFLOW_CHECK (System.Int32 value, System.Int32 shift, System.Int32 modulo);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
            ///  extern nint TO_STRING ();

            
            /// <summary>
            ///   System.Void UnmarkForRebuild()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnmarkForRebuild")]
            ///  extern void UNMARK_FOR_REBUILD ();

            
            /// <summary>
            ///   System.Int32 get_ItemIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemIndex")]
            ///  extern System.Int32 GET_ITEM_INDEX ();

            
            /// <summary>
            ///   System.Void set_ItemIndex(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ItemIndex")]
            ///  extern void SET_ITEM_INDEX (System.Int32 value);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void CollectViews()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectViews", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void COLLECT_VIEWS_00 ();

            
            /// <summary>
            ///   System.Void CollectViews()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectViews", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void COLLECT_VIEWS_01 ();

            
            /// <summary>
            ///   System.Void Init(UnityEngine.RectTransform rootPrefab, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
            /// </summary>
            /// <param name="rootPrefab">class UnityEngine.RectTransform</param>
            /// <param name="parent">class UnityEngine.RectTransform</param>
            /// <param name="itemIndex">struct System.Int32</param>
            /// <param name="activateRootGameObject">struct System.Boolean</param>
            /// <param name="callCollectViews">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void INIT_00 (nint rootPrefab, nint parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews);

            
            /// <summary>
            ///   System.Void Init(UnityEngine.GameObject rootPrefabGO, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
            /// </summary>
            /// <param name="rootPrefabGO">class UnityEngine.GameObject</param>
            /// <param name="parent">class UnityEngine.RectTransform</param>
            /// <param name="itemIndex">struct System.Int32</param>
            /// <param name="activateRootGameObject">struct System.Boolean</param>
            /// <param name="callCollectViews">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_OSA_ViewHolder_UICustomConfiguration))]
            ///  extern void INIT_01 (nint rootPrefabGO, nint parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews);

            
            /// public static partial class Search_OSA_ViewHolder_UICustomConfiguration
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
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CollectViews()
                    /// </summary>
                    /// public static bool COLLECT_VIEWS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CollectViews");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void CollectViews()
                    /// </summary>
                    /// public static bool COLLECT_VIEWS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CollectViews");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Init(UnityEngine.RectTransform rootPrefab, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
                    /// </summary>
                    /// public static bool INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init", "UnityEngine.RectTransform", "UnityEngine.RectTransform", "System.Int32", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Init(UnityEngine.GameObject rootPrefabGO, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
                    /// </summary>
                    /// public static bool INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init", "UnityEngine.GameObject", "UnityEngine.RectTransform", "System.Int32", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }
