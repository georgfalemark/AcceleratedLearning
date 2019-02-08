using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC01.Models;
using MVC01.Services;
using MVC01.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC01.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ListAll()
        {
            IEnumerable<Product> allProducts = _repo.GetAll();
            return View(allProducts);
        }

        public IActionResult ProductIndex()
        {
            IEnumerable<Product> allProducts = _repo.GetAll();

            var vm = new ProductListVM();
            var list = new List<SelectListItem>();

            foreach (var item in allProducts)
            {
                var sl = new SelectListItem { Text = item.Name, Value = item.Id.ToString() };
                list.Add(sl);
            }
            vm.AllProducts = list;

            return View(vm);

        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            _repo.AddProduct(p);
            return View(p);
        }

        public IActionResult Testy()
        {
            return View();
        }

        public IActionResult Nasty()
        {
            return View();
        }

        public IActionResult GetById(int Id)
        {
            Product x = _repo.GetById(Id);
            return View(x);
        }








    }
}
