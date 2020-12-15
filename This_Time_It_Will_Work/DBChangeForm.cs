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
    public partial class DBChangeForm : Form
    {
        public string currentDB;
        public DBChangeForm()
        {
            InitializeComponent();
            FillListTables();
        }

        public DBChangeForm(string name)
        {
            InitializeComponent();
            currentDB = name;
            FillListTables();

        }

        public DBChangeForm(string name, string currentTable)
        {
            InitializeComponent();
            currentDB = name;
            TableNameTextBox.Text = currentTable;
            FillListTables();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void DBChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            TableDescriptionForm form = new TableDescriptionForm(currentDB, TableNameTextBox.Text);
            form.Show();
            this.Hide();
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);

            mData.OpenConnection();
            
            MySqlCommand commandIns = new MySqlCommand($"DELETE FROM `table` WHERE Name = \"{comboBoxTables.Text}\"", mData.GetConnection());
            commandIns.ExecuteNonQuery();

            userDB.OpenConnection();
            MySqlCommand commandCreate = new MySqlCommand($"DROP TABLE IF EXISTS {comboBoxTables.Text}", userDB.GetConnection());
            commandCreate.ExecuteNonQuery();

            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
            MessageBox.Show($"Таблица {comboBoxTables.Text} успешно удалена!");
            FillListTables();
        }

        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {

        }
       
        private void FillListTables()
        {
            DataBase db = new DataBase("prime_db");
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT Name FROM `table`", db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                comboBoxTables.Items.Add(reader.GetValue(0).ToString());
            }
            db.CloseConnection();

        }
    }
}
