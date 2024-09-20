using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Agh!  No Encapsulation! *****\n");
            // Создаем машину
            Car myCar = new Car();

            // Есть прямой доступ к делегату
            myCar.listOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
            myCar.Accelerate(10);

            // Теперь можем присвоить полностью новый объект...
            // что в лучшем случае сбивает с толку.
            myCar.listOfHandlers = new Car.CarEngineHandler(CallHereToo);
            myCar.Accelerate(10);

            // Вызывающий код может также напрямую вызывать делегат
            myCar.listOfHandlers.Invoke("hee, hee, hee...");
            Console.ReadLine();
        }

        static void CallWhenExploded(string msg)
        { 
            Console.WriteLine(msg); 
        }

        static void CallHereToo(string msg)
        { 
            Console.WriteLine(msg); 
        }
    }
}
