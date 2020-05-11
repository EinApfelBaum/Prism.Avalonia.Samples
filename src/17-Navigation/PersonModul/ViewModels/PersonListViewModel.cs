using ModulePerson.Business;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ModulePerson.ViewModels
{
    public class PersonListViewModel : BindableBase
    {
        private ObservableCollection<Person> _people;
        private readonly IRegionManager _regionManager;

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public ICommand PersonSelectedCommand { get; private set; }

        public PersonListViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();
        }

        private void PersonSelected(Person person)
        {
            var parameters = new NavigationParameters();
            parameters.Add("person", person);

            if (person != null)
                _regionManager.RequestNavigate("PersonDetailsRegion", "PersonDetail", parameters);
        }

        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = String.Format("First {0}", i),
                    LastName = String.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }
    }
}
