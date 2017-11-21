using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RevisoHomework.model2
{
    interface IManager<T>
    {
        int Insert(T t);
        int Update(T t);
        int Delete(T t);
        IEnumerable<T> GetAll(int limit, int offset);
        IEnumerable<T> GetBy(string parater, int limit, int offset);
        IEnumerable<T> GetBetween(DateTime start, DateTime end,int limit, int offset);

    }
}
