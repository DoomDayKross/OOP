using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class Notification
    {
        protected string message;
        protected DateTime timestamp;

        public Notification(string message)
        {
            this.message = message;
            this.timestamp = DateTime.Now;
        }
        public string Message
        { get { return message; } }

        public DateTime Timestamp 
        { get { return timestamp; } }
    }
}
