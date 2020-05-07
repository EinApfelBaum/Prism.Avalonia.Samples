using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Prism.Modularity;

namespace Modules.LoadManual.Views
{
    public class MainWindow : Window
    {
        private readonly IModuleManager _moduleManager;

        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainWindow(IModuleManager moduleManager) : this()
        {
            _moduleManager = moduleManager;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            _moduleManager.LoadModule("ModuleAModule");
        }
    }
}
