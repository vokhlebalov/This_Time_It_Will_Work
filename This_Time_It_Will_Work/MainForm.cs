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
        public string currentDB;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string dbName)
        {
            InitializeComponent();
            currentDB = dbName;
        }

        private void CreateDbButton_Click(object sender, EventArgs e)
        {
            DBCreationFrom form = new DBCreationFrom(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonChangeDB_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonEntries_Click(object sender, EventArgs e)
        {
            EntriesManipulationForm form = new EntriesManipulationForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            QuerriesForm form = new QuerriesForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
