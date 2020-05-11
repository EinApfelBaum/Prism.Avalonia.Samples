﻿using Prism.Mvvm;
using Prism.Regions;

namespace ModuleC.ViewModels
{
    public class ViewBViewModel : BindableBase, INavigationAware
    {
        private string _title = "ViewB";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private int _pageViews;
        public int PageViews
        {
            get { return _pageViews; }
            set { SetProperty(ref _pageViews, value); }
        }

        public ViewBViewModel()
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            PageViews++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return PageViews / 6 != 1;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
