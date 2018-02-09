using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasssExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Разместить в памяти и сконфигуриции обьект Car
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            // Увеличить  скорость автомобиля в несколько раз и вывести новое состояние
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        // усадим на votocucle байкера по имени tiny
        Motorcycle c = new Motorcycle(5);
        c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);
        }
       

        
    }
}
