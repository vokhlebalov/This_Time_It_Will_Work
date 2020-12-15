using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_Time_It_Will_Work
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateDbButton_Click(object sender, EventArgs e)
        {
            DBCreationFrom form = new DBCreationFrom();
            form.Show();
            this.Hide();
        }

        private void buttonChangeDB_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm();
            form.Show();
            this.Hide();
        }

        private void buttonEntries_Click(object sender, EventArgs e)
        {
            EntriesManipulationForm form = new EntriesManipulationForm();
            form.Show();
            this.Hide();
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            QuerriesForm form = new QuerriesForm();
            form.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
