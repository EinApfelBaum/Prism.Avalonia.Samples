using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModuleB.Views
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
