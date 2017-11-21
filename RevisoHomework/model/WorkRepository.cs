using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoHomework.model
{
    class WorkRepository
    {
        public string ConnectionString { set; get; }
        public MySqlConnection Dbconn { set; get; }

        public WorkRepository(String connectionString)
        {
            Dbconn = new MySqlConnection(connectionString);
        }

        public int AddWork(string projectName, DateTime date, string type, DateTime beginTime,
            DateTime endTime, string description, double priceBeforeTax, string paymentState)
        {
            ProjecRepository projecRepository = new ProjecRepository(ConnectionString);
            String projectID = projecRepository.getIDbyName(projectName);

            string sql = string.Format("INSERT INTO Work VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8})",
                UniqueIdFactory.RandomString(10),//0 WorKid
                projectID,//1
                date,//2
                type,//3
                beginTime,//4
                endTime,//5
                description,//6
                priceBeforeTax,//7
                paymentState//8
                );
            using (Dbconn)
            {
                Dbconn.Open();
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = Dbconn;
                return cmd.ExecuteNonQuery();
            }

        }

        public Work GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Work GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Work> GetAll(int limit = 10, int offset = 0)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Work> GetByDateBetween(DateTime start, DateTime end, int limit = 10, int offset = 0)
        {
            throw new NotImplementedException();
        }
    }
}

       