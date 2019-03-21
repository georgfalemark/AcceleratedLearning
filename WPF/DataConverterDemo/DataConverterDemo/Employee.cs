using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataConverterDemo
{
    public class Employee : INotifyPropertyChanged
    {
        private DateTime _startDate;
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; OnProperyChanged(); } }

        private string name;
        public string Name { get { return name; } set { name = value; OnProperyChanged(); } }

        private string title;
        public string Title { get { return title; } set { title = value; OnProperyChanged(); } }

        public Employee(string name, string title, DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }


        //public static Employee GetEmployee()
        //{
        //    var emp = new Employee { Name = "Georg", Title = "Developer" };
        //    return emp;
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnProperyChanged(
            [CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }



    }
}
