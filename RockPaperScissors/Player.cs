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
        public Gesture rock;
        public Gesture paper ;
        public Gesture scissors ;
        public Gesture lizard ;
        public Gesture spock ;
        public List<Gesture> gestures;
        //constructor
        public Player()
        {
            rock = new Gesture("Rock", new List<string> { "Paper", "Spock" });
            paper = new Gesture("Paper", new List<string> { "Scissors", "Lizard" });
            scissors = new Gesture("Scissors", new List<string> { "Rock", "Spock" });
            lizard = new Gesture("Lizard", new List<string> { "Rock", "Scissors" });
            spock = new Gesture("Spock", new List<string> { "Paper", "Lizard" });
            gestures = new List<Gesture> { rock, paper, scissors, lizard, spock };
        }
        //methods
        public abstract Gesture Choice();
    }
}
