using Microsoft.AspNetCore.Mvc.Rendering;
using MVC02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC02.ViewModels
{
    public class ReportListVM
    {
        public IEnumerable<SelectListItem> AllReports { get; set; }
        public Report Report { get; set; }
    }
}
