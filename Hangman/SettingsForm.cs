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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (Play.difficulty == "Hard")
            {
                difficultyHardRB.Checked = true;
                difficultyNormalRB.Checked = false;
            } else if (Play.difficulty == "Normal") {
                difficultyNormalRB.Checked = true;
                difficultyHardRB.Checked = false;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in settingsDifficultyGroupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    if (radioButton == difficultyNormalRB)
                    {
                        Play.difficulty = "Normal";
                    }
                    else if (radioButton == difficultyHardRB) 
                    {
                        Play.difficulty = "Hard";
                    }
                }
            }
            this.Close();
        }

        private void cancelSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
