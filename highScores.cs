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

        /// <summary>
        /// this is the update high scores function, which updates the text file, and then displays the top 10 high scores for the selected difficulty
        /// </summary>
        /// <param name="score"> the users score </param>
        /// <param name="username"> the users name </param>
        public void updateHighScores(int score, string username)
        {
            // declares necessary variables, a reader and a writer
            homeLbl.Text = "High Scores";
            StreamWriter writer;
            StreamReader reader;

            string binPath = "";

            // selects correct text file based on difficulty
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

            // declare list of high scores
            List<(string, int)> highScores = new List<(string, int)>();

            // declares necessary variables to read the text file:
            //writer = File.OpenText(binPath);
            // each line of data
            string line = "";
            // each split, saved as an array
            string[] values;
            // names from the split
            string names = "";
            // scores from the split
            int scores = 0;
            // lowest score to compare to the users score
            int lowestScore = 0;
            // a counter
            int counter = 0;
            // appends text to file
            writer = File.AppendText(binPath);

            // if score is not 0, write it to text file
            if (score != 0)
            {
                writer.WriteLine(username + "," + score.ToString());
            }
            writer.Close();
            // read scores and names from file
            reader = File.OpenText(binPath);

            // while not end of file:
            while (!reader.EndOfStream)
            {
                // read the line, split it off a comma
                line = reader.ReadLine();
                values = line.Split(',');
                // saves values into names, and scores respectively
                names = values[0];
                scores = int.Parse(values[1]);
                // adds name and score to list
                highScores.Add((names, scores));

                // make it so it only enters once - fixes a bug
                if (score < lowestScore || counter == 0)
                {
                    lowestScore = score;
                }
                counter++;

            }
            reader.Close(); // close the reader

            // sets the highScores list to only contain the top 10 in that list
            highScores = highScores.OrderByDescending(x => x.Item2).Take(10).ToList();

            listBoxHighScores.Items.Clear(); // clear the listbox before inputting the new high scores

            foreach (var (name, score2) in highScores) // for each instance of a name with its corresponding score in high scores
            {
                listBoxHighScores.Items.Add(name.PadRight(10) + score2); // add to listbox
            }

            displayHighScores(); // call method

        }
        /// <summary>
        /// display the high scores
        /// </summary>
        public void displayHighScores()
        {
            clearPanel(); // clear the panel
            //panelGame.Visible = false;
            listBoxHighScores.Visible = true; // make listbox visible
            
        }

    }
}
