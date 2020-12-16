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
            FillListConnections();
        }

        public DBChangeForm(string name)
        {
            InitializeComponent();
            currentDB = name;
            FillListTables();
            FillListConnections();
        }

        public DBChangeForm(string name, string currentTable)
        {
            InitializeComponent();
            currentDB = name;
            FillListTables();
            if (comboBoxTables.Items.Contains(currentTable))
                comboBoxTables.Text = currentTable;
            else TableNameTextBox.Text = currentTable;
            FillListConnections();
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
            bool flag = false;

            try
            {
                userDB.OpenConnection();
                MySqlCommand commandCreate = new MySqlCommand($"DROP TABLE IF EXISTS {comboBoxTables.Text}", userDB.GetConnection());
                commandCreate.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                flag = true;
                MessageBox.Show($"Не получилось произвести удаление таблицы {comboBoxTables.Text}. Попробуйте сначала удалить зависимости");
            }

            if (!flag)
            {
                MySqlCommand commandIns = new MySqlCommand($"DELETE FROM `table` WHERE Name = \"{comboBoxTables.Text}\"", mData.GetConnection());
                commandIns.ExecuteNonQuery();
                MessageBox.Show($"Таблица {comboBoxTables.Text} успешно удалена!");
            }
            DBChangeForm form = new DBChangeForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {
            ConnectionSetUpForm form = new ConnectionSetUpForm(currentDB);
            form.Show();
            this.Hide();
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            AttributeAddForm form = new AttributeAddForm(currentDB, comboBoxTables.Text);
            form.Show();
            this.Hide();
        }
       
        private void FillListTables()
        {
            comboBoxTables.Items.Clear();
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

        private void FillListAttrs()
        {
            AllAttrsListBox.Items.Clear();
            DataBase db = new DataBase("prime_db");
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand($"SELECT Attribute_Name FROM `attribute` WHERE Table_ID = {GetTableID(comboBoxTables.Text)}", db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                AllAttrsListBox.Items.Add(reader.GetValue(0).ToString());
            }
            db.CloseConnection();

        }

        private void FillListConnections()
        {
            DataBase db = new DataBase("prime_db");
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand($"SELECT First_Atr_ID, Second_Atr_ID, Connection_ID FROM `connection`", db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IDataRecord record = (IDataRecord)reader;
                ConnectionsListBox.Items.Add($"{Convert.ToInt32(record[2])}   {GetAttrName(Convert.ToInt32(record[0]))} ----> {GetAttrName(Convert.ToInt32(record[1]))}");
            }
            db.CloseConnection();

        }

        private string GetAttrName(int id)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Attribute_Name FROM `attribute` WHERE Attribute_ID = {id}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return reader.GetValue(0).ToString();
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
            FillListAttrs();
        }

        private void ChooseAsKeyButton_Click(object sender, EventArgs e)
        {
                string selectedAttr = NonKeyItemsListbox.SelectedItem.ToString();
                NonKeyItemsListbox.Items.Remove(selectedAttr);
                KeyItemsListbox.Items.Add(selectedAttr);
        }

        private void DropFromKeyButton_Click(object sender, EventArgs e)
        {
            string selectedAttr = KeyItemsListbox.SelectedItem.ToString();
            KeyItemsListbox.Items.Remove(selectedAttr);
            NonKeyItemsListbox.Items.Add(selectedAttr);
        }

        private void ChangeKeyButton_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);

            string updKeyValues = "";

            mData.OpenConnection();
            userDB.OpenConnection();
            foreach (string attr in KeyItemsListbox.Items)
            {
                MySqlCommand updComm = new MySqlCommand($"UPDATE `attribute` SET Is_Key = 1 WHERE Attribute_Name = \"{attr}\"", mData.GetConnection());
                updComm.ExecuteNonQuery();
                updKeyValues += attr + ", ";
            }
            foreach (string attr in NonKeyItemsListbox.Items)
            {
                MySqlCommand updComm = new MySqlCommand($"UPDATE `attribute` SET Is_Key = 0 WHERE Attribute_Name = \"{attr}\"", mData.GetConnection());
                updComm.ExecuteNonQuery();
            }
            try
            {
                MySqlCommand dropKey = new MySqlCommand($"ALTER TABLE `{comboBoxTables.Text}` DROP PRIMARY KEY", userDB.GetConnection());
                dropKey.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //Если ключа нет - игнорируем
            }
            updKeyValues = updKeyValues.Remove(updKeyValues.Length - 2);
            MySqlCommand createKey = new MySqlCommand($"ALTER TABLE `{comboBoxTables.Text}` ADD CONSTRAINT {comboBoxTables.Text}_keyValue PRIMARY KEY ({updKeyValues})", userDB.GetConnection());
            createKey.ExecuteNonQuery();
            MessageBox.Show($"Атрибуты: {updKeyValues} теперь составляют первичный ключ таблицы {comboBoxTables.Text}!");
        }

        private void DeleteConnectionButton_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDate = new DataBase(currentDB);

            string[] fkey = ConnectionsListBox.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int connID = Convert.ToInt32(fkey[0]);
            string connName = GetConnectionName(connID);
            string fKeyAttrName = fkey[1];
            string depTName = GetTableName(GetSourceId(fKeyAttrName));

            mData.OpenConnection();
            userDate.OpenConnection();

            bool flag = false;
            try
            {
                MySqlCommand com = new MySqlCommand($"ALTER TABLE `{depTName}` DROP FOREIGN KEY {connName}", userDate.GetConnection());
                com.ExecuteNonQuery();
            }catch(MySqlException ex)
            {
                flag = true;
                MessageBox.Show("Не получилось удалить связь");
            }

            if(!flag)
            {
                MySqlCommand remEntCom = new MySqlCommand($"DELETE FROM `connection` WHERE Connection_ID = {connID}", mData.GetConnection());
                remEntCom.ExecuteNonQuery();
                MessageBox.Show("Удаление внешнего ключа выполнено успешно!");
                DBChangeForm form = new DBChangeForm(currentDB);
                form.Show();
                this.Hide();
            }

        }

        private string GetConnectionName(int id)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Connection_Name FROM `connection` WHERE Connection_ID = {id}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return reader.GetValue(0).ToString();
        }

        private int GetSourceId(string attrName)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Table_ID FROM `attribute` WHERE Attribute_Name = \"{attrName}\"", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return Convert.ToInt32(reader.GetValue(0));
        }

        private string GetTableName(int id)
        {
            DataBase mData = new DataBase("prime_db");
            mData.OpenConnection();
            MySqlCommand com = new MySqlCommand($"SELECT Name FROM `table` WHERE Table_ID = {id}", mData.GetConnection());
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            return reader.GetValue(0).ToString();
        }

        private void DeleteAttrButton_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);
            string deopAttrName = AllAttrsListBox.SelectedItem.ToString();
            string sourceName = GetTableName(GetSourceId(deopAttrName));
            bool flag = false;
            mData.OpenConnection();
            userDB.OpenConnection();

            try
            {
                MySqlCommand altCom = new MySqlCommand($"ALTER TABLE `{sourceName}` DROP COLUMN `{deopAttrName}`", userDB.GetConnection());
                altCom.ExecuteNonQuery();
            }catch(MySqlException ex)
            {
                flag = true;
                MessageBox.Show($"Не удалось произвести удаление атрибута {deopAttrName}");
            }

            if (!flag)
            {
                MySqlCommand com = new MySqlCommand($"DELETE FROM `attribute` WHERE Attribute_Name = \"{deopAttrName}\"", mData.GetConnection());
                com.ExecuteNonQuery();
                MessageBox.Show($"Удаление атрибута {deopAttrName} выполнено!");
                DBChangeForm form = new DBChangeForm(currentDB);
                form.Show();
                this.Hide();
            } 

        }
    }
}
