using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        //member vars
        //constructor
        public Computer()
        {
            score = 0;
        }
        //methods
        public override Gesture Choice()
        {
            return this.gestures[new Random().Next(0,5)];
        }
    }
}
