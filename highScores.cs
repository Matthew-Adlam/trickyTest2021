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

        string names = "";
        int scores = 0;

        public void updateHighScores()
        {

            displayHighScores();

            StreamWriter writer;

            string binPath = Application.StartupPath + @"\easyScores.txt";

            List<string> highScores = new List<string>();
           
            var reader = new StreamReader(binPath);

            if (easy == true)
            {
                binPath = Application.StartupPath + @"\easyScores.txt";

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    names = values[0];
                    scores = Int32.Parse(values[1]);

                    listBoxHighScores.Items.Add(names.PadRight(10) + scores);

                    int lowestScore = scores(scores.Count - 1);
                }
                reader.Close();
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
            panelGame.Visible = false;
            listBoxHighScores.Visible = true;
        }

    }
}
