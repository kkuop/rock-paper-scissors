using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        //member vars
        
        
        //constructor
        public Human()
        {
            score = 0;
        }
        //methods
        public override Gesture Choice()
        {
            ConsoleKeyInfo userInput;
            Console.WriteLine($"What is your choice?\na){this.rock.type}\nb){this.paper.type}\nc){this.scissors.type}\nd){this.lizard.type}\ne){this.spock.type}");
            userInput = Console.ReadKey();
            while (userInput.KeyChar != 'a' && userInput.KeyChar != 'b' && userInput.KeyChar != 'c' && userInput.KeyChar != 'd' && userInput.KeyChar != 'e') 
            {
                Console.WriteLine("\nThat is not an option... Try again.");
                userInput = Console.ReadKey();
                

            }
            if(userInput.KeyChar == 'a')
            {
                return this.rock;
            }
            else if(userInput.KeyChar =='b')
            {
                return this.paper;
            }
            else if(userInput.KeyChar == 'c')
            {
                return this.scissors;
            }
            else if(userInput.KeyChar == 'd')
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
