namespace TennisScoreApp
{
    partial class PlayerInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraws = new Label();
            listViewVictories = new ListView();
            listViewLosses = new ListView();
            listViewDraws = new ListView();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(249, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(265, 54);
            labelName.TabIndex = 0;
            labelName.Text = "Player Name";
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelVictories.Location = new Point(12, 132);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(105, 32);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLosses.Location = new Point(364, 131);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(82, 32);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraws
            // 
            labelDraws.AutoSize = true;
            labelDraws.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDraws.Location = new Point(722, 131);
            labelDraws.Name = "labelDraws";
            labelDraws.Size = new Size(78, 32);
            labelDraws.TabIndex = 3;
            labelDraws.Text = "Draws";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = SystemColors.ActiveCaption;
            listViewVictories.Location = new Point(364, 168);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(336, 335);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = SystemColors.ActiveCaption;
            listViewLosses.Location = new Point(722, 166);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(336, 336);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDraws
            // 
            listViewDraws.BackColor = SystemColors.ActiveCaption;
            listViewDraws.Location = new Point(12, 168);
            listViewDraws.Name = "listViewDraws";
            listViewDraws.Size = new Size(336, 335);
            listViewDraws.TabIndex = 6;
            listViewDraws.UseCompatibleStateImageBehavior = false;
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1075, 517);
            Controls.Add(listViewDraws);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraws);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelName);
            Name = "PlayerInfoForm";
            Text = "Player Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraws;
        private ListView listViewVictories;
        private ListView listViewLosses;
        private ListView listViewDraws;
    }
}