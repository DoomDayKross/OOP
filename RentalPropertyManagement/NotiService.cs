using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    public class NotificationService
    {
        public void SendNotification(Owner owner, string message)
        {
            owner.ReceiveNotification(message);
        }

        public void SendNotification(Renter renter, string message)
        {
            renter.ReceiveNotification(message);
        }
    }

}
