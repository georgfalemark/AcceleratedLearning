using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWithOneProject2
{
    public class DataAccess
    {
        private readonly FruitContext _context;

        public DataAccess()
        {
            _context = new FruitContext();
        }

        internal void AddCategoriesAndFruits()
        {
            //Skapar några fruktkategorier
            var fc1 = new FruitCategory { Name = "bär" };
            var fc2 = new FruitCategory { Name = "citrus" };
            var fc3 = new FruitCategory { Name = "Goe Frukter" };
            _context.FruitCategories.AddRange(fc1, fc2, fc3);


            //Skapar några korgar
            var b1 = new Basket { Name = "Goe korgen" };
            var b2 = new Basket { Name = "Äckle korgen" };

            var b3 = new Basket
            { Name = "FamiljeKorgen",
                FruitInBaskets = new List<FruitInBasket> {
                    new FruitInBasket { Fruit = new Fruit { Name = "Durian", Price = 999, Category = fc1 } },
                    new FruitInBasket { Fruit = new Fruit { Name = "Plommon", Price = 444, Category = fc1 } },
                    new FruitInBasket { Fruit = new Fruit { Name = "Riskakafrukten", Price = 9999, Category = fc1 } }, }
            };

            var b4 = new Basket
            { Name = "Göteborgskorgen",
                FruitInBaskets = new List<FruitInBasket> {
                    new FruitInBasket { Fruit = new Fruit { Name = "Fillidutt", Price = 10000, Category = new FruitCategory { Name = "Stenfrukter"} } },
                    new FruitInBasket { Fruit = new Fruit { Name = "Kexchoklad", Price = 20, Category = new FruitCategory { Name = "GöteborgsFrukter"} } },
                    new FruitInBasket { Fruit = new Fruit { Name = "Riskakafrukten", Price = 741, Category = fc3 } }, }
            };

            _context.Basket.AddRange(b1, b2, b3, b4);


            //Skapar några frukter
            var f1 = new Fruit { Name = "banan", Price = 500, Category = fc1 };
            var f2 = new Fruit { Name = "äpple", Price = 100, Category = fc2 };
            var f3 = new Fruit { Name = "citron", Price = 140, Category = fc2 };
            var f4 = new Fruit { Name = "kaktus", Price = 720, Category = fc2 };
            var f5 = new Fruit { Name = "Vindruvor", Price = 10000, Category = fc3 };
            var f6 = new Fruit { Name = "Ananas", Price = 10050, Category = fc3 };
            _context.Fruits.AddRange(f1, f2, f3, f4, f5, f6);



            //Fyller i många-till-många relation m.h.a. KORG + FRUKT
            var fib1 = new FruitInBasket { Fruit = f1, Basket = b1 };
            var fib2 = new FruitInBasket { Fruit = f2, Basket = b1 };
            var fib3 = new FruitInBasket { Fruit = f3, Basket = b1 };
            var fib4 = new FruitInBasket { Fruit = f4, Basket = b2 };
            _context.FruitInBasket.AddRange(fib1, fib2, fib3, fib4);


            _context.SaveChanges();
        }

        internal List<FruitInBasket> GetAllFruitsInBaskets(int basketId)
        {
            return _context.FruitInBasket.Where(b => b.BasketId == basketId).Include(f => f.Fruit).ToList();
        }

        internal List<Basket> GetAllBaskets()
        {
            return _context.Basket.ToList();
        }

        internal List<Fruit> GetFruitsByCategory(string x)
        {
            return _context.Fruits.Where(f => f.Category.Name == x).ToList();
        }

        internal List<Fruit> GetAll()
        {
            return _context.Fruits.Include(f => f.Category).ToList();
        }

        internal void ClearDatabase()
        {
            foreach (var category in _context.FruitCategories)
            {
                _context.Remove(category);
            }

            foreach (var fruit in _context.Fruits)
            {
                _context.Remove(fruit);
            }

            foreach (var basket in _context.Basket)
            {
                _context.Remove(basket);
            }

            _context.SaveChanges();
        }
    }
}