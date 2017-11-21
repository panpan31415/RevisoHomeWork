using RevisoHomework.model;
using System;
using MySql.Data.MySqlClient;

namespace RevisoHomework.model
{
    public abstract class Work: IPaymentConent, IDentifier
    {

        public string ID { get; set; }
        public string ProjectID { get; set; }
        public DateTime Date { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public double PriceBeforeTax { get; set; }
        public string PaymentState { get; set; }
        public string Type { get; set; }
        public Work() {}
        public Work(string id, string projectID, DateTime date, string type, DateTime beginTime, 
            DateTime endTime, string description, double priceBeforeTax, string paymentState)
        {
            this.ID = id;
            this.ProjectID = projectID;
            this.Date = date;
            this.Type = type;
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.Description = description;
            this.PriceBeforeTax = priceBeforeTax;
            this.PaymentState = paymentState;
        }

       
    }
}