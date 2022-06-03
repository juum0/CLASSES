using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardClasses
{
    public class BJHand : Hand
    {
        public BJHand() : base() { }

        public BJHand(Deck d, int numCards) : base(d, numCards) {}

        public bool HasAce
        {
            get
            {
                return HasCard(1);
            }
        }

        public int Score
        {
            get
            {
                int score = 0;
                foreach(Card c in cards)
                {
                    if (c.IsAce(c.Value) == true && score > 11)
                        score += 10;
                    else if (c.IsAce(c.Value) == true && score < 11)
                         score += 1;
                    else
                        score += c.Value;
                }
                return score;
            }
        }

        public bool IsBusted
        {
            get
            {
                if (Score > 21)
                    return true;
                else
                    return false;
            }
        }
        public override string ToString()
        {
            string output = "";
            foreach (Card c in cards)
                output += (c.ToString() + "\n");
            return output;
        }
    }
}
