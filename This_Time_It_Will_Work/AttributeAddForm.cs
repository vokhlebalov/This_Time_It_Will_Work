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
    public partial class AttributeAddForm : Form
    {
        public string currentDB;
        public string tableName;

        public AttributeAddForm()
        {
            InitializeComponent();
        }

        public AttributeAddForm(string db, string n)
        {
            InitializeComponent();
            currentDB = db;
            tableName = n;
            InfoLabel.Text = $"Новый атрибут таблицы {tableName}:";
        }

        private void AttributeAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB, tableName);
            form.Show();
            this.Hide();
        }

        private void CreateAttrButton_Click(object sender, EventArgs e)
        {
            DataBase mData = new DataBase("prime_db");
            DataBase userDB = new DataBase(currentDB);
            int tID = GetTableID(tableName);

            #region InsertIntoPrime
            mData.OpenConnection();
            DataTable table = GetTable(mData);
            int nextID;
            if (table.Rows.Count > 0)
                nextID = UnicID(table);
            else nextID = 1;

            int UniqueValue = 0;
            int KeyValue = 0;
            int CanNullValue = 0;

            string attrName = AttrNametextBox.Text;
            string type = TypescomboBox.Text;
            string strValue = StartValueTextBox.Text;
            string desc = richTextBox1.Text;

            if (UniqueCheckBox.Checked)
                UniqueValue = 1;
            if (CanNullCheckBox.Checked)
                CanNullValue = 1;

            MySqlCommand commandIns = new MySqlCommand($"INSERT INTO `attribute` (Attribute_ID,Attribute_Name,Type,Start_Value,Is_Unique,Is_Key,Can_Null,Description,Table_ID) VALUES ({nextID},\"{attrName}\",\"{type}\",\"{strValue}\",{UniqueValue},{KeyValue},{CanNullValue},\"{desc}\",{tID})", mData.GetConnection());
            commandIns.ExecuteNonQuery();
            mData.CloseConnection();
            #endregion

            #region CreateAttr
            userDB.OpenConnection();
            string nullDef = "NULL";
            if (CanNullValue == 0)
                nullDef = "Not Null";
            MySqlCommand altCom = new MySqlCommand($"ALTER TABLE `{tableName}` ADD COLUMN {attrName} {type} {nullDef}", userDB.GetConnection());
            altCom.ExecuteNonQuery();

            if(UniqueValue == 1)
            {
              altCom = new MySqlCommand($"ALTER TABLE `{tableName}` ADD CONSTRAINT {attrName}_un_const UNIQUE ({attrName})", userDB.GetConnection());
                altCom.ExecuteNonQuery();
            }

            try
            {
                altCom = new MySqlCommand($"ALTER TABLE `{tableName}` DROP COLUMN `ID`", userDB.GetConnection());
                altCom.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //Игнорируем, если удаление уже производилось
            }
            #endregion

            DBChangeForm form = new DBChangeForm(currentDB, tableName);
            form.Show();
            this.Hide();
            MessageBox.Show($"Атрибут {attrName} успешно добавлен!");

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

        private DataTable GetTable(DataBase connection)
        {
            connection.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string query_select_id = $"SELECT * FROM `attribute`";
            MySqlCommand command = new MySqlCommand(query_select_id, connection.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int UnicID(DataTable table)
        {
            int max_value = Convert.ToInt32(table.Select("Attribute_ID = MAX(Attribute_ID)")[0][0].ToString());
            return max_value + 1;
        }
    }
}
