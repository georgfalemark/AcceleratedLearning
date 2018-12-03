using System;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            SetZippyCode();
        }

        static public void SetZippyCode()
        {

            Console.Write("Zipcode: ");
            string zipcode = Console.ReadLine();

            var z1 = new Address();

            z1.SetZipCode(zipcode);

            Console.WriteLine("Postnumret är:" + z1.GetZipCode());

        }















        //var address = new Address
        //{
        //    Street = "Långa gatan",
        //    StreetNumber = " 13B",
        //    City = "Göteborg",
        //    ZipCode = 41118,

        //};

        //Console.WriteLine(address.FullStreet);





        //FJÖRDE HÄR

        //var Person = new Person
        //{
        //    FirstName = "Lisa",
        //    LastName = "Andersson",
        //    BirthDay = new DateTime(2018, 1, 1),
        //    Gender = PersonGender.Female,
        //    Sport = PersonFavoriteSport.Soccer
        //};

        //Console.WriteLine($"{Person.FirstName} is {Person.Gender}");
        //Console.WriteLine($"{Person.FirstName} like to play {Person.Sport}");
        //Console.WriteLine($"{Person.FirstName} don't like to play {Person.Sport}");


        //Console.WriteLine();
        //foreach (string item in Enum.GetNames(typeof(PersonFavoriteSport)))
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();
        //Console.Write("Enter a sport: ");
        //Console.ForegroundColor = ConsoleColor.Green;
        //string enterSport = Console.ReadLine();
        //Console.ForegroundColor = ConsoleColor.White;

        //if (Enum.TryParse(enterSport, true, out PersonFavoriteSport personFavoriteSport))
        //{
        //    Console.WriteLine($"Oh, I know {enterSport}");
        //}
        //else
        //{
        //    Console.WriteLine($"I don't know {enterSport}");
        //}




        //TREDJE HÄR

        //Cube mycube = new Cube(2, 3, 4);
        //Cube supercube = new Cube(100, 200, 300);

        //mycube.WriteVolume();
        //supercube.WriteVolume();


        //ANDRA HÄR

        //Circle bob = new Circle("Bob", 8);
        //Circle lisa = new Circle("Lisa", 30);

        //bob.SayHello();
        //lisa.SayHello();

        //Console.WriteLine();
        //Console.ForegroundColor = ConsoleColor.Green;

        //bob.WriteArea();
        //lisa.WriteArea();


        //FÖRSTA HÄR 

        //var c1 = new Car("grön", 1800);
        //var c2 = new Car();
        //var c3 = new Car();

        ////c1.SetColor("blå");
        ////c2.SetColor("röd");

        ////c1.SetWeight(500);
        ////c2.SetWeight(45);

        //Console.WriteLine("Färgen på bilen 'c1' är " + c1.Color + " och den väger " + c1.Weight);
        //Console.WriteLine("Färgen på bilen 'c1' är " + c2.Color + " och den väger " + c2.Weight);
        //Console.WriteLine("Färgen på bilen 'c1' är " + c3.Color + " och den väger " + c3.Weight);
    }
}  
