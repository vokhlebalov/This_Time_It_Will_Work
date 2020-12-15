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
    public partial class QuerriesForm : Form
    {
        public string currentDB;
        public QuerriesForm()
        {
            InitializeComponent();
        }

        public QuerriesForm(string name)
        {
            InitializeComponent();
            currentDB = name;
        }

        private void QuerriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }
    }
}
