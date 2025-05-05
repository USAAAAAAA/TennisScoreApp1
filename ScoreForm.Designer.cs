namespace TennisScoreApp
{
    partial class ScoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listRankings = new ListView();
            columnPlayerName = new ColumnHeader();
            columnScore = new ColumnHeader();
            listLatestGames = new ListView();
            columnFirstPlayer = new ColumnHeader();
            columnSecondPlayer = new ColumnHeader();
            columnWinner = new ColumnHeader();
            columnPlayerScore = new ColumnHeader();
            label4 = new Label();
            buttonAddGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 21);
            label1.Name = "label1";
            label1.Size = new Size(255, 54);
            label1.TabIndex = 0;
            label1.Text = "Tennis Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 1;
            label2.Text = "Ranking";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 341);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 2;
            label3.Text = "Latest Games";
            // 
            // listRankings
            // 
            listRankings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            listRankings.BackColor = Color.Salmon;
            listRankings.Columns.AddRange(new ColumnHeader[] { columnPlayerName, columnScore });
            listRankings.Location = new Point(12, 153);
            listRankings.Name = "listRankings";
            listRankings.Size = new Size(754, 146);
            listRankings.TabIndex = 3;
            listRankings.UseCompatibleStateImageBehavior = false;
            listRankings.View = View.Details;
            listRankings.MouseClick += listRankings_MouseClick;
            // 
            // columnPlayerName
            // 
            columnPlayerName.Text = "Player Name";
            columnPlayerName.Width = 200;
            // 
            // columnScore
            // 
            columnScore.Text = "Score";
            columnScore.Width = 200;
            // 
            // listLatestGames
            // 
            listLatestGames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listLatestGames.BackColor = Color.Salmon;
            listLatestGames.Columns.AddRange(new ColumnHeader[] { columnFirstPlayer, columnSecondPlayer, columnWinner, columnPlayerScore });
            listLatestGames.Location = new Point(12, 376);
            listLatestGames.Name = "listLatestGames";
            listLatestGames.Size = new Size(754, 156);
            listLatestGames.TabIndex = 4;
            listLatestGames.UseCompatibleStateImageBehavior = false;
            listLatestGames.View = View.Details;
            // 
            // columnFirstPlayer
            // 
            columnFirstPlayer.Text = "First Player";
            columnFirstPlayer.Width = 150;
            // 
            // columnSecondPlayer
            // 
            columnSecondPlayer.Text = "Second Player";
            columnSecondPlayer.Width = 150;
            // 
            // columnWinner
            // 
            columnWinner.Text = "Winner";
            columnWinner.Width = 150;
            // 
            // columnPlayerScore
            // 
            columnPlayerScore.Text = "Score";
            columnPlayerScore.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 302);
            label4.Name = "label4";
            label4.Size = new Size(557, 25);
            label4.TabIndex = 5;
            label4.Text = "*Click on player's name to see more information about their matches";
            // 
            // buttonAddGame
            // 
            buttonAddGame.BackColor = SystemColors.GradientActiveCaption;
            buttonAddGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddGame.Location = new Point(575, 321);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Size = new Size(191, 49);
            buttonAddGame.TabIndex = 6;
            buttonAddGame.Text = "Add New Game";
            buttonAddGame.UseVisualStyleBackColor = false;
            buttonAddGame.Click += buttonAddGame_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(778, 544);
            Controls.Add(buttonAddGame);
            Controls.Add(label4);
            Controls.Add(listLatestGames);
            Controls.Add(listRankings);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ScoreForm";
            Text = "Score Form";
            Load += ScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listRankings;
        private ListView listLatestGames;
        private Label label4;
        private ColumnHeader columnPlayerName;
        private ColumnHeader columnScore;
        private ColumnHeader columnFirstPlayer;
        private ColumnHeader columnSecondPlayer;
        private ColumnHeader columnWinner;
        private ColumnHeader columnPlayerScore;
        private Button buttonAddGame;
    }
}
