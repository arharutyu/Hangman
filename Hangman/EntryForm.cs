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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnPlayCp_Click(object sender, EventArgs e)
        {
            Play1P play1pForm = new Play1P();
            play1pForm.Show();
        }
    }
}
