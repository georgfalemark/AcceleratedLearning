using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        public string Name { get { return name; } set { name = value; OnProperyChanged(); } }

        private string title;
        public string Title { get { return title; } set { title = value; OnProperyChanged(); } }

        public static Employee GetEmployee()
        {
            var emp = new Employee { Name = "Georg", Title = "Developer" };
            return emp;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnProperyChanged(
            [CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee { Name = "Georg", Title = "Developpare" });
            employees.Add(new Employee { Name = "Olof", Title = "DevopsKing" });
            employees.Add(new Employee { Name = "Elin", Title = "Developper" });
            employees.Add(new Employee { Name = "Erik", Title = "Utvecklare" });
            employees.Add(new Employee { Name = "Oscarius", Title = "King" });
            employees.Add(new Employee { Name = "Bengt", Title = "Politiker" });
            return employees;
        }

    }
}
