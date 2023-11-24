using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPropertyManagement
{
    class Contract
    {
        protected double depositAmount;
        protected List<Room> roomList;
        protected Owner owner;
        protected Renter renter;
        protected Brocker brocker;
        protected DateTime expiryDate;
        protected string compensationInfo;
        protected double extra = 0;
        protected double total = 0;
        protected DateTime startDate;
        protected bool isTerminated = true;
        public Contract(double depositAmount, List<Room> roomList,Renter renter, Brocker brocker,DateTime startDate, DateTime expiryDate, string compensationInfo)
        {
            this.depositAmount = depositAmount;
            this.roomList = roomList;
            owner = roomList[0].Owner;
            this.renter = renter;
            this.brocker = brocker;
            this.startDate = startDate;
            this.expiryDate = expiryDate;
            this.compensationInfo = compensationInfo;
        }

        public double CalRefund()
        {
            return depositAmount;
        }
        public virtual void DisplayContractDetails()
        {
            Console.WriteLine($"Contract Details:\nDeposit Amount: ${depositAmount}\nStart Date: {startDate}\nExpiry Date: {expiryDate}\nCompensation Info: {compensationInfo}\n");
            int count = 1;
            foreach (Room room in roomList)
            {
                Console.WriteLine($"Room {count++}'s info: \n");
                room.DisplayRoomInfo(); 
            }
            owner.PrintInfo();
            renter.PrintInfo();
            brocker.PrintInfo();
            MaintenanceSchedule();
        }
        public void ReNewLease(int x)
        {
            expiryDate.AddMonths(x);
        }
        public double AdditionalCosts(string x,double y)
        {
            Console.WriteLine($"Charge for: {x}\n");
            Console.WriteLine($"Amount: {y}$\n");
            extra = y;
            return extra;
        }
        public double CalTotalMoney()
        {
            foreach (Room room in roomList)
            {
                total += room.Price + extra;
            }
            return total;
        }
        public void MaintenanceSchedule()
        {
            Console.WriteLine("Your maintenance schedule every two months: ");
            for (int i = 2; i < (((expiryDate.Year - startDate.Year) * 12) + expiryDate.Month - startDate.Month) ; i+=2)
            {
                Console.WriteLine(startDate.AddMonths(i));
            }
        }
    }
}
