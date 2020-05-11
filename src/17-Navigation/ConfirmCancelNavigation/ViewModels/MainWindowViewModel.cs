using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;

namespace ConfirmCancelNavigation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Confirm Cancel Navigation Prism Avalonia Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IRegionManager _regionManager;

        public ICommand NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }
    }
}
