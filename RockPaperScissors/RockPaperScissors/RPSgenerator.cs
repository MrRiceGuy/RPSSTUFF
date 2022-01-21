using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RPSgenerator
    {
        static Random rand = new Random();
        int RPS = rand.Next(4);
    }
}
