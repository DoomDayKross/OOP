using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class RentalCompany
    {
        protected string address;
        protected string taxId;
        public RentalCompany(string address, string taxId)
        {
            this.address = address;
            this.taxId = taxId;
        }

        public void CompanyDetails()
        {
            Console.WriteLine($"Company Details:\nAddress: {address}\nTax ID: {taxId}");
        }
    }
}
