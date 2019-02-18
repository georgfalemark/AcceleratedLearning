using System;
using System.Collections.Generic;
using System.Text;
using EfSamurai.Data;
using EfSamurai.Domain;

namespace EfSamurai.App
{
    public class App
    {
        DataAccess dataAccess = new DataAccess();

        internal void Run()
        {
            ClearDatabase();
            AddSomeSamurais();
            AddSomeBattles();
            AddSuperSamurais();

            ListAllSamuraiName();
            ListAllSamuraiNamesOrdered();
            ListAllSamuraiByIdDescending();
            FindSamuraiWithRealName();



        }


        private void ListAllSamuraiName()
        {
            List<Samurai> list = dataAccess.GetAllSamuraisByName();

            Console.WriteLine("OSORTERAD LISTA");
            Console.WriteLine();
            Console.WriteLine("Name".PadRight(15) + "Age".PadRight(15) + "Email".PadRight(15));
            Console.WriteLine();
            foreach (var samurai in list)
            {
                Console.WriteLine(samurai.Name.PadRight(15) + samurai.Age.ToString().PadRight(15) + samurai.Email.PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        private void ListAllSamuraiNamesOrdered()
        {
            List<Samurai> list = dataAccess.GetAllSamuraisByNameOrdered();

            Console.WriteLine("SORTERAD LISTA");
            Console.WriteLine();
            Console.WriteLine("Name".PadRight(15) + "Age".PadRight(15) + "Email".PadRight(15));
            Console.WriteLine();
            foreach (var samurai in list)
            {
                Console.WriteLine(samurai.Name.PadRight(15) + samurai.Age.ToString().PadRight(15) + samurai.Email.PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        private void ListAllSamuraiByIdDescending()
        {
            List<Samurai> list = dataAccess.GetAllSamuraisByIdDescending();

            Console.WriteLine("BAKÅTVÄND SORTERAD LISTA EFTER ID");
            Console.WriteLine();
            Console.WriteLine("ID".PadRight(15) + "Name".PadRight(15) + "Age".PadRight(15) + "Email".PadRight(15));
            Console.WriteLine();
            foreach (var samurai in list)
            {
                Console.WriteLine(samurai.Id.ToString().PadRight(15) + samurai.Name.PadRight(15) + samurai.Age.ToString().PadRight(15) + samurai.Email.PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private void FindSamuraiWithRealName()
        {
            List<Samurai> list = dataAccess.GetSamuraiWithRealName();

            Console.WriteLine("SAMURAIEN MED ETT RIKTIGT NAMN ÄR:");
            Console.WriteLine();
            Console.WriteLine("ID".PadRight(15) + "Name".PadRight(15) + "Age".PadRight(15) + "Email".PadRight(15) + "Realname".PadRight(15));
            Console.WriteLine();
            foreach (var samurai in list)
            {
                Console.WriteLine(samurai.Id.ToString().PadRight(15) + samurai.Name.PadRight(15) + samurai.Age.ToString().PadRight(15) + samurai.Email.PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }













        private void ClearDatabase()
        {
            dataAccess.GoAndClearDatabase();
        }
        private void AddSomeSamurais()
        {
            dataAccess.AddSamuraisIntoDatabase();
        }
        private void AddSomeBattles()
        {
            dataAccess.AddBattlesIntoDatabase();
        }
        private void AddSuperSamurais()
        {
            dataAccess.AddSuperSamuraisIntoDatabase();
        }
    }
}
