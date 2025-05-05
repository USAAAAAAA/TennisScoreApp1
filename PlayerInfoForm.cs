using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisScoreApp
{
    public partial class PlayerInfoForm : Form
    {
        public PlayerInfoForm(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            labelName.Text = playerName;

            // Setup columns for clarity (optional, but useful)
            ConfigureListView(listViewVictories);
            ConfigureListView(listViewLosses);
            ConfigureListView(listViewDraws);

            foreach (var game in games)
            {
                var firstPlayer = game.Key;
                foreach (var secondPlayer in game.Value)
                {
                    // Determine which side is the player
                    bool isFirstPlayer = firstPlayer.Item1 == playerName;
                    var playerScore = isFirstPlayer ? firstPlayer.Item2 : secondPlayer.Item2;
                    var opponentScore = isFirstPlayer ? secondPlayer.Item2 : firstPlayer.Item2;
                    var opponentName = isFirstPlayer ? secondPlayer.Item1 : firstPlayer.Item1;

                    // Create list item
                    var item = new ListViewItem(opponentName);
                    item.SubItems.Add(playerScore.ToString());
                    item.SubItems.Add(opponentScore.ToString());

                    if (playerScore > opponentScore)
                    {
                        listViewVictories.Items.Add(item);
                    }
                    else if (playerScore < opponentScore)
                    {
                        listViewLosses.Items.Add(item);
                    }
                    else
                    {
                        listViewDraws.Items.Add(item);
                    }
                }
            }
        }

        private void ConfigureListView(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Clear();
            listView.Columns.Add("Opponent", 100);
            listView.Columns.Add("Your Score", 70);
            listView.Columns.Add("Opponent Score", 100);
            listView.FullRowSelect = true;
            listView.GridLines = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
