using Prism.Mvvm;

namespace PassingParameters.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Passing Parameters Prism Avalonia Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
