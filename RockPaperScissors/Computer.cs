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
            int randomNumber = new Random().Next(1, 50);
            if (randomNumber <= 10)
            {
                return this.rock;
            }
            else if(randomNumber >10 && randomNumber <=20)
            {
                return this.paper;
            }
            else if (randomNumber >20 && randomNumber <=30)
            {
                return this.scissors;
            }
            else if (randomNumber >30 && randomNumber <=40)
            {
                return this.lizard;
            }
            else 
            {
                return this.spock;
            }
            
        }
    }
}
