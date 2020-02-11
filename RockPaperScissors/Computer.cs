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
        public Gesture listOfGestures = new Gesture(new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" });
        //constructor
        public Computer()
        {
            score = 0;
        }
        //methods
        public override void Choice()
        {
            //randomly determine choice
        }
    }
}
