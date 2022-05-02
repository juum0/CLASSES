using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    static void TestHasMatching()
    {
        Card c1 = new Card(1, 2);
        Card c2 = new Card(1, 3);
        Console.WriteLine("matching suit test. Expecting false:" + c1.HasMatchingSuit(c2));
    }
}
