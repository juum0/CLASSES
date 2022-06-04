using DominoClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanTrainDominos
{
    public class MexicanTrain : Train
    {
        static void Main(string[] args)
        {
        }

        public override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
        {
            throw new NotImplementedException();
        }

        public MexicanTrain()
        {
            engineValue = 0;
            dominos = new List<Domino>();
        }

        public MexicanTrain(int engValue)
        {
            engineValue = engValue;
            dominos = new List<Domino>();
        }
    }
}
