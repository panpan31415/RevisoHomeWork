using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public static class UniqueIdFactory
    {
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[(new Random()).Next(s.Length)]).ToArray());
        }
    }

}