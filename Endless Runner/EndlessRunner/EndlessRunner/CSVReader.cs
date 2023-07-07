using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EndlessRunner
{
     class CSVReader : FileReader
    {

        public string filePath { get; set; }    

        List<Player> players = new List<Player>();
        List<string> lines = new List<string>();
        private List<string> OutContents = new List<string>();
        public override List<Player> GetAllPlayersFromFile()
        {
            lines = File.ReadAllLines(filePath).ToList();

            try
            {
                foreach (string line in lines)
                {
                    string[] items = line.Split(',');
                    Player player = new Player(items[0]);
                    players.Add(player);

                }
                return players;

            }
            catch (Exception ex)
            {
                return players;
            }
        }

        public void WriteAllPlayersToFile()
        {

            string OutFile = @"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\Score.txt";
            foreach (Player player in players)
            {
                OutContents.Add(player.playerScore.ToString());
                File.WriteAllText(OutFile, player.playerScore.ToString());

            }
            //Player tempPlayer = players[0];
            //OutContents.Add(tempPlayer.playerScore.ToString());
            //File.WriteAllLines(OutFile, OutContents);

        }
        public void AddPlayers(Player player)
        {
            players.Add(player);
        }

        public CSVReader(string _filePath)
        {
            filePath = _filePath;
        }
    }
}
