using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoHomework.model
{
    class ProjecRepository
    {
        public string ConnectionString { set; get; }
        public MySqlConnection Dbconn { set; get; }
        
        public ProjecRepository(string connectionString)
        {
            this.ConnectionString = connectionString;
            Dbconn = new MySqlConnection(connectionString);
        }

        public string getIDbyName( string projectName)
        {
            string projectID ="";
            string sql = string.Format("SELECT projectID from Project where projectName = {1}", projectName);
            using (Dbconn) {
                MySqlCommand cmd = new MySqlCommand(sql);
                Dbconn.Open();
                cmd.Connection = Dbconn;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        projectID = reader.GetString(0);
                    }
                    else {
                        projectID = UniqueIdFactory.RandomString(10);
                    }
                }

            }

            return projectID;

        }
    }
}
