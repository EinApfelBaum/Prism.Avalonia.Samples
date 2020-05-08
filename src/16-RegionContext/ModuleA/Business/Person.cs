using Prism.Mvvm;
using System;

namespace ModuleA.Business
{
    public class Person : BindableBase
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private DateTime _lastdate;
        public DateTime LastUpdated
        {
            get { return _lastdate; }
            set { SetProperty(ref _lastdate, value); }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
