using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    class Basket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FruitInBasket> FruitInBaskets { get; set; }
    }
}
