using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FinnishLeagueApp
{
    class Company
    {
        private string Name { get; set; }
        private string City { get; set; }
        public List<Player> playersInTeam = new List<Player>();
        private Stream writeMultipleStream;

        public Company(string name, string city)
        {
            Name = name;
            City = city;
        }

        public void GetPlayersInfo()
        {
            foreach (Player player in playersInTeam)
            {
                Console.WriteLine(player.ToString());
            }
        }

        public void SaveData()
        {
            string path = @"D:\kansio\";
            // create a file for players
            Stream writeMultipleStream = new FileStream("Players.bin",FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            // write players array to disk
            formatter.Serialize(writeMultipleStream, playersInTeam);
            // close file
            writeMultipleStream.Close();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Company name: " + Name + " City: " + City);
            }
        }


        public override string ToString()
        {
            return " Company name: " + Name + " City: " + City;
        }
    }
}
