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
            //TestDeckConstructor();
            //TestDeckShuffle();
            //TestDeckDeal();

            Console.ReadLine();
        }

        static void TestYard()
        {
            Boneyard b = new Boneyard();
            b.BoneYard(6);
            Console.WriteLine("BoneYard(6) DominosRemaining " + b.DominosRemaining);
            Console.WriteLine("Testing IsEmpty, expecting false: " + b.IsEmpty.ToString);
            
        }


        

      
    }
}
