using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RockPlayer : Player  
    {
        public abstract RPS GenerateRPS()
        {
            RPS = new RPS(0);
            return RPS;
        }
    }
}
