using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
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
                Console.WriteLine("\n\nPlayer 1:");
                char playerOneChoice = playerOne.Choice();
                Console.WriteLine("\n\nPlayer 2:");
                char playerTwoChoice = playerTwo.Choice();


                if ((playerOneChoice == 'a' && playerTwoChoice == 'c') || (playerOneChoice == 'a' && playerTwoChoice == 'd'))
                {
                    playerOne.score++;
                    Console.WriteLine($"\n{playerOneChoice} beats {playerTwoChoice}");
                    
                }
                else if ((playerOneChoice == 'b' && playerTwoChoice == 'a') || (playerOneChoice == 'b' && playerTwoChoice == 'e'))
                {
                    playerOne.score++;
                    Console.WriteLine($"\n{playerOneChoice} beats {playerTwoChoice}");
                    

                }
                else if ((playerOneChoice == 'c' && playerTwoChoice == 'b') || (playerOneChoice == 'c' && playerTwoChoice == 'd'))
                {
                    playerOne.score++;
                    Console.WriteLine($"\n{playerOneChoice} beats {playerTwoChoice}");
                    

                }
                else if ((playerOneChoice == 'd' && playerTwoChoice == 'e') || (playerOneChoice == 'd' && playerTwoChoice == 'b'))
                {
                    playerOne.score++;
                    Console.WriteLine($"\n{playerOneChoice} beats {playerTwoChoice}");
                    

                }
                else if ((playerOneChoice == 'e' && playerTwoChoice == 'a') || (playerOneChoice == 'e' && playerTwoChoice == 'c'))
                {
                    playerOne.score++;
                    Console.WriteLine($"\n{playerOneChoice} beats {playerTwoChoice}");
                    

                }
                else if ((playerTwoChoice == 'a' && playerOneChoice == 'c') || (playerTwoChoice == 'a' && playerOneChoice == 'd')) 
                {
                    playerTwo.score++;
                    Console.WriteLine($"\n{playerTwoChoice} beats {playerOneChoice}");
                    

                }
                else if ((playerTwoChoice == 'b' && playerOneChoice == 'a') || (playerTwoChoice == 'b' && playerOneChoice == 'e'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"\n{playerTwoChoice} beats {playerOneChoice}");
                    

                }
                else if ((playerTwoChoice == 'c' && playerOneChoice == 'b') || (playerTwoChoice == 'c' && playerOneChoice == 'd'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"\n{playerTwoChoice} beats {playerOneChoice}");
                    

                }
                else if ((playerTwoChoice == 'd' && playerOneChoice == 'e') || (playerTwoChoice == 'd' && playerOneChoice == 'b'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"\n{playerTwoChoice} beats {playerOneChoice}");
                    

                }
                else if ((playerTwoChoice == 'e' && playerOneChoice == 'a') || (playerTwoChoice == 'e' && playerOneChoice == 'c'))
                {
                    playerTwo.score++;
                    Console.WriteLine($"\n{playerTwoChoice} beats {playerOneChoice}");
                    

                }
                else
                {
                    Console.WriteLine("\nI don't have a rule for that yet...");
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
                    playerTwo = new Computer();
                    break;
                }
                else if (userInput.KeyChar == 'n')
                {
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
