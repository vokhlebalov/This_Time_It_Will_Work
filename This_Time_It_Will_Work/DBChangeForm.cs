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
            FillListTables();
            if (comboBoxTables.Items.Contains(currentTable))
                comboBoxTables.Text = currentTable;
            else TableNameTextBox.Text = currentTable;
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
            AttributeAddForm form = new AttributeAddForm(currentDB, comboBoxTables.Text);
            form.Show();
            this.Hide();
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


        private int GetTableID(string tName)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Table_ID FROM `table` WHERE Name = \"{tName}\"", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader.GetValue(0).ToString());

        }

        private int GetKeyValue(string attName)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Is_Key FROM `attribute` WHERE Attribute_Name = \"{attName}\"", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader.GetValue(0));
        }

        private void comboBoxTables_TextChanged(object sender, EventArgs e)
        {
            KeyItemsListbox.Items.Clear();
            NonKeyItemsListbox.Items.Clear();
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Attribute_Name FROM `attribute` WHERE Table_ID = {GetTableID(comboBoxTables.Text)}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string currAttr = reader.GetValue(0).ToString();
                if (GetKeyValue(currAttr) == 1)
                    KeyItemsListbox.Items.Add(currAttr);
                else NonKeyItemsListbox.Items.Add(currAttr);
            }
            mData.CloseConnection();
        }
    }
}
