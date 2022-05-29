﻿using System;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();
        private static int genSuit = generator.Next(1,5);
        private static int genValue = generator.Next(1, 14);
        private int value;
        private int suit;
        public bool HasMatchingSuit(Card other)
        {
            if (this.suit == other.suit)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }

        public int Value
        {
            get
            {
                return Value;
            }

            set
            {
                if (value > 0 && value < 14)
                    Value = value;
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
            value = 1;
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
    }
}
