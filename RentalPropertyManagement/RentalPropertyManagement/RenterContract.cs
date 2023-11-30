using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class RenterContract : Contract
    {
        protected double amount = 0;
        public RenterContract(double depositAmount, List<Room> roomList, Renter renter, Brocker brocker, DateTime startDate, DateTime expiryDate, string compensationInfo) : base(depositAmount, roomList, renter, brocker, startDate, expiryDate, compensationInfo)
        {
        }
        public void Report()
        {
            renter.RepScore -= 5;
        }
    }
}
