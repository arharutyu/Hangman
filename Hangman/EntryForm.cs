using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Hangman
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnPlayCp_Click(object sender, EventArgs e)
        {
            Play1P play1pForm = new Play1P(true);
            play1pForm.Show();
        }

        private void btnPlayPvP_Click(object sender, EventArgs e)
        {
            Play1P play1pForm = new Play1P(false);
            play1pForm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
