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
        }

        public DBCreationFrom(string dbName)
        {
            InitializeComponent();
            currentDB = dbName;
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
            if (currentDB == DB_Name_TextBox.Text)
            {
                MySqlCommand com = new MySqlCommand($"DROP DATABASE IF EXISTS {currentDB}", con);
                com.ExecuteNonQuery();
            }
            MySqlCommand command = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS {DB_Name_TextBox.Text}", con);
            command.ExecuteNonQuery();
            currentDB = DB_Name_TextBox.Text;

            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
            MessageBox.Show($"База данных {currentDB} создана успешно!");

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string temp = currentDB;
            currentDB = DB_Name_TextBox.Text;
            DataBase testConnection = new DataBase(currentDB);
            bool flag = false;

            try
            {
                testConnection.OpenConnection();
            }catch(MySqlException ex)
            {
                MessageBox.Show("Не удалось выполнить подключение. Попробуйте создать новую базу данных или ввести другое имя");
                flag = true;
            }
            if (flag)  currentDB = temp;
            else MessageBox.Show($"Подключение к базе данных {currentDB} выполнено успешно!"); 

        }
    }
}
