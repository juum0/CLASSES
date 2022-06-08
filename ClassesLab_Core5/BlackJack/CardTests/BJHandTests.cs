using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace CardTests
{
    class BJHandTests
    {
       // static void Main(string[] args)
      //  {
       //     TestHasAce();
       // }

        static void TestHasAce()
        {
            BJHand h = new BJHand();
            Card a = new Card(1, 2);
            h.AddCard(a);
            Console.WriteLine("Expecting true: " + h.HasAce.ToString());
        }

        static void TestScore()
        {
            BJHand h = new BJHand();
            Card a = new Card(2, 3);
            Card b = new Card(5, 2);
            Card c = new Card(10, 4);
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            Console.WriteLine("Expecting 17: " + h.Score.ToString());
        }

        static void TestIsBusted()
        {
            BJHand h = new BJHand();
            Card a = new Card(10, 3);
            Card b = new Card(12, 2);
            Card c = new Card(11, 4);
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            Console.WriteLine("Expecting true: " + h.IsBusted.ToString());
        }
    }
}
