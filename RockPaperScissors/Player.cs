using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        //member vars
        public Gesture gesture;
        public int score;
        //constructor
        
        //methods
        public virtual void Choice()
        {

        }
    }
}
