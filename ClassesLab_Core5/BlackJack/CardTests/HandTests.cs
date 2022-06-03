using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace CardTests
{
    class HandTests
    {

        static void Main(string[] args)
        {
            TestAddCard();
            TestDiscard();
            TestHasCard();
            TestHasCardValue();
            TestHasCardValueAndSuit();
            TestIndexOfCard();
            TestIndexOfCardValue();
            TestIndexOfCardValueAndSuit();

        }

        static void TestAddCard()
        {
            Card c = new Card();
            Hand h = new Hand();
            for (int i = 0; i < 4; i++)
            {
                h.AddCard(c);
                Console.WriteLine(h.ToString());
            }
        }

        static void TestDiscard()
        {
            Hand h = new Hand();
            Card c = new Card();
            for (int i = 0; i < 5; i++)
            {
                h.AddCard(c);
            }
            Console.WriteLine("expecting 4: " + h.NumCards);
            h.Discard(2);
            Console.WriteLine("expecting 3(?) " + h.NumCards);
        }

        static void TestHasCard()
        {
            Hand h = new Hand();
            Card a = new Card();
            Card b = new Card();
            Card c = new Card();
            h.AddCard(c);
            h.AddCard(a);
            h.AddCard(b);
            Console.WriteLine("Expecting true: " + h.HasCard(a).ToString());
        }

        static void TestHasCardValue()
        {
            Card a = new Card(2, 3);
            Card b = new Card(10, 2);
            Hand h = new Hand();
            h.AddCard(a);
            h.AddCard(b);
            Console.WriteLine("expecting true: " + h.HasCard(2).ToString());
            Console.WriteLine("expecting false: " + h.HasCard(5).ToString());
        }

        static void TestHasCardValueAndSuit()
        {
            Card a = new Card(2, 3);
            Card b = new Card(10, 2);
            Hand h = new Hand();
            h.AddCard(a);
            h.AddCard(b);
            Console.WriteLine("expecting true: " + h.HasCard(2, 3).ToString());
            Console.WriteLine("expecting false: " + h.HasCard(5, 1).ToString());
        }

        static void TestIndexOfCard()
        {
            Hand h = new Hand();
            Card a = new Card();
            Card b = new Card();
            Card c = new Card();
            h.AddCard(c);
            h.AddCard(a);
            h.AddCard(b);
            Console.WriteLine("Expecting 0: " + h.IndexOf(c).ToString());
            Console.WriteLine("Expecting 1: " + h.IndexOf(a).ToString());
            Console.WriteLine("Expecting 2: " + h.IndexOf(b).ToString());
        }

        static void TestIndexOfCardValue()
        {
            Card a = new Card(2, 3);
            Card b = new Card(10, 2);
            Card c = new Card(5, 1);
            Hand h = new Hand();
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            Console.WriteLine("expecting 0: " + h.HasCard(2).ToString());
            Console.WriteLine("expecting 2: " + h.HasCard(5).ToString());
        }

        static void TestIndexOfCardValueAndSuit()
        {
            Card a = new Card(2, 3);
            Card b = new Card(10, 2);
            Card c = new Card(5, 1);
            Hand h = new Hand();
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            Console.WriteLine("expecting 0: " + h.HasCard(2, 3).ToString());
            Console.WriteLine("expecting 2: " + h.HasCard(5, 1).ToString());
        }
    }
}

