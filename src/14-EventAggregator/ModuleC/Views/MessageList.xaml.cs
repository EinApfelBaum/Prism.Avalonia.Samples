using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModuleC.Views
{
    public class MessageList : UserControl
    {
        public MessageList()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
