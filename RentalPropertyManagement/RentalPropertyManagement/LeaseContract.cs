using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class LeaseContract : Contract
    {
        public LeaseContract(double depositAmount, List<Room> roomList,Renter renter, Brocker brocker,DateTime startDate, DateTime expiryDate, string compensationInfo) : base (depositAmount, roomList, renter, brocker, startDate, expiryDate, compensationInfo)
        {
        }
        public override void DisplayContractDetails()
        {
            base.DisplayContractDetails();
            Console.WriteLine($"Your monthly payment: {CalTotalMoney()}");
        }
        public void Report()
        {
            renter.RepScore -= 5;
        }
    }
}
