using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public class Payment : IDentifier
    {
        public string ID { get; set; }
        public string CustomerID { get; set; }
        public string ProjectID { get; set; }
        public double Price { get; set; }
        public DateTime PaymentDate{ get; set; }

        public Payment() {}
        public Payment(string id, string customerID, string projectID, double price, DateTime paymentDate){
            ID = id;
            CustomerID = customerID;
            ProjectID = projectID;
            Price = price;
            PaymentDate = paymentDate;
        }
    }
}