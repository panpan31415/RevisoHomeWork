
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoHomework.model
{
    public interface IRepository<T> where T : IDentifier
    {
        string ConnectionString { get; set; }
        T GetById(string id);
        T GetByName(string name);
        IEnumerable<T> GetAll(int limit = 10, int offset = 0);
        IEnumerable<T> GetByDateBetween(DateTime start, DateTime end,  int limit = 10, int offset = 0);

    }
}
