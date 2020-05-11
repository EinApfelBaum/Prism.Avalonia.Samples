using Avalonia;
using Avalonia.Markup.Xaml;
using NavigationParticipation.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace NavigationParticipation
{
    public class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        protected override IAvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleB.ModuleBModule>();
        }
    }
}
