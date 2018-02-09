using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccounts
    {
        //данные уровня экземпляра
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingsAccounts (Double balance)
        {
            currBalance = balance;
        }
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
