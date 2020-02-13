using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        Player playerOne;
        ConsoleKeyInfo userInput;
        Player playerTwo;
        int bestOf;
        int firstToWins;
        bool vsComputer;
        
        public Game()
        {
            playerOne = new Human();
            vsComputer = false;
        }
        
        public void NewGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            BestOf();
            WhichGame();
            RunGame();
            DetermineWinner();

        }
        private void BestOf()
        {
            Console.WriteLine("Enter a number to play 'Best of'");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    bestOf = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("That was not a number... try again!");
                    BestOf();
                }
                if (i == 9)
                {
                    Console.WriteLine("\n\nAt this point I'm going to assume you are a child and close the application...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    
                }
                else if (bestOf % 2 == 0) 
                {
                    Console.WriteLine("Please enter an odd number!");
                }
                else
                {
                    firstToWins = (bestOf / 2) + 1;
                    break;
                }
            }
            
        }
        private void WhichGame()
        {
            
            Console.WriteLine($"\nThe game will be a best of {bestOf}...");
            Console.WriteLine("\nChoose a game mode:\na) Human vs Computer\nb) Human vs Human");
            for (int i = 0; i < 10; i++)
            {
                userInput = Console.ReadKey();
                if (userInput.KeyChar == 'a')
                {
                    vsComputer = true;
                    playerTwo = new Computer();
                    break;
                }
                else if (userInput.KeyChar == 'b')
                {
                    vsComputer = false;
                    playerTwo = new Human();
                    break;
                }
                else if (i == 9)
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
        private void RunGame()
        {
            while (playerOne.score < firstToWins && playerTwo.score < firstToWins)
            {
                Console.WriteLine("\n\nPlayer 1:");
                Gesture playerOneChoice = playerOne.Choice();
                Console.WriteLine("\n\nPlayer 2:");
                Gesture playerTwoChoice = playerTwo.Choice();
                Console.WriteLine("");
                if (vsComputer == true)
                {                    
                    Console.WriteLine($"The computer picks {playerTwoChoice.type}");
                }

                if (playerOneChoice == playerTwoChoice)
                {
                    Console.WriteLine("The round ended in a tie!");
                }
                else if (playerOneChoice.losesTo.Contains(playerTwoChoice.type))
                {
                    playerTwo.score++;
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");
                    
                }
                else
                {
                    playerOne.score++;
                    Console.WriteLine($"\nThe score is:\nPlayer 1: {playerOne.score}\nPlayer 2: {playerTwo.score}");
                }
            }
        }
        

        private void DetermineWinner()
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
