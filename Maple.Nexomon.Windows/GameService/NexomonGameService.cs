using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.HotKey;
using Maple.MonoGameAssistant.Model;
using Maple.Nexomon.Metadata;
using Microsoft.Extensions.Logging;

namespace Maple.Nexomon.Windows.GameService
{

    internal sealed partial class NexomonGameService(ILogger<NexomonGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
        : GameContextService<NexomonMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)

    {
        protected sealed override NexomonMetadataContext LoadGameContext()
        {
            //    return NexomonMetadataContext.LoadGameContext(RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);

            return new NexomonMetadataContext(RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);
        }



    }
}
