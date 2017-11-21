using RevisoHomework.model;
using RevisoHomework.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public class Customer : IDentifier
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Customer()
        {
            IDentifier = UniqueIdFactory
        }
    }
}