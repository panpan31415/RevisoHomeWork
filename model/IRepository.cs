﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisoHomework.model
{
    public interface IRepository<T> where T : class, IDentifier
    {
        IDataMapper<T> DataMapper { get; set; }
        T GetById(int id);
        IEnumerable<T> GetAll(int limit = 10, int offset = 0);
    }
}
