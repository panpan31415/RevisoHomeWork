using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace RevisoHomework.model2
{
    public class  DBconnector
    {
        public static DBconnector dBconnector = new DBconnector();
        private DBconnector() { }
        public static DBconnector getInstance() {
            return dBconnector;
        }
        public MySqlConnection GetConnection(String connectionString)
        {
            return new MySqlConnection(connectionString);
        }
    }
}
