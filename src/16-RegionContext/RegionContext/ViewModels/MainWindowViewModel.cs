using Prism.Mvvm;

namespace RegionContext.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Region Context Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
