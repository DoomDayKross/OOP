using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class Owner : Human
    {
        private List<Room> roomList;
        private List<Contract> contractList;
        private double starRating=100;
        public List<Notification> Notifications { get; set; }
        public Owner (string name, int id, string gender, string address, int phoneNo, string job, double iniBalance) : base (name, id, gender, address, phoneNo, job, iniBalance) 
        {
            Notifications = new List<Notification>();
        }
        public double StarRating
        {
            get { return starRating; }
            set { starRating = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Owner's info: ");
            base.PrintInfo();
            Console.WriteLine($"Rating Score: {starRating}\n");
        }
        public void ReceiveNotification(string message)
        {
            Notifications.Add(new Notification(message));
        }
        public void ReceivePayment(double amount, DateTime paymentDate)
        {
            FinancialRecord.AddPayment("Received Payment", amount, paymentDate);
        }
    }
}
