using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisoHomework.model
{
    public abstract class Invoice
    {
        public string InvoiceID { get; set; }
        public string CustomerID { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public abstract void AddPaymentConent();
        
    }
}