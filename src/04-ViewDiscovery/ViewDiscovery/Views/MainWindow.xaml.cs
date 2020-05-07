using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Prism.Regions;

namespace ViewDiscovery.Views
{
    public class MainWindow : Window
    {

        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainWindow(IRegionManager regionManager) : this()
        {
            //view discovery
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            
        }
    }
}
