using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayingCardGame
    {

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Spela ett parti");
                Console.WriteLine("[2] Visa spelreglerna");
                Console.WriteLine("[3] Visa Highscore");
                Console.WriteLine("[4] Avsluta spelet");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        PlayGame();
                        string goBack1 = Console.ReadLine();
                        break;
                    case "2":
                        PrintGameRules();
                        string goBack2 = Console.ReadLine();
                        break;
                    case "3":
                        ReadHighscore();
                        string goBack3 = Console.ReadLine();
                        break;
                    case "4":
                    default:
                        break;
                }
                if (menu == "4")
                {
                    break;
                }
            }
        }

        public void PlayGame()
        {
            Console.Clear();

            Console.WriteLine("Innan vi startar skulle jag vilja be dig att ange ditt namn");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            var d = new Deck();
            d.CreateDeckOfCards();

            Card hiddenCard = d.TakeOutFirstCard(false);
            Card visableCard = d.TakeOutFirstCard(true);

            Console.WriteLine();
            PrintCard(hiddenCard);
            Console.WriteLine();
            PrintCard(visableCard);
            Console.WriteLine();

            decimal valueHiddenCard = GiveCardValue(hiddenCard);
            decimal valueVisableCard = GiveCardValue(visableCard);

            Console.WriteLine("Gissa om DITT kort är högre eller lägre än det dolda kortet:");
            Console.WriteLine("Gör detta genom att skriva H/L");
            Console.WriteLine();
            Console.Write("H/L: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            decimal score = 0M;

            if (input == "H" || input == "h")
            {
                if (valueHiddenCard < valueVisableCard)
                {
                    score = valueVisableCard - valueHiddenCard;
                    Console.WriteLine($"Du vann och fick {score} poäng");
                }
                else if (valueHiddenCard > valueVisableCard)
                {
                    Console.WriteLine("Du förlorade");
                }
                else if (valueHiddenCard == valueVisableCard)
                {
                    Console.WriteLine("Oavgjort");
                }
            }
            else if (input == "L" || input == "l")
            {
                if (valueHiddenCard > valueVisableCard)
                {
                    score = valueHiddenCard - valueVisableCard;
                    Console.WriteLine($"Du vann och fick {score} poäng");
                }
                else if (valueHiddenCard < valueVisableCard)
                {
                    Console.WriteLine("Du förlorade");
                }
                else if (valueHiddenCard == valueVisableCard)
                {
                    Console.WriteLine("Oavgjort");
                }
            }

            if (score > 0)
            {
                File.AppendAllText(@"C:\Project\CardGame\highscore.txt", $"{score}\t{name}" + Environment.NewLine);
            }
        }

        public decimal GiveCardValue(Card c)
        {
            decimal firstValue = 0;
            switch (c.RankName())
            {
                case "Ace":
                    firstValue = 1;
                    break;
                case "2":
                    firstValue = 2;
                    break;
                case "3":
                    firstValue = 3;
                    break;
                case "4":
                    firstValue = 4;
                    break;
                case "5":
                    firstValue = 5;
                    break;
                case "6":
                    firstValue = 6;
                    break;
                case "7":
                    firstValue = 7;
                    break;
                case "8":
                    firstValue = 8;
                    break;
                case "9":
                    firstValue = 9;
                    break;
                case "10":
                    firstValue = 10;
                    break;
                case "Jack":
                    firstValue = 11;
                    break;
                case "Queen":
                    firstValue = 12;
                    break;
                case "King":
                    firstValue = 13;
                    break;
                default:
                    break;
            }

            decimal secondValue = 0;
            switch (c.SuitName())
            {
                case "Spades":
                    secondValue = 0.4M;
                    break;
                case "Hearts":
                    secondValue = 0.3M;
                    break;
                case "Diamonds":
                    secondValue = 0.2M;
                    break;
                case "Clubs":
                    secondValue = 0.1M;
                    break;
                default:
                    break;
            }
            decimal totalValue = firstValue + secondValue;
            return totalValue;
        }

        private static void PrintDeck(Deck d)
        {
            foreach (Card card in d.GetCards())
            {
                PrintCard(card);
            }
        }

        private static void PrintCard(Card c)
        {
            if (c.CardFace == true)
            {
                Console.WriteLine(c.RankName().PadRight(8) + c.SuitName());
            }
            else
            {
                Console.WriteLine("**HIDDEN CARD**");
            }
        }

        public void PrintGameRules()
        {
            Console.Clear();
            Console.WriteLine("Här kommer spelreglerna:");
            Console.WriteLine();
            Console.WriteLine("@ Ett kort är dolt");
            Console.WriteLine("@ Du får ditt kort");
            Console.WriteLine("@ Gissa om ditt kort är högre eller lägre än det dolda kortet");
        }

        public void ReadHighscore()
        {
            Console.Clear();
            string[] highScore = File.ReadAllLines(@"C:\Project\CardGame\highscore.txt");

            List<string[]> highScores = new List<string[]>();

            foreach (var score in highScore)
            {
                string[] splitted = score.Split('\t');
                highScores.Add(splitted);
            }

            highScores = highScores.OrderBy(x => decimal.Parse(x[0], System.Globalization.NumberStyles.Number)).ToList();
            highScores.Reverse();

            foreach (var score in highScores)
            {
                Console.WriteLine(string.Join('\t', score));
            }
        }
    }
}
