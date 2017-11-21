using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public class Payment
    {
        public string PaymentID { get; set; }
        public string CustomerID { get; set; }
        public string ProjectID { get; set; }
        public double Price { get; set; }
        public DateTime PaymentDate{ get; set; }
    }
}