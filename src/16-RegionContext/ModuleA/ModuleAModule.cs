using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleA : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(PersonList));
            regionManager.RegisterViewWithRegion("PersonDetailsRegion", typeof(PersonDetails));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
