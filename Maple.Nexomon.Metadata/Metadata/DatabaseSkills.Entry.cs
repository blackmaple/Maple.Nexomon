namespace Maple.Nexomon.Metadata;

/// <summary>
/// class ["Assembly-CSharp.dll".""."Entry"]
/// [System.Object]
/// 
/// </summary>
//[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020000BCU)]
[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [69, 110, 116, 114, 121])]


// struct 0x10 System.Int32 id
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"id", "ID")]

// struct 0x14 System.Int32 cost
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"cost", "COST")]

// struct 0x18 System.Int32 speed
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"speed", "SPEED")]

// struct 0x1C System.Int32 accuracy
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"accuracy", "ACCURACY")]

// struct 0x20 System.Int32 criticalChance
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"criticalChance", "CRITICAL_CHANCE")]

// class 0x28 System.String element
// [MonoCollectorSearchFieldAttribute(typeof(nint),"element", "ELEMENT")]

// class 0x30 System.String userFX
// [MonoCollectorSearchFieldAttribute(typeof(nint),"userFX", "USER_FX")]

// class 0x38 System.String targetFX
// [MonoCollectorSearchFieldAttribute(typeof(nint),"targetFX", "TARGET_FX")]

// struct 0x40 System.Boolean targetHurtAnimation
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"targetHurtAnimation", "TARGET_HURT_ANIMATION")]

// struct 0x44 System.Single target_hurt_animation_delay
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"target_hurt_animation_delay", "TARGET_HURT_ANIMATION_DELAY")]

// struct 0x48 System.Boolean damageTarget
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"damageTarget", "DAMAGE_TARGET")]

// struct 0x4C System.Int32 damageTargetPower
// [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"damageTargetPower", "DAMAGE_TARGET_POWER")]

// struct 0x50 System.Single executionDuration
// [MonoCollectorSearchFieldAttribute(typeof(System.Single),"executionDuration", "EXECUTION_DURATION")]

// struct 0x54 System.Boolean userEffectDependent
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"userEffectDependent", "USER_EFFECT_DEPENDENT")]

// struct 0x55 System.Boolean targetEffectDependent
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"targetEffectDependent", "TARGET_EFFECT_DEPENDENT")]

// struct 0x56 System.Boolean mirror
// [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"mirror", "MIRROR")]

// class 0x58 System.Collections.Generic.Dictionary<System.String,DatabaseSkills.Entry.EffectInfo> userEffects
// [MonoCollectorSearchFieldAttribute(typeof(nint),"userEffects", "USER_EFFECTS")]

// class 0x60 System.Collections.Generic.Dictionary<System.String,DatabaseSkills.Entry.EffectInfo> targetEffects
// [MonoCollectorSearchFieldAttribute(typeof(nint),"targetEffects", "TARGET_EFFECTS")]
public partial class Entry
{
    //public const string Const_ImageName = "Assembly-CSharp.dll";
    //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

    //public const string Const_Namespace = "";
    //public static byte[] Static_Namespace { get; } = [];

    //public const string Const_ClassName = "Entry";
    //public static byte[] Static_ClassName { get; } = [69, 110, 116, 114, 121];

    //public const uint Const_TypeToken = 0x020000BCU;








    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly unsafe partial struct Ptr_Entry(nint ptr)
    {

        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator Ptr_Entry(nint ptr) => new(ptr);
        public static implicit operator nint(Ptr_Entry obj) => obj._ptr;
        public static implicit operator bool(Ptr_Entry obj) => obj.Valid();

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
    ///   System.String GetElement()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetElement")]
    ///  extern nint GET_ELEMENT ();


    /// <summary>
    ///   DatabaseElements.Entry GetElementData()
    /// </summary>
    /// <returns>class DatabaseElements.Entry</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetElementData")]
    ///  extern nint GET_ELEMENT_DATA ();


    /// <summary>
    ///   System.String GetLocalizedDescription()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedDescription")]
    ///  extern nint GET_LOCALIZED_DESCRIPTION ();


    /// <summary>
    ///   System.String GetLocalizedName()
    /// </summary>
    /// <returns>class System.String</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalizedName")]
    ///  extern nint GET_LOCALIZED_NAME ();


    /// <summary>
    ///   System.Boolean IsDamagingSkill()
    /// </summary>
    /// <returns>struct System.Boolean</returns>
    /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsDamagingSkill")]
    ///  extern System.Boolean IS_DAMAGING_SKILL ();




    /// public static partial class Search_Entry
    /// {
    /// 
    ///     
    /// 
    /// }

}
