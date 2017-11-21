using RevisoHomework.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public class Project: IPaymentConent
    {
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string CustomerID { get; set; }
        public string PaymentState { get; set; }
        public double PriceBeforeTax { get; set; }


    }
}