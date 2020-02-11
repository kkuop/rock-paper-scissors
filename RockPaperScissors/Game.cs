using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public bool vsComputer = false;
        ConsoleKeyInfo userInput;
        Player playerOne = new Human();
        Player playerTwo;
        
        public void NewGame()
        {
            WhichGame();
            RunGame();
            

        }
        public void RunGame()
        {
            while (playerOne.score <2 && playerTwo.score < 2)
            {
                playerOne.Choice();
                if(playerOne.score == 2)
                {
                    break;
                }
                playerTwo.Choice();
                if(playerTwo.score == 2)
                {
                    break;
                }
            }
        }
        public void WhichGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("Would you like to play against the computer?\ny) Yes\nn) No");
            for (int i = 0; i < 100; i++)
            {
                userInput = Console.ReadKey();
                if (userInput.KeyChar == 'y')
                {
                    vsComputer = true;
                    playerTwo = new Computer();
                    break;
                }
                else if (userInput.KeyChar == 'n')
                {
                    vsComputer = false;
                    playerTwo = new Human();
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
