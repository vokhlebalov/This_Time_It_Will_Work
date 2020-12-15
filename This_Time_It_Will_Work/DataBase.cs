using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Time_It_Will_Work
{
    class DataBase
    {
        MySqlConnection connection;

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public DataBase(string dbName)
        {
            connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={dbName}");
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
