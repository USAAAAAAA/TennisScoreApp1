namespace TennisScoreApp
{
    partial class NewGameForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textFirstPlayer = new TextBox();
            textSecondPlayer = new TextBox();
            numericFirstPoints = new NumericUpDown();
            numericSecondPoints = new NumericUpDown();
            buttonSave = new Button();
            errorProviderFirstPlayer = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            errorProviderSecondPlayer = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericFirstPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSecondPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondPlayer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 40);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 0;
            label1.Text = "First Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(459, 40);
            label2.Name = "label2";
            label2.Size = new Size(192, 38);
            label2.TabIndex = 1;
            label2.Text = "Second Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 238);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 2;
            label3.Text = "Points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(473, 238);
            label4.Name = "label4";
            label4.Size = new Size(92, 38);
            label4.TabIndex = 3;
            label4.Text = "Points";
            // 
            // textFirstPlayer
            // 
            textFirstPlayer.BackColor = Color.Salmon;
            textFirstPlayer.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textFirstPlayer.Location = new Point(89, 81);
            textFirstPlayer.Name = "textFirstPlayer";
            textFirstPlayer.Size = new Size(267, 50);
            textFirstPlayer.TabIndex = 4;
            textFirstPlayer.Validating += textFirstPlayer_Validating;
            // 
            // textSecondPlayer
            // 
            textSecondPlayer.BackColor = Color.Salmon;
            textSecondPlayer.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSecondPlayer.Location = new Point(459, 81);
            textSecondPlayer.Name = "textSecondPlayer";
            textSecondPlayer.Size = new Size(265, 50);
            textSecondPlayer.TabIndex = 5;
            textSecondPlayer.Validating += textFirstPlayer_Validating;
            // 
            // numericFirstPoints
            // 
            numericFirstPoints.BackColor = Color.Salmon;
            numericFirstPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericFirstPoints.Location = new Point(114, 279);
            numericFirstPoints.Name = "numericFirstPoints";
            numericFirstPoints.Size = new Size(61, 39);
            numericFirstPoints.TabIndex = 6;
            // 
            // numericSecondPoints
            // 
            numericSecondPoints.BackColor = Color.Salmon;
            numericSecondPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericSecondPoints.Location = new Point(484, 279);
            numericSecondPoints.Name = "numericSecondPoints";
            numericSecondPoints.Size = new Size(61, 39);
            numericSecondPoints.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.MenuHighlight;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(319, 363);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(143, 47);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // errorProviderFirstPlayer
            // 
            errorProviderFirstPlayer.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProviderSecondPlayer
            // 
            errorProviderSecondPlayer.ContainerControl = this;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(numericSecondPoints);
            Controls.Add(numericFirstPoints);
            Controls.Add(textSecondPlayer);
            Controls.Add(textFirstPlayer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericFirstPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSecondPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFirstPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSecondPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textFirstPlayer;
        private TextBox textSecondPlayer;
        private NumericUpDown numericFirstPoints;
        private NumericUpDown numericSecondPoints;
        private Button buttonSave;
        private ErrorProvider errorProviderFirstPlayer;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProviderSecondPlayer;
    }
}