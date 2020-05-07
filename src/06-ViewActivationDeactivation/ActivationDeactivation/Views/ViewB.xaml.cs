using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ActivationDeactivation.Views
{
    public class ViewB : UserControl
    {
        public ViewB()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
