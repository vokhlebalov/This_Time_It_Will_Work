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
    public partial class ConnectionSetUpForm : Form
    {
        public string currentDB;

        public ConnectionSetUpForm()
        {
            InitializeComponent();
        }

        public ConnectionSetUpForm(string db)
        {
            InitializeComponent();
            currentDB = db;
        }

        private void ConnectionSetUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void CreateConnectionButton_Click(object sender, EventArgs e)
        {

        }

        private void depTableComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refTableComboBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
