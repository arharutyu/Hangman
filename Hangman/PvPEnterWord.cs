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
    public partial class PvPEnterWord : Form
    {
        public string EnteredWord { get; private set; }
        public string Definition {  get; private set; }
        public string Synonyms { get; private set; }
        public PvPEnterWord()
        {
            InitializeComponent();
            if (Play.difficulty == "Hard")
            {
                pvpDefinitionTextBox.Visible = false;
                pvpSynonymsTextBox.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void btnPvPEnterWord_Click(object sender, EventArgs e)
        {
            // Trigger the Validating event to perform validation
            if (this.ValidateChildren())
            {
                // Set the value of EnteredWord when the button is clicked
                EnteredWord = pvpWordTextbox.Text;
                if (pvpDefinitionTextBox.Text != null)
                {
                    Definition = pvpDefinitionTextBox.Text;
                }
                if (pvpSynonymsTextBox.Text != null)
                {
                    Synonyms = pvpSynonymsTextBox.Text;
                }
                // Close the form
                this.Close();
            }
        }

        private void pvpWordTextbox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Check if the text box is empty
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Display error message
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus back to the text box
                textBox.Focus();

                // Cancel the event to prevent the focus from leaving the text box
                e.Cancel = true;
            }
        }
    }
}
