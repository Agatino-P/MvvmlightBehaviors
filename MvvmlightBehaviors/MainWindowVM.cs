using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace MvvmlightBehaviors
{

    public class Person : ObservableObject
    {
        private string _firstName;
        public string FirstName { get => _firstName; set => Set(() => FirstName, ref _firstName, value); }
    }

    public class MainWindowVM : ViewModelBase
    {
        private BindingList<Person> _persons = new BindingList<Person>();
        public BindingList<Person> Persons { get => _persons; set => Set(() => Persons, ref _persons, value); }
        public MainWindowVM()
        {
            loadData();
        }

    private void loadData()
    {
            Persons.Add(new Person() { FirstName = "NameA" });
            Persons.Add(new Person() { FirstName = "NameB" });
            Persons.Add(new Person() { FirstName = "NameC" });

        }

    }
}
