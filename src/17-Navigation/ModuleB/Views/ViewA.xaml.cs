using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModuleB.Views
{
    public class ViewA : UserControl
    {
        public ViewA()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
