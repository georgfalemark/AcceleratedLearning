using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; RaiseProperyChanged(); } }

        private string _title;
        public string Title { get { return _title; } set { _title = value; RaiseProperyChanged(); } }

        private bool _wasReelected;
        public bool WasReelected { get { return _wasReelected; } set { _wasReelected = value; RaiseProperyChanged(); } }

        private Party _party;
        public Party Party { get { return _party; } set { _party = value; RaiseProperyChanged(); } }

        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            employees.Add(new Employee { Name = "olof", Title = "Developpare", WasReelected = true, Party = Party.Democrat });
            employees.Add(new Employee { Name = "Georg", Title = "develup", WasReelected = true, Party = Party.Democrat });
            employees.Add(new Employee { Name = "Kattenjamas", Title = "president", WasReelected = false, Party = Party.Independant });
            employees.Add(new Employee { Name = "snus", Title = "ssdsd", WasReelected = false, Party = Party.Republican });
            employees.Add(new Employee { Name = "Elin", Title = "devopsare", WasReelected = true, Party = Party.Democrat });
            employees.Add(new Employee { Name = "Jonathan", Title = "utvecklare", WasReelected = true, Party = Party.Democrat });
            return employees;
        }


        private void RaiseProperyChanged([CallerMemberName] string caller = "" )
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum Party { Democrat, Independant, Republican }

}
