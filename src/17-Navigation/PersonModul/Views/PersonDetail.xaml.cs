using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModulePerson.Views
{
    public class PersonDetail : UserControl
    {
        public PersonDetail()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
