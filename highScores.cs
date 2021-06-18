using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace trickyTest2021
{
    public partial class Form1
    {


        public void updateHighScores(int score, string username)
        {
            homeLbl.Text = "High Scores";
            StreamWriter writer;
            StreamReader reader;

            string binPath = Application.StartupPath + @"\easyScores.txt";

            if (easy == true)
            {
                binPath = Application.StartupPath + @"\easyScores.txt";
            }
            else if (medium == true)
            {
                binPath = Application.StartupPath + @"\mediumScores.txt";
            }
            else if (hard == true)
            {
                binPath = Application.StartupPath + @"\hardScores.txt";
            }

            List<(string, int)> highScores = new List<(string, int)>();
            //writer = File.OpenText(binPath);
            string line = "";
            string[] values;
            string names = "";
            int scores = 0;
            int lowestScore = 0;
            int counter = 0;
            writer = File.AppendText(binPath);

            if (score != 0)
            {
                writer.WriteLine(username + "," + score.ToString());
            }
            writer.Close();
            reader = File.OpenText(binPath);

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                values = line.Split(',');
                names = values[0];
                scores = int.Parse(values[1]);
                highScores.Add((names, scores));

                if (score < lowestScore || counter == 0)
                {
                    lowestScore = score;
                }
                counter++;

            }
            reader.Close();

            highScores = highScores.OrderByDescending(x => x.Item2).Take(10).ToList();

            foreach (var (name, score2) in highScores)
            {
                listBoxHighScores.Items.Add(name.PadRight(10) + score2);
            }

            displayHighScores();

        }
        public void displayHighScores()
        {
            clearPanel();
            //panelGame.Visible = false;
            listBoxHighScores.Visible = true;
        }

    }
}
