using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class EndGame : Form
    {
        private Form previousGameWindow;

        public EndGame(Form previousGameWindow)
        {
            InitializeComponent();
            this.previousGameWindow = previousGameWindow;
        }

        public void SetMessage(string message)
        {
            lblEndGame.Text = message;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            previousGameWindow.Close();

            Play1P playForm = new Play1P();
            playForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            previousGameWindow.Close();
        }
    }
}
