using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card

    {
        public int CardSuit { get; set; }
        public int CardRank { get; set; }
        public bool CardFace { get; set; }

        public string SuitName()
        {
            var suitNames = new List<string> { "Spades", "Hearts", "Diamonds", "Clubs" };
            return suitNames[CardSuit];
        }

        public string RankName()
        {
            var rankName = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            return rankName[CardRank];
        }
    }
}
