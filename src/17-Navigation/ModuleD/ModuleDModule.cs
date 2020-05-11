using ModuleD.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleD
{
    public class ModuleDModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
        }
    }
}
