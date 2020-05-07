using Avalonia;
using Avalonia.Markup.Xaml;
using Modules.AppConfig.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace Modules.AppConfig
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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}
