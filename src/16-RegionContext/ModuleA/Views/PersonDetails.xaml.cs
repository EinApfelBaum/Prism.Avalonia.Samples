using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ModuleA.Business;
using ModuleA.ViewModels;
using Prism.Common;
using Prism.Regions;

namespace ModuleA.Views
{
    public class PersonDetails : UserControl
    {
        public PersonDetails()
        {
            this.InitializeComponent();
            RegionContext.GetObservableContext(this).PropertyChanged += PersonDetail_PropertyChanged;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void PersonDetail_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var context = (ObservableObject<object>)sender;
            var selectedPerson = (Person)context.Value;
            (DataContext as PersonDetailsViewModel).SelectedPerson = selectedPerson;
        }
    }
}
