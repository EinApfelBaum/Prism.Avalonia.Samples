﻿using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using Utilities.Dialogs;

namespace NavigationCallback.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Navigation Callback Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
            _regionManager = regionManager;
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath, NavigateComplete);
        }

        private void NavigateComplete(NavigationResult result)
        {
            var currentWindow = (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime).MainWindow;

            MessageBox.Show(currentWindow, $"Navigation to {result.Context.Uri} complete.", "Result", MessageBox.MessageBoxButtons.Ok);
        }
    }
}
