using Reface.AppStarter.AppContainers;
using System;
using System.Collections.Generic;

namespace Reface.AppStarter.Demos.ScanEntities.AppContainers
{
    public class EntityAppContainer : BaseAppContainer
    {
        private readonly IEnumerable<Type> entityType;

        public EntityAppContainer(IEnumerable<Type> entityType)
        {
            this.entityType = entityType;
        }

        public override void OnAppStarted(App app)
        {
            entityType.ForEach(x => Console.WriteLine("Do CODE-FIRST from type {0}", x));
        }
    }
}