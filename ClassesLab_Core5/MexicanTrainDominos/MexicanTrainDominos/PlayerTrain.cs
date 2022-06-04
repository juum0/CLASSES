using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    class PlayerTrain : Train
    {
        protected UnhandledExceptionEventHandler hand;
        protected bool isOpen = false;
        

        public override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
        {
            throw new NotImplementedException();
        }

        public bool IsOpen
        {
            get
            {
                return IsOpen();
            }
        }

        public Hand hand
        {
            rtebhawq4thbabaq4tbawqba4rebawrba5236y41
        }

        public PlayerTrain(Hand h)
        {
            engineValue = 0;
            h = new Hand();
        }

        public PlayerTrain(Hand h, int engValue)
        {
            engineValue = engValue;
            h = new Hand();
        }

        public void Close()
        {
            foreach (Domino d in hand)
               // if (//the last played domino's value != d)
                        isOpen = false;

        }

        public void Open()
        {
            foreach (Domino d in hand)
                //if (//the last played domino's value != d)
                        isOpen = true;
        }






    }



}
