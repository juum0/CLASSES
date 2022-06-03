using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DominoClasses;

namespace BoneyardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestYard();
           // TestBoneyardDraw();
          //  TestBoneyardIsEmpty();
//TestBoneyardShuffle();
          //  TestSort();
        }

        static void TestSort()
        {
            Boneyard b = new Boneyard();
            b.Shuffle();
            Console.WriteLine(b);
            b.Sort();
            Console.WriteLine(b);
        }

        static void TestYard()
        {
            Boneyard b = new Boneyard();
            b.BoneYard(6);
            Console.WriteLine("BoneYard(6) DominosRemaining " + b.DominosRemaining);
            Console.WriteLine();
        }

        static void TestBoneyardDraw()
        {
            Boneyard b = new Boneyard();
            Console.WriteLine("Testing Draw. current domino count should be 0: " + b.DominosRemaining);
            for (int i = 0; i < 5; i++)
                b.Draw();
            Console.WriteLine("Dominos drawn: 4 count reads: " + b.DominosRemaining);
            Console.WriteLine();
        }

        static void TestBoneyardIsEmpty()
        {
            Boneyard b = new Boneyard();
            Boneyard y = new Boneyard();
            b.BoneYard(6);
            Console.WriteLine("Testing IsEmpty. Expecting false:" + b.IsEmpty());
            Console.WriteLine("Expecting true: " + y.IsEmpty());
            Console.WriteLine();
        }

        static void TestBoneyardShuffle()
        {
            Boneyard b = new Boneyard();
            b.BoneYard(6);
            Console.WriteLine("Testing shuffle. Unshuffled: " + b.ToString());
            b.Shuffle();
            Console.WriteLine("Shuffled: " + b.ToString());
            Console.WriteLine();
        }
    }
}
