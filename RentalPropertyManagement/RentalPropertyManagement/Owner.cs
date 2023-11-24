using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class Owner : Human
    {
        private List<Room> roomList;
        private List<Contract> contractList;
        private double starRating;
        public Owner (string name, int id, string gender, string address, int phoneNo, string job) : base (name, id, gender, address, phoneNo, job) 
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Owner's info: ");
            base.PrintInfo();
        }
    }
}
