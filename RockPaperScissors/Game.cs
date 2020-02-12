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
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                Console.WriteLine("\n\nPlayer 1:");
                char playerOneChoice = playerOne.Choice();
                Console.WriteLine("\n\nPlayer 2:");
                char playerTwoChoice = playerTwo.Choice();
                Console.WriteLine("");

                if (playerOneChoice == playerTwoChoice)
                {
                    Console.WriteLine("The round ended in a tie!");
                }
                else if ((playerOneChoice == 'a' && playerTwoChoice == 'c') || (playerOneChoice == 'a' && playerTwoChoice == 'd'))
                {
                    playerOne.score++;
                    if (playerTwoChoice == 'c')
                    {
                        Console.WriteLine("Rock beats Scissors!");
                    }
                    else
                    {
                        Console.WriteLine("Rock beats Lizard!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");
                    
                }
                else if ((playerOneChoice == 'b' && playerTwoChoice == 'a') || (playerOneChoice == 'b' && playerTwoChoice == 'e'))
                {
                    playerOne.score++;
                    if (playerTwoChoice == 'a')
                    {
                        Console.WriteLine("Paper beats Rock!");
                    }
                    else
                    {
                        Console.WriteLine("Paper beats Spock!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerOneChoice == 'c' && playerTwoChoice == 'b') || (playerOneChoice == 'c' && playerTwoChoice == 'd'))
                {
                    playerOne.score++;
                    if (playerTwoChoice == 'b')
                    {
                        Console.WriteLine("Scissors beats Paper!");
                    }
                    else
                    {
                        Console.WriteLine("Scissors beats Lizard!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerOneChoice == 'd' && playerTwoChoice == 'e') || (playerOneChoice == 'd' && playerTwoChoice == 'b'))
                {
                    playerOne.score++;
                    if (playerTwoChoice == 'e')
                    {
                        Console.WriteLine("Lizard beats Spock!");
                    }
                    else
                    {
                        Console.WriteLine("Lizard beats Paper!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerOneChoice == 'e' && playerTwoChoice == 'a') || (playerOneChoice == 'e' && playerTwoChoice == 'c'))
                {
                    playerOne.score++;
                    if (playerTwoChoice == 'a')
                    {
                        Console.WriteLine("Spock beats Rock!");
                    }
                    else
                    {
                        Console.WriteLine("Spock beats Scissors!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerTwoChoice == 'a' && playerOneChoice == 'c') || (playerTwoChoice == 'a' && playerOneChoice == 'd')) 
                {
                    playerTwo.score++;
                    if (playerOneChoice == 'c')
                    {
                        Console.WriteLine("Rock beats Scissors!");
                    }
                    else
                    {
                        Console.WriteLine("Rock beats Lizard!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerTwoChoice == 'b' && playerOneChoice == 'a') || (playerTwoChoice == 'b' && playerOneChoice == 'e'))
                {
                    playerTwo.score++;
                    if (playerOneChoice == 'a')
                    {
                        Console.WriteLine("Paper beats Rock!");
                    }
                    else
                    {
                        Console.WriteLine("Paper beats Spock!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerTwoChoice == 'c' && playerOneChoice == 'b') || (playerTwoChoice == 'c' && playerOneChoice == 'd'))
                {
                    playerTwo.score++;
                    if (playerOneChoice == 'b')
                    {
                        Console.WriteLine("Scissors beats Paper!");
                    }
                    else
                    {
                        Console.WriteLine("Scissors beats Lizard!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerTwoChoice == 'd' && playerOneChoice == 'e') || (playerTwoChoice == 'd' && playerOneChoice == 'b'))
                {
                    playerTwo.score++;
                    if (playerOneChoice == 'e')
                    {
                        Console.WriteLine("Lizard beats Spock!");
                    }
                    else
                    {
                        Console.WriteLine("Lizard beats Paper!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

                }
                else if ((playerTwoChoice == 'e' && playerOneChoice == 'a') || (playerTwoChoice == 'e' && playerOneChoice == 'c'))
                {
                    playerTwo.score++;
                    if (playerOneChoice == 'a')
                    {
                        Console.WriteLine("Spock beats Rock!");
                    }
                    else
                    {
                        Console.WriteLine("Spock beats Scissors!");
                    }
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");

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
            Console.WriteLine("The game will be a best of 3...");
            Console.WriteLine("\nWould you like to play against the computer?\ny) Yes\nn) No");
            for (int i = 0; i < 10; i++)
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
                }else if (i==9)
                {
                    Console.WriteLine("\n\nAt this point I'm going to assume you are a child and close the application...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nThat is not an option... try again!");
                }
            }
        }

        public void DetermineWinner()
        {
            if (playerOne.score > playerTwo.score)
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
