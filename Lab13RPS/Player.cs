using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    abstract class Player
    {
        private string name; //data members
        private Roshambo pick;

        public string Name //properties
        {
            set { name = value; }
            get { return name; }
        }

        public Roshambo Pick
        {
            set { pick = value; }
            get { return pick; }
        }

        public Player(string _name, Roshambo _pick) //constructor
        {
            name = _name;
            pick = _pick;
        }

        public Player() {}

        public abstract Roshambo GenerateRoshambo(); //empty becsuse abstract
       
    }
}
