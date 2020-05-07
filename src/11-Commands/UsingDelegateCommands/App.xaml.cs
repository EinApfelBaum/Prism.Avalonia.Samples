using Avalonia;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Unity;
using UsingDelegateCommands.Views;

namespace UsingDelegateCommands
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
