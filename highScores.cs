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

            StreamWriter writer;
            StreamReader reader;

            string binPath = Application.StartupPath + @"\easyScores.txt";

            List<string> highScores = new List<string>();
            //writer = File.OpenText(binPath);
            string line = "";
            string[] values;
            string names = "";
            int scores = 0;
            int lowestScore = 0;
            int counter = 0;


            if (easy == true)
            {
                writer = File.AppendText(binPath);

                writer.WriteLine(username + "," + score.ToString());

                writer.Close();
                reader = File.OpenText(binPath);

                binPath = Application.StartupPath + @"\easyScores.txt";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(',');
                    names = values[0];
                    scores = int.Parse(values[1]);

                    if(score < lowestScore || counter == 0)
                    {
                        lowestScore = score;
                    }
                    counter++;

                    listBoxHighScores.Items.Add(names.PadRight(10) + scores);
                }
                reader.Close();

                displayHighScores();
            }
            else if(medium == true)
            {

            }
            else if(hard == true)
            {

            }
        }
        public void displayHighScores()
        {
            clearPanel();
            //panelGame.Visible = false;
            listBoxHighScores.Visible = true;
        }

    }
}
