using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoHomework.model
{
    class WorkMapper : IDataMapper<Work>
    {
        public string ConnestionString { get; set; }
        public MySqlConnection connection { get; set; }
        public string TableName { get; set; }
        public string[] Attributes { get; set; }
        public string connectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public WorkMapper(string connectionString)
        {
            ConnestionString = connectionString;
            TableName = "Work";
            Attributes = new string[] { " id", "ProjectID","CustomerName", "Date",
                "Type", "BeginTime", "EndTime", "Description", "PriceBeforeTax", "PaymentState" };
            
        }

        public string findProjectIdByName(string projectName)
        {
            using (connection = new MySqlConnection()) { }
        }

    }
}
