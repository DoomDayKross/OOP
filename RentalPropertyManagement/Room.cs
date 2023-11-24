using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class Room
    {
        protected double area;
        protected string furniture;
        protected double price;
        protected string address;
        protected string genderPreference;
        protected bool petFriendly;
        protected bool privateEntrance;
        protected Owner owner;
        public Room(double area,string furniture, double price, string address, string genderPreference, Owner owner)
        {
            this.area = area;
            this.furniture = furniture;
            this.price = price;
            this.address = address;
            this.genderPreference = genderPreference;
            this.owner = owner;
        }
        public double Area
        {
            get { return area; }
        }
        public string Furniture
        {
            get { return furniture; }
        }
        public double Price
        {
            get { return price; }
        }
        public string Address
        {
            get { return address; }
        }
        public string GenderPreference
        {
            get { return genderPreference; }
        }
        public Owner Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public void DisplayRoomInfo()
        {
            Console.WriteLine($"Area: {area} sq.ft\nFurniture: {furniture}\nPrice: {price}\nAddress: {address}\nGender Preference: {genderPreference}");
            if(petFriendly)
            {
                Console.WriteLine("Pet Friendly\n");
            } else
            {
                Console.WriteLine("No pet allow\n");
            }
        }
        public bool MatchSearchCriteria(int minArea, int maxArea, double minPrice, double maxPrice)
        {
            // Check if the room matches the search criteria
            return Area >= minArea && Area <= maxArea && Price >= minPrice && Price <= maxPrice;
        }
    }
}
