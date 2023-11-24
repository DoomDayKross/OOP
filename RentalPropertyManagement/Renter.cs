using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class Renter : Human
    {
        private LeaseContract contract;
        private int repScore=100;
        public Renter(string name, int id, string gender, string address, int phoneNo, string job) : base(name, id, gender, address, phoneNo, job)
        {
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
    }
}
