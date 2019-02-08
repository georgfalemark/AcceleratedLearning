using Microsoft.AspNetCore.Mvc.Rendering;
using MVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC01.ViewModels
{
    public class ProductListVM
    {
        public IEnumerable<SelectListItem> AllProducts { get; set; }
        public Product Product { get; set; }
    }
}
