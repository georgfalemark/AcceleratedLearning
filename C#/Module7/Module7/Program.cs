using System;
using System.Collections.Generic;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapeList = new List<Shape>();

            while (true)
            {
                Console.Write("Select (T)ringle, (R)ectangle, (C)ircle or (D)one: ");

                string input = Console.ReadLine();

                if (input == "T")
                {
                    Console.Write("Enter base of triangle: ");
                    string trianglebase = Console.ReadLine();
                    decimal newtrianglebase = decimal.Parse(trianglebase);

                    Console.Write("Enter height of triangle: ");
                    string triangleheight = Console.ReadLine();
                    decimal newtriangleheight = decimal.Parse(triangleheight);

                    var t = new Triangle();
                    t.baselenght = newtrianglebase;
                    t.height = newtriangleheight;

                    shapeList.Add(t);
                }
                if (input == "R")
                {
                    Console.Write("Enter longside of rectangle: ");
                    string rectanglelongside = Console.ReadLine();
                    decimal newrectanglelongside = decimal.Parse(rectanglelongside);

                    Console.Write("Enter shortside of rectangle: ");
                    string rectangleshortside = Console.ReadLine();
                    decimal newrectangleshortside = decimal.Parse(rectangleshortside);

                    var r = new Rectangle();
                    r.longside = newrectanglelongside;
                    r.shortside = newrectangleshortside;

                    shapeList.Add(r);
                }
                if (input == "C")
                {
                    Console.Write("Enter radius of circle: ");
                    string circleradius = Console.ReadLine();
                    decimal newcircleradius = decimal.Parse(circleradius);

                    var c = new Circle();
                    c.radius = newcircleradius;

                    shapeList.Add(c);
                }
                if (input == "D")
                {
                    break;
                }
            }



            foreach (Shape Shape in shapeList)
            {
                Console.WriteLine(Shape);
            }
















            //AskForCircle();

            //AskForRectangle();

            //AskForTriangle();

            //AskForListOfShapes();

            //AskForNumber();

        }

        private static void AskForNumber()
        {





        }




        private static void AskForTriangle()
        {

            var Triangle = new Triangle
            {



            };





        }

        private static void AskForRectangle()
        {

            var Rectangle = new Rectangle
            {



         
            };




        }

        private static void AskForCircle()
        {

            var Circle = new Circle
            {




            };




        }

        private static void AskForListOfShapes()
        {










        }
    }
}
