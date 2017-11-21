using MySql.Data.MySqlClient;
using RevisoHomework.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RevisoHomework.model
{
    public interface IDataMapper<T> where T : class,IDentifier
    {
        string ConnectionString { get; set; }
        string TableName { get; }
        string[] Attributes { get; }
        T GetById(int id);
        T Map(MySqlDataReader reader);
        IEnumerable<T> Query(MySqlCommand command);
    }
}
