using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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

        private void button_insert_Click(object sender, EventArgs e)
        {
            
            DataBase connection = new DataBase("prime_db");
            connection.OpenConnection();
            DataTable table = GetTable(connection);

            dataGridView.DataSource = table;
            
            int id_table = UnicID(table);
            string table_name = textBox_tablename.Text;
            string description = richTextBox_tabledesc.Text;

            string query = $"INSERT INTO `table` (Table_ID,Name,Description) VALUES ({id_table},\"{table_name}\",\"{description}\");";
            DialogResult result;

            MySqlCommand command = new MySqlCommand(query, connection.GetConnection());
            result = MessageBox.Show("done");
            command.ExecuteNonQuery();
            
            table = GetTable(connection);
            dataGridView.DataSource = table;

            connection.CloseConnection();
        }

        private DataTable GetTable(DataBase connection)
        {
            connection.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string query_select_id = $"SELECT * FROM `table`";
            MySqlCommand command = new MySqlCommand(query_select_id, connection.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int UnicID(DataTable table)
        {
            int max_value = Convert.ToInt32(table.Select("Table_ID = MAX(Table_ID)")[0][0].ToString());
            return max_value+1;
        }
    }
}
