using RevisoHomework.model;
using System;
using MySql.Data.MySqlClient;

namespace RevisoHomework.model
{
    public class Work: IPaymentConent
    {
        public string WorkID { get; }
        public string ProjectID { get; set; }
        public DateTime Date { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public double WorkingTime { get; set; }
        public string Description { get; set; }
        public double PriceBeforeTax { get; set; }
        public string PaymentState { get; set; }

        public Work() { }
        public Work(string projectID, DateTime date, DateTime beginTime, DateTime endTime, string description, double priceBeforeTax, string paymentState)
        {
            this.WorkID = UniqueIdFactory.RandomString(10);
            this.ProjectID = projectID;
            this.Date = date;
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.WorkingTime = WorkingTime;
            this.PriceBeforeTax = priceBeforeTax;
            this.PaymentState = paymentState;
        }

        //public void AddtodatabaseTest()
        //{
           
        //    string connectionString = "Database = Reviso; Server = 62.198.9.243; uid = root; pwd = panpan12345"; 
        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        //System.Console.WriteLine("Hello World!");
        //        connection.Open();
        //        var TableName = "Work";               
        //        var sql = string.Format("insert into {0} values('{1}','{2}',{3},{4},{5},{6},{7},{8})",
        //            TableName,
        //            UniqueIdFactory.RandomString(10),
        //            UniqueIdFactory.RandomString(10),
        //            "'12-12-2017'",
        //            "'08:30'",
        //            "'16:00'",
        //            "'this is a test2'",
        //            200.00,
        //            "'not paid'");
        //        var cmd = new MySqlCommand(sql);
        //        cmd.Connection = connection;
        //        cmd.ExecuteNonQuery();
        //        connection.Close();


        //    }
        //}

        //public static void Main(string [] args) {
        //    new Work().AddtodatabaseTest();
        //}
    }
}