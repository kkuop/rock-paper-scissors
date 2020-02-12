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
        public override char Choice()
        {
            ConsoleKeyInfo userInput;
            Console.WriteLine($"What is your choice?\na){listOfGestures.listOfGestures[0]}\nb){listOfGestures.listOfGestures[1]}\nc){listOfGestures.listOfGestures[2]}\nd){listOfGestures.listOfGestures[3]}\ne){listOfGestures.listOfGestures[4]}");
            do
            {
                userInput = Console.ReadKey();
                return userInput.KeyChar;

            } while (userInput.KeyChar != 'a'||userInput.KeyChar != 'b'||userInput.KeyChar != 'c' || userInput.KeyChar != 'd' || userInput.KeyChar != 'e');
            
        }
    }
}
