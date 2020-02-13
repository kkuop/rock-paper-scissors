using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Gesture
    {
        //member vars
        public string type;
        public List<string> losesTo;
        //constructor
        public Gesture(string type, List<string> losesTo)
        {
            this.type = type;
            this.losesTo = losesTo;
        }
        //methods
    }
}
