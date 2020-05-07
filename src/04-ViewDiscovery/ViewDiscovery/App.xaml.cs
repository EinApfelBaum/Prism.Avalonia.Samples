using Avalonia;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Unity;
using ViewDiscovery.Views;

namespace ViewDiscovery
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
    }
}
