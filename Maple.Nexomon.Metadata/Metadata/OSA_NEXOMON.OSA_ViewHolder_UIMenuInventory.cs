
    /// <summary>
    /// class ["Assembly-CSharp.dll"."OSA_NEXOMON"."OSA_ViewHolder_UIMenuInventory"]
    /// [Com.TheFallenGames.OSA.CustomAdapters.GridView.CellViewsHolder]=>[Com.TheFallenGames.OSA.Core.AbstractViewsHolder]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020005CCU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [79, 83, 65, 95, 78, 69, 88, 79, 77, 79, 78], [79, 83, 65, 95, 86, 105, 101, 119, 72, 111, 108, 100, 101, 114, 95, 85, 73, 77, 101, 110, 117, 73, 110, 118, 101, 110, 116, 111, 114, 121])]
    
                
    // class 0x10 UnityEngine.RectTransform root
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"root", "ROOT")]
            
    // struct 0x18 System.Int32 <ItemIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<ItemIndex>k__BackingField", "ITEM_INDEX")]
            
    // class 0x20 UnityEngine.RectTransform views
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"views", "VIEWS")]
            
    // class 0x28 UnityEngine.UI.LayoutElement rootLayoutElement
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"rootLayoutElement", "ROOT_LAYOUT_ELEMENT")]
            
    // abstract class 0x30 TMPro.TMP_Text amountLabel
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"amountLabel", "AMOUNT_LABEL")]
            
    // class 0x38 UnityEngine.UI.Image iconDisplay
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"iconDisplay", "ICON_DISPLAY")]
            
    // class 0x40 UnityEngine.GameObject cursor
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"cursor", "CURSOR")]
            
    // class 0x48 UnityEngine.RectTransform holderAura
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"holderAura", "HOLDER_AURA")]
            
    // class 0x50 UnityEngine.GameObject equippedIndicator
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"equippedIndicator", "EQUIPPED_INDICATOR")]
            
    // class 0x58 UnityEngine.RectTransform backgroundRT
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"backgroundRT", "BACKGROUND_RT")]
    public partial class OSA_ViewHolder_UIMenuInventory
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "OSA_NEXOMON";
        //public static byte[] Static_Namespace { get; } = [79, 83, 65, 95, 78, 69, 88, 79, 77, 79, 78];

        //public const string Const_ClassName = "OSA_ViewHolder_UIMenuInventory";
        //public static byte[] Static_ClassName { get; } = [79, 83, 65, 95, 86, 105, 101, 119, 72, 111, 108, 100, 101, 114, 95, 85, 73, 77, 101, 110, 117, 73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const uint Const_TypeToken = 0x020005CCU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_OSA_ViewHolder_UIMenuInventory(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_OSA_ViewHolder_UIMenuInventory(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_OSA_ViewHolder_UIMenuInventory obj) => obj._ptr;
            public static implicit operator bool(Ptr_OSA_ViewHolder_UIMenuInventory obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."OSA_NEXOMON"."OSA_ViewHolder_UIMenuInventory"]
        /// </summary>
        public partial class OSA_ViewHolder_UIMenuInventory
        { 

            
            
            /// <summary>
            ///   UnityEngine.RectTransform GetViews()
            /// </summary>
            /// <returns>class UnityEngine.RectTransform</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetViews")]
            ///  extern nint GET_VIEWS ();

            
            /// <summary>
            ///   System.Void InitWithExistingRootPrefab(UnityEngine.RectTransform root)
            /// </summary>
            /// <param name="root">class UnityEngine.RectTransform</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitWithExistingRootPrefab")]
            ///  extern void INIT_WITH_EXISTING_ROOT_PREFAB (nint root);

            
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
            ///   System.Int32 ShiftIntWithOverflowCheck(System.Int32 value, System.Int32 shift, System.Int32 modulo)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="shift">struct System.Int32</param>
            /// <param name="modulo">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShiftIntWithOverflowCheck")]
            ///  extern System.Int32 SHIFT_INT_WITH_OVERFLOW_CHECK (System.Int32 value, System.Int32 shift, System.Int32 modulo);

            
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
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void CollectViews()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectViews", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void COLLECT_VIEWS_00 ();

            
            /// <summary>
            ///   System.Void CollectViews()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectViews", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void COLLECT_VIEWS_01 ();

            
            /// <summary>
            ///   System.Void CollectViews()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CollectViews", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void COLLECT_VIEWS_02 ();

            
            /// <summary>
            ///   System.Void Init(UnityEngine.RectTransform rootPrefab, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
            /// </summary>
            /// <param name="rootPrefab">class UnityEngine.RectTransform</param>
            /// <param name="parent">class UnityEngine.RectTransform</param>
            /// <param name="itemIndex">struct System.Int32</param>
            /// <param name="activateRootGameObject">struct System.Boolean</param>
            /// <param name="callCollectViews">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
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
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void INIT_01 (nint rootPrefabGO, nint parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews);

            
            /// <summary>
            ///   System.Void Init(UnityEngine.GameObject rootPrefabGO, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
            /// </summary>
            /// <param name="rootPrefabGO">class UnityEngine.GameObject</param>
            /// <param name="parent">class UnityEngine.RectTransform</param>
            /// <param name="itemIndex">struct System.Int32</param>
            /// <param name="activateRootGameObject">struct System.Boolean</param>
            /// <param name="callCollectViews">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void INIT_02 (nint rootPrefabGO, nint parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews);

            
            /// <summary>
            ///   System.Void MarkForRebuild()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkForRebuild", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void MARK_FOR_REBUILD_00 ();

            
            /// <summary>
            ///   System.Void MarkForRebuild()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkForRebuild", Search = typeof(Search_OSA_ViewHolder_UIMenuInventory))]
            ///  extern void MARK_FOR_REBUILD_01 ();

            
            /// public static partial class Search_OSA_ViewHolder_UIMenuInventory
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
                    ///   System.Void CollectViews()
                    /// </summary>
                    /// public static bool COLLECT_VIEWS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
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

                    
                    /// <summary>
                    ///   System.Void Init(UnityEngine.GameObject rootPrefabGO, UnityEngine.RectTransform parent, System.Int32 itemIndex, System.Boolean activateRootGameObject, System.Boolean callCollectViews)
                    /// </summary>
                    /// public static bool INIT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init", "UnityEngine.GameObject", "UnityEngine.RectTransform", "System.Int32", "System.Boolean", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void MarkForRebuild()
                    /// </summary>
                    /// public static bool MARK_FOR_REBUILD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MarkForRebuild");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void MarkForRebuild()
                    /// </summary>
                    /// public static bool MARK_FOR_REBUILD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MarkForRebuild");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }
