using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****FUN WITH STATIC DATA******\n");
            SavingsAccounts s1 = new SavingsAccounts(50);
            SavingsAccounts s2 = new SavingsAccounts(100);
            //Вывести текущую процентную ставку
            Console.WriteLine("Interest rate is: (0)", SavingsAccounts.GetInterestRate());
            //Создать новый обьект это не сбросит процентную ставку
            SavingsAccounts s3 = new SavingsAccounts(1000.75);
            Console.WriteLine("Interest rate is: (0)", SavingsAccounts.GetInterestRate());
            Console.ReadLine();
        }
    }
}
