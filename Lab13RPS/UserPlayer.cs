using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class UserPlayer: Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Validator.GetSelection();
        }
    }
}
