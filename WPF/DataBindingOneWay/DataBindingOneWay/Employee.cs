using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingOneWay
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
    }
}
