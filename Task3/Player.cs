using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishLeagueApp
{
    class Player
    {
        private string FirstName { get; set; }
        private string Lastname { get; set; }
        private string Position { get; set; }
        private string Handedness { get; set; }

        public Player (string firstName, string lastName, string position, string handedness)
        {
            FirstName = firstName;
            Lastname = Lastname;
            Position = position;
            Handedness = handedness;
        }

        public override string ToString()
        {
            return FirstName + "" + Lastname + "Position: " + Position + "Handedness" + Handedness; 
        }
    }
}
