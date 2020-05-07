using Avalonia;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using ViewModelLocator.CustomRegistrations.ViewModels;
using ViewModelLocator.CustomRegistrations.Views;

namespace ViewModelLocator.CustomRegistrations
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

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            // type / type
            //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(), typeof(CustomViewModel));
            
            // type / factory
            //ViewModelLocationProvider.Register(typeof(MainWindow).ToString(),() => Container.Resolve<CustomViewModel>());

            // generic / factory
            ViewModelLocationProvider.Register<MainWindow>(() => Container.Resolve<CustomViewModel>());

            // generic type
            //ViewModelLocationProvider.Register<MainWindow, CustomViewModel>();
        }
    }
}
