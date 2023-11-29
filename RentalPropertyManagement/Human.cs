using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class Human
    {
        protected string name;
        protected int id;
        protected string gender;
        protected string address;
        protected int phoneNo;
        protected string job;
        public Human(string name, int id, string gender, string address, int phoneNo, string job)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.address = address;
            this.phoneNo = phoneNo;
            this.job = job;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {name}\nID: {id}\nGender:{gender}\nAddress: {address}\nPhone number: {phoneNo}\nJob: {job}");
        }
        }
}
