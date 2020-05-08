using ModuleA.Business;
using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class PersonDetailsViewModel : BindableBase
    {
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }
    }
}
