using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace CardClasses
{
    public class Hand : IEnumerable
    {
        protected List<Card> cards = new List<Card>();
        protected Deck d;
        protected int numCards;

        //FINAL QUESTION 4
        public void Iterate(Hand h)
        {
            foreach (Card c in h)
            {
                Console.WriteLine(c.ToString());
            }
        }

        // QUESTION 4

        public List<Card> Sort(List<Card> list)
        {
            Random val = new Random();
            Card temp = new Card();
            Card a = new Card();
            Card b = new Card();

            for (int i = 1; i > list.Count + 1; i++)
            { 
                if (!(list[0].Value > list[i].Value))
                {
                    foreach (Card c in list)
                        if (a.Value > b.Value)
                        {
                            temp = list[0];
                            list.Insert(0, a);
                            list.Insert(1, temp);
                        }
                        else if (a.Value < b.Value)
                        {
                            temp = list[0];
                            list.Insert(0, b);
                            list.Insert(1, temp);
                        }
                        else if (a.Value == b.Value) ;
                        else
                            throw new Exception("error");
                }
            }
            return list;
        }



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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
