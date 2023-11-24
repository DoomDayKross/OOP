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
        public void MonthlyPayment(double x, double y)
        {
            UtilityBills(x, y);
            Console.WriteLine($"Your monthly payment: {CalTotalMoney(x, y)}");
        }
        public void LeaveReview(string x)
        {
            Console.WriteLine(x);
        }
        public void StarReview()
        {
            owner.StarRating -= 5;
        }
    }
}
