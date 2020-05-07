using Prism.Mvvm;

namespace ViewModelLocator.CustomRegistrations.ViewModels
{
    public class CustomViewModel : BindableBase
    {
        private string _title = "Custom ViewModel Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public CustomViewModel()
        {

        }
    }
}
