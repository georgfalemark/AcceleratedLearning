using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public FruitCategory Category { get; set; }
    }

    public class FruitCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
