using Prism.Mvvm;

namespace ViewModelLocator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ViewModelLocator Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
