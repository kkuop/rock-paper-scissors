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
            DetermineWinner();

        }
        public void RunGame()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.Choice();

                playerTwo.Choice();


                if ((playerOne.Choice() == 'a' && playerTwo.Choice() == 'c') || (playerOne.Choice() == 'a' && playerTwo.Choice() == 'd'))
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.Choice()} beats {playerTwo.Choice()}");
                }
                else if ((playerOne.Choice() == 'b' && playerTwo.Choice() == 'a') || (playerOne.Choice() == 'b' && playerTwo.Choice() == 'e'))
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.Choice()} beats {playerTwo.Choice()}");
                }
                else if ((playerOne.Choice() == 'c' && playerTwo.Choice() == 'b') || (playerOne.Choice() == 'c' && playerTwo.Choice() == 'd'))
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.Choice()} beats {playerTwo.Choice()}");
                }
                else if ((playerOne.Choice() == 'd' && playerTwo.Choice() == 'e') || (playerOne.Choice() == 'd' && playerTwo.Choice() == 'b'))
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.Choice()} beats {playerTwo.Choice()}");
                }
                else if ((playerOne.Choice() == 'e' && playerTwo.Choice() == 'a') || (playerOne.Choice() == 'e' && playerTwo.Choice() == 'c'))
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.Choice()} beats {playerTwo.Choice()}");
                }
                else if ((playerTwo.Choice() == 'a' && playerOne.Choice() == 'c') || (playerTwo.Choice() == 'a' && playerOne.Choice() == 'd')) 
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.Choice()} beats {playerOne.Choice()}");
                }
                else if ((playerTwo.Choice() == 'b' && playerOne.Choice() == 'a') || (playerTwo.Choice() == 'b' && playerOne.Choice() == 'e'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.Choice()} beats {playerOne.Choice()}");
                }
                else if ((playerTwo.Choice() == 'c' && playerOne.Choice() == 'b') || (playerTwo.Choice() == 'c' && playerOne.Choice() == 'd'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.Choice()} beats {playerOne.Choice()}");
                }
                else if ((playerTwo.Choice() == 'd' && playerOne.Choice() == 'e') || (playerTwo.Choice() == 'd' && playerOne.Choice() == 'b'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.Choice()} beats {playerOne.Choice()}");
                }
                else if ((playerTwo.Choice() == 'e' && playerOne.Choice() == 'a') || (playerTwo.Choice() == 'e' && playerOne.Choice() == 'c'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.Choice()} beats {playerOne.Choice()}");
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
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

        public void DetermineWinner()
        {
            if (playerOne.score ==2)
            {
                Console.WriteLine("Player 1 is the winner!");
            }
            else
            {
                Console.WriteLine("Player 2 is the winner!");
            }
        }
    }
}
