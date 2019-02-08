using Microsoft.AspNetCore.Hosting;
using MVC01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVC01.Services
{
    public class ProductRepository : IProductRepository
    {
        private IHostingEnvironment _env;

        public ProductRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<Product> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "products.txt");

            string[] text = System.IO.File.ReadAllLines(filename);
            List<Product> productList = new List<Product>();

            foreach (var item in text)
            {
                string[] product = item.Split(',');

                var p = new Product
                {
                    Id = int.Parse(product[0]),
                    Name = product[1],
                    Description = product[2]
                };
                productList.Add(p);
            }

            return productList;
        }

        public Product GetById(int id)
        {
            return GetAll().Single(x => x.Id == id);


            //Gammal lösning:

            //string root = _env.ContentRootPath;
            //string filename = Path.Combine(root, "Data", "products.txt");

            //string[] text = System.IO.File.ReadAllLines(filename);

            //foreach (var item in text)
            //{
            //    string[] product = item.Split(',');

            //    if (int.Parse(product[0]) == v)
            //    {
            //        var p = new Product
            //        {
            //            Id = int.Parse(product[0]),
            //            Name = product[1],
            //            Description = product[2]
            //        };
            //        return p;
            //    }
            //}

            //throw new Exception();
        }

        public void AddProduct(Product product)
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "products.txt");

            IEnumerable<Product> productList = GetAll();

            int count = 1;
            int newId = 0;
            foreach (var item in productList)
            {
                if (count == productList.Count())
                    newId = item.Id + 1;
                count++;
            }

            string createText = $"{newId},{product.Name},{product.Description}" + Environment.NewLine;
            File.AppendAllText(filename, createText);
        }
    }
}
