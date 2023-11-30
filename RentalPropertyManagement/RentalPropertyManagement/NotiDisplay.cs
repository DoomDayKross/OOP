using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    using System;

    public class NotificationDisplay
    {
        public static void DisplayNotifications(Owner owner)
        {
            Console.WriteLine($"Notifications for owner {owner.Name}:");
            foreach (Notification notification in owner.Notifications)
            {
                Console.WriteLine($"{notification.Timestamp}: {notification.Message}");
            }
            Console.WriteLine();
        }

        public static void DisplayNotifications(Renter renter)
        {
            Console.WriteLine($"Notifications for Renter {renter.Name}:");
            foreach (Notification notification in renter.Notifications)
            {
                Console.WriteLine($"{notification.Timestamp}: {notification.Message}");
            }
            Console.WriteLine();
        }
    }

}
