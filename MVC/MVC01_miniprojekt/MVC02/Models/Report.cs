using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC02.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Restaurant { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
