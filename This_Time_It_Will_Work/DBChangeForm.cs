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
    public partial class DBChangeForm : Form
    {
        public string currentDb;
        public DBChangeForm()
        {
            InitializeComponent();
        }

        public DBChangeForm(string name)
        {
            InitializeComponent();
            currentDb = name;
        }

        public DBChangeForm(string name, string currentTable)
        {
            InitializeComponent();
            currentDb = name;
            TableNameTextBox.Text = currentTable;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDb);
            form.Show();
            this.Hide();
        }

        private void DBChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            TableDescriptionForm form = new TableDescriptionForm(currentDb, TableNameTextBox.Text);
            form.Show();
            this.Hide();
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {

        }
    }
}
