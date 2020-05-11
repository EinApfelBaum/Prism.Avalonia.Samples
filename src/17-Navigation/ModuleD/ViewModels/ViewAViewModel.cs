using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Prism.Mvvm;
using Prism.Regions;
using System;
using Utilities.Dialogs;

namespace ModuleD.ViewModels
{
    public class ViewAViewModel : BindableBase, IConfirmNavigationRequest
    {
        public async void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = true;
            var currentWindow = (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime).MainWindow;
            var dialogResult = await MessageBox.Show(currentWindow, "Do you want to navigate?", "Navigate?", MessageBox.MessageBoxButtons.OkCancel);
            if (dialogResult == MessageBox.MessageBoxResult.Cancel)
            {
                result = false;
            }
            continuationCallback(result);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
