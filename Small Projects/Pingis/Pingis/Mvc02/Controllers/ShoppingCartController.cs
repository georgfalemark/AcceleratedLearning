using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc02.Data;
using Mvc02.Models.Entities;
using Mvc02.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mvc02.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ShoppingCart _shoppingCartContext;

        public ShoppingCartController(ShoppingCart shoppingCart, ApplicationDbContext applicationDbContext)
        {
            _shoppingCartContext = shoppingCart;
            _context = applicationDbContext;
        }   

        //public ShoppingCartController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public ViewResult Index()
        {
            var items = _shoppingCartContext.GetShoppingCartItems();
            _shoppingCartContext.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartVm
            {
                ShoppingCart = _shoppingCartContext,
                ShoppingCartTotal = _shoppingCartContext.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public async Task<IActionResult> AddToShoppingCart(int productId)
        {
            var selectedProduct = _context.Product.FirstOrDefault(p => p.Id == productId);

            if (selectedProduct != null)
            {
                _shoppingCartContext.AddToCart(selectedProduct, 1);
            }
            return View(await _context.Product.ToListAsync());
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _context.Product.FirstOrDefault(p => p.Id == productId);

            if (selectedProduct != null)
            {
                _shoppingCartContext.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
