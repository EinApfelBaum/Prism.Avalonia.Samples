﻿using Prism.Mvvm;
using Commands.Core;

namespace UsingCompositeCommands.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "UsingCompositeCommands Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        public MainWindowViewModel(IApplicationCommands applicationCommands)
        {
            ApplicationCommands = applicationCommands;
        }
    }
}
