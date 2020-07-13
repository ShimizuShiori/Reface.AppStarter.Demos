using Reface.AppStarter.AppModules;
using Reface.AppStarter.Demos.ScanEntities.AppContainerBuilders;
using Reface.AppStarter.Demos.ScanEntities.Attributes;
using System.Linq;

namespace Reface.AppStarter.Demos.ScanEntities.AppModules
{
    public class EntityScanAppModule : AppModule
    {
        public override void OnUsing(AppModuleUsingArguments args)
        {
            EntityAppContainerBuilder builder = args.AppSetup.GetAppContainerBuilder<EntityAppContainerBuilder>();

            args
                .ScannedAttributeAndTypeInfos
                .Where(x => x.Attribute is EntityAttribute)
                .Select(x => x.Type)
                .ForEach(x => builder.AddEntityType(x));

        }
    }
}
