using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.Shuffle();
            d.Deal();
            
            
        }
    }
}
