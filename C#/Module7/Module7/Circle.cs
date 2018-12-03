using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    public class Circle : Shape
    {

        public decimal radius { get; set; }


        public override string ToString()
        {
            return $"I am a circle with radius = {radius}";
        }
    }
}
