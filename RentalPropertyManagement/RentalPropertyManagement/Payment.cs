using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class Payment
    {
        public string Type { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Payment(string type, double amount, DateTime date)
        {
            Type = type;
            Amount = amount;
            Date = date;
        }
    }
}
