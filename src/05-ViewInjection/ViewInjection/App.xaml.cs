﻿using Avalonia;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Unity;
using ViewInjection.Views;

namespace ViewInjection
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
