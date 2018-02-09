using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasssExample
{
    class Motorcycle
    {
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public int driverIntensity;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("YEEEEEEEEEEEE Haaaaaeeeeewww!");
            }
        }
        //Вернуть стандартный конструктор, который будет устанавливать
        // дял всех членов стандартные значения.
        public Motorcycle() { }
        //Специальный конструктор 
        public Motorcycle(int intesity)
        {
            driverIntensity = intesity;
        }

    }

}
