using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    public class Triangle : Shape
    {

        public decimal baselenght { get; set; }
        public decimal height { get; set; }


        public override string ToString()
        {
            return $"I am a triangle with baselenght = {baselenght} & height = {height}";
        }
    }
}
