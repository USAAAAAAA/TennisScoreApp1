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
    public partial class NewGameForm : Form
    {
        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FirstPlayer = (textFirstPlayer.Text, (int)numericFirstPoints.Value);
            SecondPlayer = (textSecondPlayer.Text, (int)numericSecondPoints.Value);
            Close();

            this.DialogResult = DialogResult.OK;
        }

        private bool IsInputRight()
        {
            if (string.IsNullOrEmpty(textFirstPlayer.Text)
             || string.IsNullOrEmpty(textSecondPlayer.Text))
            {
                return false;
            }
            if (textFirstPlayer.Text == textSecondPlayer.Text)
            {
                return false;
            }
            return true;
        }

        private void textFirstPlayer_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProviderFirstPlayer.SetError(textBox, "Please enter a name.");
                e.Cancel = true;
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                errorProviderFirstPlayer.SetError(textBox, "");
                e.Cancel = false;
                RemoveErrorMessages(textBox);
            }
        }

        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player name should not be blank!";
            if (textBox == this.textFirstPlayer)
            {
                errorProviderFirstPlayer.SetError(textBox, errorText);
            }
            else if (textBox == this.textSecondPlayer)
            {
                errorProviderSecondPlayer.SetError(textBox, errorText);
            }
        }

        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textFirstPlayer)
            {
                errorProviderFirstPlayer.SetError(textBox, "");
            }
            else if (textBox == this.textSecondPlayer)
            {
                errorProviderSecondPlayer.SetError(textBox, "");
            }
        }
    }
}
