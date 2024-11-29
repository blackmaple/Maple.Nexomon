using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.Nexomon.Metadata;
using Microsoft.Extensions.Logging;
using System;
using System.Text;

namespace Maple.Nexomon.Android
{
    public sealed class NexomonGameAndroidService(
        ILogger<NexomonMetadataContext> logger,
        MonoCollectorApiService collectorApiService,
        MonoRuntimeContext runtimeContext,
        MonoTaskScheduler monoTaskScheduler,
        MonoGameSettings gameSettings) : GameContextAndroidService<NexomonMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings)
    {
        MonoCollectorApiService ApiService = collectorApiService;
        protected override NexomonMetadataContext LoadGameContext()
        {
            // return NexomonMetadataContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger);
            return new NexomonMetadataContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, this.Logger, "");
        }



        protected override async ValueTask LoadGameDataAsync()
        {
            Dictionary<string, string[]> enumKey = new()
            {
                ["Assembly-CSharp"] = ["SaveData", "DatabaseMonsters", "Entry", "Equipment", "DatabaseItems", "Custom", "SETTING_ID", "Inventory", "Wallet"],
                ["ACTk.Runtime"] = ["Obscured"]

            };
            var basepath = "/sdcard/Download";
            await foreach (var fileData in EnumClassContentAsync(enumKey).ConfigureAwait(false))
            {
                var filepath = Path.Combine(basepath, fileData.FullName);
                using var stream = File.CreateText(filepath);
                foreach (var str in fileData.Content.GetChunks())
                {
                    await stream.WriteAsync(str).ConfigureAwait(false);
                }

            }

        }


        private async IAsyncEnumerable<ClassContent> EnumClassContentAsync(IReadOnlyDictionary<string, string[]> enumKey)
        {



            var images = await this.ApiService.EnumMonoImagesAsync().ConfigureAwait(false);
            foreach (var image in images)
            {
                foreach (var key in enumKey)
                {
                    if (image.Name.AsSpan().Contains(key.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        var objs = await this.ApiService.EnumMonoObjectsAsync(image.Pointer).ConfigureAwait(false);

                        foreach (var obj in objs)
                        {

                            foreach (var objName in key.Value)
                            {
                                if (obj.Name.AsSpan().Contains(objName, StringComparison.OrdinalIgnoreCase))
                                {
                                    var details = await this.ApiService.EnumMonoClassDetailAsync(obj.Pointer, EnumMonoFieldOptions.EnumAndConst).ConfigureAwait(false);
                                    var content = MonoCollectorGeneratorV0.OutputStringBuilder(
                                           details.ClassInfoDTO,
                                           details.FieldInfos ?? [],
                                           details.MethodInfos ?? [],
                                           details.ParentClassInfos ?? [],
                                           details.InterfaceInfos ?? [], 256);

                                    yield return new ClassContent() { FullName = details.ClassInfoDTO.FullName ?? Guid.CreateVersion7().ToString("N"), Content = content };

                                    foreach (var f in details.FieldInfos ?? [])
                                    {
                                        //  
                                        if (f.Name.AsSpan().Contains("Dictionary", StringComparison.OrdinalIgnoreCase)
                                            || f.Name.AsSpan().Contains("HashSet", StringComparison.OrdinalIgnoreCase)
                                            || f.Name.AsSpan().Contains("Queue", StringComparison.OrdinalIgnoreCase)
                                            || f.Name.AsSpan().Contains("List", StringComparison.OrdinalIgnoreCase))
                                        {
                                            var collectDetails = await this.ApiService.EnumMonoClassDetailAsync(f.Pointer, EnumMonoFieldOptions.None).ConfigureAwait(false);
                                            if (collectDetails.FieldInfos is not null)
                                            {
                                                foreach (var fclass in collectDetails.FieldInfos)
                                                {
                                                    this.Logger.LogInformation("{c}=>{v}:{n}", f.Name, fclass.RawOffset, fclass.Name);
                                                }

                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }

                }


            }

        }


        class ClassContent
        {
            public required string FullName { set; get; }
            public required StringBuilder Content { set; get; }
        }
    }

}
