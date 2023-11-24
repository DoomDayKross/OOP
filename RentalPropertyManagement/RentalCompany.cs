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
        protected Owner owner;
        private List<Room> rooms;
        public RentalCompany(string address, string taxId)
        {
            this.address = address;
            this.taxId = taxId;
        }

        public void CompanyDetails()
        {
            Console.WriteLine($"Company Details:\nAddress: {address}\nTax ID: {taxId}");
        }
        public List<Room> SearchRooms(List<List<Room>> rooms,int minArea, int maxArea, double minPrice, double maxPrice)
        {
            List<Room> matchingRooms = new List<Room>();
            foreach (List<Room> availableRooms in rooms)
            {
                foreach (Room room in availableRooms)
                {
                    if (room.MatchSearchCriteria(minArea, maxArea, minPrice, maxPrice))
                    {
                        matchingRooms.Add(room);
                    }
                }
            }
            matchingRooms = matchingRooms.OrderBy(room => room.Price).ToList();
            return matchingRooms;
        }
    }
}
