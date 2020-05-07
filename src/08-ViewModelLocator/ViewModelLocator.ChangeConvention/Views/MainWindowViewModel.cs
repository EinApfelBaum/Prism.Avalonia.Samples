using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLocator.ChangeConvention.Views
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ChangeConvention Prism Avalonia Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
