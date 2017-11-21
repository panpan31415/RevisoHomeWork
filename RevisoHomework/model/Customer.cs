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
        public string ID { get; set; }

        public Customer() { }
        public Customer(string id , string name, int age,string gender, string telephone, string email) {
            this.ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            Telephone = telephone;
            Email = email;
        }
        


    }
}