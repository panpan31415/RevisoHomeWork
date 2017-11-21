using System;
using System.Collections.Generic;
using System.Text;

namespace RevisoHomework.model
{
    class PaymentMapper : IDataMapper<Payment>
    {
        public string TableName { get; set; }
        public string[] Attributes { get; set; }
        public PaymentMapper() {
            TableName = "Payment";
            Attributes[0] = "CustomerID";
            Attributes[1] = "ProjectID";
            Attributes[2] = "Price";
            Attributes[3] = "PaymentDate";
        }
    }
}
