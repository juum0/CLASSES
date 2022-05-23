using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
   public class Boneyard
    {

        private List<Domino> listOfDominoes = new List<Domino>();

        public int DominosRemaining
        {
            get
            {
                return listOfDominoes.Count;
            }
        }

        public Domino this[int i]
        {
            get
            {
                return listOfDominoes[i];
            }

            set 
            {
                listOfDominoes[i] = value;
            }
        }

        public void BoneYard(int maxDots)
        {
            for (int side1 = 0; side1 <= maxDots; side1++)
                for (int side2 = side1; side2 <= maxDots; side2++)
                    listOfDominoes.Add(new Domino(side1, side2));
        }

        public Domino Draw()
        {
            if (IsEmpty() == false)
            {
                Domino d = listOfDominoes[0];
                listOfDominoes.Remove(d);
                return d;
            }
            return null;
        }

        public bool IsEmpty()
        {
            if (DominosRemaining <= 0)
                return true;
            else
                return false;
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < DominosRemaining; i++)
            {
                int rnd = r.Next(0, DominosRemaining);
                Domino d = listOfDominoes[rnd];
                listOfDominoes[rnd] = listOfDominoes[i];
                listOfDominoes[i] = d;
            }
        }

        public override string ToString()
        {
            return String.Format("BoneYard: {0}  Side 2: {1}", BoneYard, side2);
        }



    }
}
