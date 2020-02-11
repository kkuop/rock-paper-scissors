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
        public override char Choice()
        {
            int randomNumber = new Random().Next(1, 50);
            if (randomNumber <= 10)
            {
                return 'a';
            }
            else if(randomNumber >10 && randomNumber <=20)
            {
                return 'b';
            }
            else if (randomNumber >20 && randomNumber <=30)
            {
                return 'c';
            }
            else if (randomNumber >30 && randomNumber <=40)
            {
                return 'd';
            }
            else if (randomNumber >40 && randomNumber <=50)
            {
                return 'e';
            }
            else
            {
                return 'z';
            }
        }
    }
}
