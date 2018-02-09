using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****FUN WITH STATIC CLASSES****\n");
            // это работает нормально 
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
            // ошибка компиляции! создавать экземпляр статического класса нельзя!
           // TimeUtilClass u = new TimeUtilClass();
            Console.ReadLine();
        }
    }
}
