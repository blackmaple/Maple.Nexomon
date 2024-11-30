using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.Nexomon.Metadata
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]


    [MonoCollectorType(typeof(SaveData))]

    [MonoCollectorType(typeof(DatabaseItems))]
    //  [MonoCollectorType(typeof(DatabaseItems_Entry))]

    [MonoCollectorType(typeof(DatabaseMonsters))]
    //    [MonoCollectorType(typeof(DatabaseMonsters_Entry))]

    [MonoCollectorType(typeof(Inventory))]
    [MonoCollectorType(typeof(Wallet))]



    // [MonoCollectorType(typeof(Custom))]
    [MonoCollectorType(typeof(Equipment))]


    [MonoCollectorType(typeof(ObscuredBool))]
    // [MonoCollectorType(typeof(ObscuredByte))]
    // [MonoCollectorType(typeof(ObscuredChar))]
    // [MonoCollectorType(typeof(ObscuredShort))]
    [MonoCollectorType(typeof(ObscuredInt))]
    //  [MonoCollectorType(typeof(ObscuredLong))]
    //  [MonoCollectorType(typeof(ObscuredFloat))]
    //  [MonoCollectorType(typeof(ObscuredDouble))]
    //  [MonoCollectorType(typeof(ObscuredDecimal))]
    [MonoCollectorType(typeof(ObscuredString))]
    //  [MonoCollectorType(typeof(ObscuredUShort))]
    //  [MonoCollectorType(typeof(ObscuredUInt))]
    // [MonoCollectorType(typeof(ObscuredULong))]
    //  [MonoCollectorType(typeof(ObscuredSByte))]


    public partial class NexomonMetadata
    {





    }


    public sealed partial class NexomonMetadataContext : NexomonMetadata
    {
        public DatabaseItems_Entry DatabaseItems_Entry { get; set; }
        public DatabaseMonsters_Entry DatabaseMonsters_Entry { get; set; }

        public NexomonMetadataContext(MonoRuntimeContext runtimeContext, EnumMonoCollectorTypeVersion typeVersion, ILogger logger) 
            : base(runtimeContext, typeVersion, logger, "202411301335")
        {
            var databaseItems_Entry = this.DatabaseItems.ClassInfo.MethodInfos.Where(p => p.Name.AsSpan().SequenceEqual("GetEntry"))
                .Select(p => p.ReturnType).FirstOrDefault() ?? throw new MonoCollectorObjectException("NOT FOUND:DatabaseItems_Entry");
            DatabaseItems_Entry = new DatabaseItems_Entry(this, this.RuntimeContext.GetMonoCollectorClassInfo(databaseItems_Entry.Pointer));

            var databaseMonsters_Entry = this.DatabaseMonsters.ClassInfo.MethodInfos.Where(p => p.Name.AsSpan().SequenceEqual("GetEntry"))
              .Select(p => p.ReturnType).FirstOrDefault() ?? throw new MonoCollectorObjectException("NOT FOUND:DatabaseMonsters_Entry");
            DatabaseMonsters_Entry = new DatabaseMonsters_Entry(this, this.RuntimeContext.GetMonoCollectorClassInfo(databaseMonsters_Entry.Pointer));
        }
    }
}
