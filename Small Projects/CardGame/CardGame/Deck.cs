using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Deck
    {

        List<Card> cards = new List<Card>();

        public List<Card> GetCards()
        {
            return cards;
        }

        public int CountCards()
        {
            return cards.Count;
        }

        public void CreateDeckOfCards()
        {
            Random random = new Random();
            int count = 0;

            while (count < 52)
            {
                int randomRank = random.Next(0, 13);
                int randomSuit = random.Next(0, 4);

                var c = new Card();
                c.CardRank = randomRank;
                c.CardSuit = randomSuit;

                bool cardAlreadyAdded = false;

                foreach (var card in cards)
                {
                    if (c.CardRank == card.CardRank && c.CardSuit == card.CardSuit)
                    {
                        cardAlreadyAdded = true;
                    }
                }

                if (cardAlreadyAdded == false)
                {
                    cards.Add(c);
                    count++;
                }
            }
        }

        public Card TakeOutFirstCard(bool x)
        {
            if (cards == null || cards.Count == 0)
            {
                throw new ArgumentException();
            }

            Card firstCard = new Card();
            firstCard = cards[0];

            firstCard.CardFace = x;

            List<Card> modifiedList = new List<Card>();
            int count = 0;
            foreach (var card in cards)
            {
                if (count > 0)
                {
                    modifiedList.Add(card);
                }
                count++;
            }
            cards = modifiedList;

            return firstCard;
        }

        public void putCardLast(Card c)
        {
            cards.Add(c);
        }
    }
}
