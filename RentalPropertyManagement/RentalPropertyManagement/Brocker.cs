using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class Brocker : Human
    {
        private string fromCompany;
        private List<Owner> ownerList;
        public Brocker(string name, int id, string gender, string address, int phoneNo, string job, double iniBalance) : base(name,id, gender, address, phoneNo,job, iniBalance)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Brocker's info: ");
            base.PrintInfo();
        }
    }
}
