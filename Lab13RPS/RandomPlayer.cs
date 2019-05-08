using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RandomPlayer: Player
    {
        Random randomRoll = new Random();
       
        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)randomRoll.Next(0, 3);
        }
    }
}
