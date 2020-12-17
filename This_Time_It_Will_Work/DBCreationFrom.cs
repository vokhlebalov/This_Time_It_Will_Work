using System;
using MySql.Data.MySqlClient;
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
    public partial class DBCreationFrom : Form
    {
        public string currentDB;
        public DBCreationFrom()
        {
            InitializeComponent();
            buttonCreate.Enabled = false;
        }

        public DBCreationFrom(string dbName)
        {
            InitializeComponent();
            currentDB = dbName;
            buttonCreate.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void DBCreationFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=root");
            con.Open();
            
            MySqlCommand com = new MySqlCommand($"DROP DATABASE IF EXISTS {DB_Name_TextBox.Text}", con);
            com.ExecuteNonQuery();
            
            MySqlCommand command = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS {DB_Name_TextBox.Text}", con);
            command.ExecuteNonQuery();
            currentDB = DB_Name_TextBox.Text;

            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            string[] names = { "table", "connection", "attribute" };
            foreach (string t in names)
            {
                MySqlCommand del = new MySqlCommand($"DELETE FROM `{t}`", mData.GetConnection());
                del.ExecuteNonQuery();
            }

            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
            MessageBox.Show($"База данных {currentDB} создана успешно!");

        }

        private void DB_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (DB_Name_TextBox.Text == "" || DB_Name_TextBox.Text == "mysql" || DB_Name_TextBox.Text == "prime_db" || DB_Name_TextBox.Text == "sys")
                buttonCreate.Enabled = false;
            else buttonCreate.Enabled = true;
        }

        private void DB_Name_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DB_Name_TextBox.Text.Length > 7 && e.KeyChar != 8) e.Handled = true;
            string[] names = {
                "a", "b", "c", "d", "e", "f", "g", "h", "i",
                "j", "k", "l", "m", "n", "o", "p", "q", "r",
                "s", "t", "u", "v", "w", "x", "y", "z"
            };
            if (!(names.Contains(e.KeyChar.ToString())||e.KeyChar==8)) e.Handled = true;
           

        }
    }
}
