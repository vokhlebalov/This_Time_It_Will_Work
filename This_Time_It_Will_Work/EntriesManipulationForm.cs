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
    public partial class EntriesManipulationForm : Form
    {
        public string currentDB;
        public EntriesManipulationForm()
        {
            InitializeComponent();
        }

        public EntriesManipulationForm(string name)
        {
            InitializeComponent();
            currentDB = name;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void EntriesManipulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
