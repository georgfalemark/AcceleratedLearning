using MVC01.Models;
using System.Collections.Generic;

namespace MVC01.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int v);
        void AddProduct(Product product);
    }
}