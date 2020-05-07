using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModuleA.Views
{
    public class MessageView : UserControl
    {
        public MessageView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
