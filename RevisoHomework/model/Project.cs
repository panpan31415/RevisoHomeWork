using RevisoHomework.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public class Project: IPaymentConent, IDentifier
    {
        public string ID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string CustomerID { get; set; }
        public string PaymentState { get; set; }
        public double PriceBeforeTax { get; set; }

        public Project(string id, string projectName, string description, string customerID, string paymentState, double priceBeforeTax) {
            ID = id;
            ProjectName = projectName;
            Description = description;
            CustomerID = customerID;
            PaymentState = paymentState;
            PriceBeforeTax = priceBeforeTax;

        }


    }
}