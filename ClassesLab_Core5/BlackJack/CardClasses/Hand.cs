using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Hand
    {
        protected List<Card> cards = new List<Card>();
        private Deck d;
        private int numCards;

        public Hand(Deck d, int numCards)
        {
            this.d = d;
            this.numCards = numCards;
        }

        public Hand()
        {
        }

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }

        public void Discard(int index)
        {
           cards.RemoveAt(index);
        }

        //public Card GetCard(int index)


        public bool HasCard(Card c)
        {
            return cards.Contains(c);
        }

        public bool HasCard(int value)
        {
            foreach (Card c in cards)
                if (c.Value == value)
                    return true;
            return false;
        }

        public bool HasCard(int value, int suit)
        {
            foreach (Card c in cards)
                if (c.Value == value && c.Suit == suit)
                    return true;
            return false;
        }

        public int IndexOf(Card c)
        {
            int i = 0;
            foreach (Card c1 in cards)

                if (cards[i] == c1)
                    return i;
                else
                    i++;
            return -1;
        }

        public int IndexOf(int value)
        {
            int i = 0;
            foreach (Card c in cards)
                if (cards[i].Value == value)
                    return i;
                else
                    i++;
            return -1;
        }

        public int IndexOf(int value, int suit)
        {
            int i = 0;
            foreach (Card c in cards)
                if (cards[i].Value == value && cards[i].Suit == suit)
                    return i;
                else
                    i++;
            return -1;
        }


    }
}
