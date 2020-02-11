using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        //call a method or put logic here to get user input on whether the game should be human v human or human v computer
        public bool vsComputer = false;
        ConsoleKeyInfo userInput;
        
        public void NewGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("Would you like to play against the computer?\ny) Yes\nn) No");
            userInput = Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
            if (userInput.KeyChar == 'y')
            {
                vsComputer = true;
                    break;
            }
            else if (userInput.KeyChar == 'n')
            {
                vsComputer = false;
                    break;
            }
            else
            {
                Console.WriteLine("\nThat is not valid input... please try again!");
            }
            }
        }
    }
}
