using Prism.Mvvm;

namespace EventAggregator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
