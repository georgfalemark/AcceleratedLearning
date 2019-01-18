using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    class FruitInBasket
    {
        public int FruitId { get; set; }
        public Fruit Fruit { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
