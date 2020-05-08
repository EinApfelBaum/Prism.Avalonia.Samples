using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModuleA.Views
{
    public class PersonList : UserControl
    {
        public PersonList()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
