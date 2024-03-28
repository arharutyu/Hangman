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
    public partial class HangmanPictureUC : UserControl
    {

        // Define an event to notify the parent form when the number of incorrect guesses changes
        public event EventHandler IncorrectGuessesChanged;

        public HangmanPictureUC()
        {
            InitializeComponent();
        }

        public Image HangmanImage
        {
            get { return hangmanPictureUC1.Image; }
            set { hangmanPictureUC1.Image = value; }
        }

        // Method to raise the IncorrectGuessesChanged event
        public virtual void OnIncorrectGuessesChanged()
        {
            IncorrectGuessesChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
