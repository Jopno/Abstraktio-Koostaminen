using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace FinnishLeagueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Sharks = new Company("Sharks", "San Jose");

            List<Player> players = new List<Player>();

            players.Add(new Player("Jorma", "Penttinen", "Defend", "R"));
            players.Add(new Player("Pena", "Matikainen", "Striker", "R"));
            players.Add(new Player("Jarkko", "Immonen", "GK", "L"));
            players.Add(new Player("Sami", "Lepistö", "Defend", "L"));


            foreach (Player player in players)
            {
                Sharks.playersInTeam.Add(player);
            }

            Console.WriteLine(Sharks.ToString());
            Sharks.GetPlayersInfo();
            Sharks.SaveData();


        }
    }
}
