using Reface.AppStarter.AppContainerBuilders;
using Reface.AppStarter.AppContainers;
using Reface.AppStarter.Demos.ScanEntities.AppContainers;
using System;
using System.Collections.Generic;

namespace Reface.AppStarter.Demos.ScanEntities.AppContainerBuilders
{
    public class EntityAppContainerBuilder : BaseAppContainerBuilder
    {
        private readonly ICollection<Type> entityTypes;

        public EntityAppContainerBuilder()
        {
            entityTypes = new List<Type>();
        }

        public void AddEntityType(Type type)
        {
            this.entityTypes.Add(type);
        }

        public override IAppContainer Build(AppSetup setup)
        {
            return new EntityAppContainer(entityTypes);
        }
    }
}
