using static RentalPropertyManagement.Human;

namespace RentalPropertyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mode = 0;
            //while(true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("User\n" +
            //        "1.Owner\n" +
            //        "2.User\n"
            //    );
            //    Console.Write("Select: ");
            //    mode = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    switch (mode)
            //    {
            //        case 1:
            //            Console.WriteLine("");
            //            break;
            //        case 2:
            //            Console.WriteLine("Question for your ideal room: \n");
            //            Console.WriteLine("");
            //            break;
            //    }
            Owner owner = new Owner(
                    "John Doe",
                    001,
                    "Men",
                    "256 Street",
                    5000,
                    "Driver"
            );
            Owner owner2 = new Owner(
                    "Sasha Lynx",
                    004,
                    "Women",
                    "900 Low Street",
                    7000,
                    "Cook"
            );
            Renter renter = new Renter(
                    "Jane Smith",
                    002,
                    "Women",
                    "6874 Low Street",
                    8000,
                    "Cook"
            );
            Brocker brocker = new Brocker(
                    "John Cena",
                    002,
                    "Men",
                    "64 High Street",
                    2000,
                    "Wresler"
            );
            List<Room> rooms = new List<Room>()
            {
                new Room
                (
                    200,
                    "Fully furnished",
                    500,
                    "123 Main Street",
                    "Any",
                    owner
                ),
                new Room
                (
                    300,
                    "Not fully furnished",
                    700,
                    "456 Main Street",
                    "Male",
                    owner
                )
            };
            List<Room> rooms2 = new List<Room>()
            {
                new Room
                (
                    400,
                    "Fully furnished",
                    500,
                    "123 Main Street",
                    "Any",
                    owner2
                ),
                new Room
                (
                    200,
                    "Not fully furnished",
                    700,
                    "456 Main Street",
                    "Male",
                    owner2
                )
            };
            LeaseContract contract = new LeaseContract
            (
                300,
                rooms,
                renter,
                brocker,
                DateTime.Now,
                DateTime.Now.AddMonths(6),
                "No compensation for early termination"
            );
            contract.DisplayContractDetails();
            contract.MonthlyPayment(70, 80);
            Console.WriteLine("\n");
            LeaseContract contract2 = new LeaseContract
            (
                300,
                rooms2,
                renter,
                brocker,
                DateTime.Now,
                DateTime.Now.AddMonths(6),
                "No compensation for early termination"
            );
            contract2.DisplayContractDetails();
            contract2.MonthlyPayment(50, 80);
            RentalCompany rentalCompany = new RentalCompany("12 Bell Street", "E022");
            List<Room> searchResults = rentalCompany.SearchRooms(new List<List<Room>> { rooms, rooms2 },200, 300, 500, 700);
            Console.WriteLine("Search Results:");
            foreach (Room result in searchResults)
            {
                Console.WriteLine($"Area: {result.Area} sq.ft, Price: ${result.Price}, Owner: {result.Owner.Name}");
            }

            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification(owner2, "Your property inspection is due next week.");
            notificationService.SendNotification(renter, "Rent payment reminder: Due in 3 days.");

            // Display notifications for each user
            NotificationDisplay.DisplayNotifications(owner2);
            NotificationDisplay.DisplayNotifications(renter);
        }
    }
}