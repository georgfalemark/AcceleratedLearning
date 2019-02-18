using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EfSamurai.Data;
using EfSamurai.Domain;


namespace EfSamurai.App
{
    public class DataAccess
    {
        private readonly SamuraiContext context;

        public DataAccess()
        {
            context = new SamuraiContext();
        }





        internal List<Samurai> GetAllSamuraisByName()
        {
            return context.Samurais.ToList();
        }

        internal List<Samurai> GetAllSamuraisByNameOrdered()
        {
            return context.Samurais.OrderBy(x => x.Name).ToList();
        }

        internal List<Samurai> GetAllSamuraisByIdDescending()
        {
            return context.Samurais.OrderByDescending(x => x.Id).ToList();
        }









        internal List<Samurai> GetSamuraiWithRealName()
        {
            return context.Samurais.Where()
        }








        internal void AddSamuraisIntoDatabase()
        {
            var s1 = new Samurai { Name = "Zelda", Age = 100, Email = "zelda@gmail.com" };
            var s2 = new Samurai { Name = "Link", Age = 98, Email = "Link@gmail.com" };
            var s3 = new Samurai { Name = "Pelle", Age = 55, Email = "Pelle@gmail.com" };
            var s4 = new Samurai { Name = "Mario", Age = 44, Email = "Mario@gmail.com" };
            var s5 = new Samurai { Name = "Lugi", Age = 12, Email = "Lugi@gmail.com" };
            var s6 = new Samurai { Name = "Anders", Age = 46, Email = "Anders@gmail.com" };
            var s7 = new Samurai { Name = "Lisa", Age = 74, Email = "Lisa@gmail.com" };
            var s8 = new Samurai { Name = "Klas", Age = 31, Email = "Klas@gmail.com" };
            var s9 = new Samurai { Name = "Anders", Age = 19, Email = "Anders@gmail.com" };
            var s10 = new Samurai { Name = "Stefan", Age = 19, Email = "Stefan@gmail.com" };
            var s11 = new Samurai { Name = "Georg", Age = 19, Email = "Georg@gmail.com" };
            var s12 = new Samurai { Name = "Niklas", Age = 19, Email = "Niklas@gmail.com" };
            var s13 = new Samurai { Name = "Oscar", Age = 19, Email = "Oscar@gmail.com" };
            var s14 = new Samurai { Name = "Samsam", Age = 19, Email = "Samsam@gmail.com" };
            var s15 = new Samurai { Name = "Sam", Age = 19, Email = "Sam@gmail.com" };
            var s16 = new Samurai { Name = "Rai", Age = 19, Email = "Rai@gmail.com" };

            context.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16);
            context.SaveChanges();
        }
        internal void AddSuperSamuraisIntoDatabase()
        {
            var sb = new SamuraiBattle { Battle = new Battle { Name = "Krig 1", Description = "Det var ett hårt krig", Brutal = true, Start = new DateTime(2001, 05, 22), End = new DateTime(2006, 05, 22), BattleLog = new BattleLog { Name = "Krigslogg 1", BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Kriget om vem som var bäst samsung/apple", Description = "folk bråkar" } } } }, Samurai = new Samurai { Name = "Lugi", Age = 12, Email = "Lugi@gmail.com", HairCuts = new HairCut { Name = "ShortHair" }, SecretIdentity = new SecretIdentity { RealName = "Klas-Göran" }, Quotes = new List<Quote> { new Quote { Name = "Livet är gött", PhilosophiLVL = 100, QuoteType = new QuoteType { Name = "SuperQuote!" } } } } };

            context.Add(sb);
            context.SaveChanges();
        }
        internal void AddBattlesIntoDatabase()
        {
            var bl1 = new BattleLog { Name = "Krigslogg 1", Battle = new Battle { Name = "Krig 1", Description = "Det var ett hårt krig", Brutal = true, Start = new DateTime(2001, 05, 22), End = new DateTime(2006, 05, 22)}, BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Kriget om vem som var bäst samsung/apple", Description = "folk bråkar"} } };
            var bl2 = new BattleLog { Name = "Krigslogg 2", Battle = new Battle { Name = "Krig 44", Description = "Det var ett gött krig", Brutal = false, Start = new DateTime(2008, 04, 22), End = new DateTime(2014, 07, 22) }, BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Techkriget", Description = "Vet inte" } } };
            var bl3 = new BattleLog { Name = "Krigslogg 3", Battle = new Battle { Name = "Krig 32", Description = "Det var som 10 hårda krig", Brutal = false, Start = new DateTime(2009, 03, 22), End = new DateTime(2011, 05, 22) }, BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Kriget om laddarna", Description = "Här Kriget finns för att folk bråkar" } } };
            var bl4 = new BattleLog { Name = "Krigslogg 4", Battle = new Battle { Name = "Krig 456", Description = "Kriget pågick länge", Brutal = true, Start = new DateTime(2010, 01, 26), End = new DateTime(2018, 12, 24) }, BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Kriget om Chocolatten", Description = "Här är det nått finns för att folk bråkar" } } };
            var bl5 = new BattleLog { Name = "Krigslogg 5", Battle = new Battle { Name = "Krig 76", Description = "Flera goa gubbar gick bort", Brutal = true, Start = new DateTime(1555, 08, 22), End = new DateTime(2006, 05, 22) }, BattleEvents = new List<BattleEvent> { new BattleEvent { Name = "Kriget om Göteborg", Description = "Här deltog många samurajer" } } };

            context.AddRange(bl1, bl2, bl3, bl4, bl5);
            context.SaveChanges();
        }


        internal void GoAndClearDatabase()
        {
            foreach (var item in context.BattleEvents)
                context.Remove(item);
            foreach (var item in context.BattleLogs)
                context.Remove(item);
            foreach (var item in context.Battles)
                context.Remove(item);
            foreach (var item in context.HairCuts)
                context.Remove(item);
            foreach (var item in context.Quotes)
                context.Remove(item);
            foreach (var item in context.QuoteTypes)
                context.Remove(item);
            foreach (var item in context.SamuraiBattles)
                context.Remove(item);
            foreach (var item in context.Samurais)
                context.Remove(item);
            foreach (var item in context.SecretIdentities)
                context.Remove(item);
        }
    }
}
