using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RevisoHomework.model
{
    public class CustomerMapper : IDataMapper<Customer>
    {
        public string ConnectionString { get; set; }
        public string TableName = "Customer";
        public string[] Attributes = new string[] { "CustomerID", "CustomerName", "Age","Gender","Telephone","Email" };

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Map(MySqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Query(MySqlCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
