using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class Card : IComparable
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();
        private static int genSuit = generator.Next(1,5);
        private static int genValue = generator.Next(1, 14);
        protected int vaLue;
        private int suit;

        // FINAL QUESTION 3 I can't get this to run ANYWHERE(I have tried multiple times, places, etc) but it should work.
        public void Sort(List<Card> list)
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
        }

        static void TestSort()
        {
            Hand h = new Hand();
            List<Card> list = new List<Card>();
            Random val = new Random();
            for (int i = 0; i < 6; i++)
            {
                Card c = new Card(val.Next(0, 15), val.Next(0, 5));
                list.Add(c);
            }
            h.Sort(list);
        }


        //






        public bool HasMatchingSuit(Card other)
        {
            if (this.suit == other.suit)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return values[vaLue] + " of " + suits[suit];
        }

        public int Value
        {
            get
            {
                return vaLue;
            }

            set
            {
                if (value > 0 && value < 14)
                    vaLue = value;
                else
                    throw new ArgumentException("value must be between 1 and 13");
            }
        }

        public int Suit
        {
            get
            {
                return Suit;
            }

            set
            {
                if (value > 0 && value < 5)
                    Suit = value;
                else
                    throw new ArgumentException("value must be between 1 and 5");
            }
        }

        public Card()
        {
            suit = 1;
            vaLue = 1;
        }

        public Card(int v, int s)
        {
            s = genSuit;
            v = genValue;  
        }
        public bool IsAce(int value)
        {
            if (value == 1)
                return true;
            else
                return false;
        }

        public bool IsBlack(int suit)
        {
            if (suit == 1 || suit == 2)
                return true;
            else
                return false;
        }

        public bool IsRed(int suit)
        {
            if (suit == 3 || suit == 4)
                return true;
            else
                return false;
        }

        public bool IsClub(int suit)
        {
            if (suit == 1)
                return true;
            else
                return false;
        }

        public bool IsSpade(int suit)
        {
            if (suit == 2)
                return true;
            else
                return false;
        }

        public bool IsDiamond(int suit)
        {
            if (suit == 3)
                return true;
            else
                return false;
        }

        public bool IsHeart(int suit)
        {
            if (suit == 4)
                return true;
            else
                return false;
        }

        public bool IsFace(int value)
        {
            if (value >= 10)
                return true;
            else
                return false;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
