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
    public partial class KeyboardUC : UserControl
    {
        public event EventHandler<string> KeyPressed;

        public KeyboardUC()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            // Hook up the same event handler to all buttons
            foreach (Control control in grpboxLetters.Controls)
            {
                if (control is Button button)
                {
                    button.Click += KeyboardButtonClick;
                }
            }
        }

        private void KeyboardButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false;

            // Get the text of the clicked button
            string letter = clickedButton.Text.ToLower();
            OnKeyPressed(letter);
        }

        protected virtual void OnKeyPressed(string letter)
        {
            KeyPressed?.Invoke(this, letter);
        }
    }
}
