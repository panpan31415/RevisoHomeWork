using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace RevisoHomework.model
{
    class ProjectMapper: IDataMapper<Project>
    {
        public string TableName { get; set; }
        public string[] Attributes { get; set; }
        public MySqlConnection connection { get ; set; }
        public string connectionString { get; set; }

        public ProjectMapper()
        {
            TableName = "Project";
            Attributes[0] = "ProjectID";
            Attributes[1] = "ProjectName";
            Attributes[2] = "Description";
            Attributes[3] = "CustomerID";
            Attributes[3] = "PaymentState";
        }
    }
}
