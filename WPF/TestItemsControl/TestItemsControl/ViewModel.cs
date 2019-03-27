using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestItemsControl
{
    public class ViewModel
    {

        BindableCollection<Person> Persons { get; set; }

        public ViewModel()
        {
            var x = new BindableCollection<Person>();
            x.Add(new Person { Name = "hsdahj", Age = 10 });
            x.Add(new Person { Name = "sdasd", Age = 88 });
            x.Add(new Person { Name = "rwerwer", Age = 12 });
            x.Add(new Person { Name = "köllll", Age = 20 });
            x.Add(new Person { Name = "tyu", Age = 44 });
            Persons = x;
        }
    }
}
