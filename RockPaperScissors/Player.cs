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
        public int score;
        public Gesture listOfGestures = new Gesture(new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" });
        //constructor

        //methods
        public abstract char Choice();
    }
}
