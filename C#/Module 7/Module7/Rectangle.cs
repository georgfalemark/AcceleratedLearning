using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    public class Rectangle : Shape
    {

        public decimal longside { get; set; }
        public decimal shortside { get; set; }



        public override string ToString()
        {
            return $"I am a Rectangle with longside of {longside} and shortside of {shortside}";
        }


    }
}
