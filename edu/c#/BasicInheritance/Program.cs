using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Создать объект Car и установить максимальную скорость.
            Car myCar = new Car(100);
            // Установить текущую скорость и вывести ее на консоль.
            myCar.Speed = 80;
            Console.WriteLine($"My Car is going {myCar.Speed} KMH");

            // Создать объект MiniVan.
            MiniVan myVan = new MiniVan();
            myVan.Speed = 66;
            Console.WriteLine($"My van is going {myVan.Speed} KMH");
            Console.ReadLine();
        }      
    }
}
