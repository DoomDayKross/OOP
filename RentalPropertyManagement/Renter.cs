using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class Renter : Human
    {
        private LeaseContract contract;
        private int repScore=100;
        public List<Notification> Notifications { get; set; }
        public Renter(string name, int id, string gender, string address, int phoneNo, string job) : base(name, id, gender, address, phoneNo, job)
        {
            Notifications = new List<Notification>();
        }
        public string Name
        {
            get { return name; }
        }
        public int RepScore
        {
            get {return  repScore; }
            set { repScore = value; }
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Renter's info: ");
            base.PrintInfo();
            Console.WriteLine($"Reputation Score: {repScore}\n");
        }
        public void ReceiveNotification(string message)
        {
            Notifications.Add(new Notification(message));
        }
    }
}
