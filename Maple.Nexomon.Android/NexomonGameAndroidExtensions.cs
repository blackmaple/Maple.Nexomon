using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using System.Runtime.InteropServices;

namespace Maple.Nexomon.Android
{


    public unsafe static partial class NexomonGameAndroidExtensions
    {


        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return AndroidApiExtensions.JNI_OnLoadImp(javaVM, reserved, static api =>
            {
                api.GameName = "Nexomon: Extinction(尼可梦:毁灭)";
                api.GameDesc = "QQ:75351663";
             //   api.DelayStartupSeconds = 10;
                return api.CreateGameAndroidService<NexomonGameAndroidService>();
            });
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            AndroidApiExtensions.JNI_OnUnloadImp(javaVM, reserved);
        }


        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return AndroidApiExtensions.ApiActionImp(jniEnv, instance, actionIndex, json);
        }


        [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            return AndroidApiExtensions.TestActionImp(jniEnv, instance, text);
        }



    }

}
