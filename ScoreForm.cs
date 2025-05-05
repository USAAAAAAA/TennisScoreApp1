namespace TennisScoreApp
{
    public partial class ScoreForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new Dictionary<string, int>()
        {
            { "Player 1", 0 },
            { "Player 2", 6 },
        };
        private static Dictionary<(string, int), List<(string, int)>> games = new Dictionary<(string, int), List<(string, int)>>()
        {
            { ("Player 1", 0), new List<(string, int)>() { ("Player 2", 6) } },
            { ("Player 1", 6), new List<(string, int)>() { ("Player 2", 0) } }
        };

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            CalculatePointsFromGames();
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listRankings.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(p => p.Value))
            {
                ListViewItem item = new ListViewItem(player.Key);
                item.SubItems.Add(player.Value.ToString());
                listRankings.Items.Add(item);
            }
        }

        private void FillLatestGamesListView()
        {
            listLatestGames.Items.Clear();
            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);
            string score = $"{firstPlayer.Item2} - {secondPlayer.Item2}";

            ListViewItem item = new ListViewItem(firstPlayer.Item1); // First Player
            item.SubItems.Add(secondPlayer.Item1);                   // Second Player
            item.SubItems.Add(winner);                               // Winner
            item.SubItems.Add(score);                                // Score

            listLatestGames.Items.Add(item);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }

            return "Draw";
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) FirstPlayer, (string, int) SecondPlayer)
        {
            FillGamesData(FirstPlayer, SecondPlayer);
            FillPlayerWithPoints(FirstPlayer, SecondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (!games.ContainsKey(firstPlayer))
            {
                games.Add(firstPlayer, new List<(string, int)>() { secondPlayer });
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)>() { secondPlayer });
            }
        }

        private void FillPlayerWithPoints((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (!playersWithPoints.ContainsKey(firstPlayer.Item1))
            {
                playersWithPoints.Add(firstPlayer.Item1, firstPlayer.Item2);
            }
            else
            {
                playersWithPoints[firstPlayer.Item1] += firstPlayer.Item2;
            }
            if (!playersWithPoints.ContainsKey(secondPlayer.Item1))
            {
                playersWithPoints.Add(secondPlayer.Item1, secondPlayer.Item2);
            }
            else
            {
                playersWithPoints[secondPlayer.Item1] += secondPlayer.Item2;
            }
        }





        private void ViewProfileButton_Click(object sender, EventArgs e)
        {






        }

        private void listRankings_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedRow = listRankings.SelectedItems[0];
            var playerCell = selectedRow.SubItems[0];
            string playerName = playerCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
        {
            return games
                .Where(x => x.Key.Item1 == playerName || x.Value.Any(y => y.Item1 == playerName))
                .ToDictionary(
                    x => x.Key,
                    x => x.Value
                        .Where(y => y.Item1 == playerName || x.Key.Item1 == playerName)
                        .ToList()
                );
        }

        private void CalculatePointsFromGames()
        {
            playersWithPoints.Clear();

            foreach (var game in games)
            {
                var firstPlayer = game.Key;
                foreach (var secondPlayer in game.Value)
                {
                    // Add first player's score
                    if (!playersWithPoints.ContainsKey(firstPlayer.Item1))
                        playersWithPoints[firstPlayer.Item1] = 0;
                    playersWithPoints[firstPlayer.Item1] += firstPlayer.Item2;

                    // Add second player's score
                    if (!playersWithPoints.ContainsKey(secondPlayer.Item1))
                        playersWithPoints[secondPlayer.Item1] = 0;
                    playersWithPoints[secondPlayer.Item1] += secondPlayer.Item2;
                }
            }
        }
    }
}

