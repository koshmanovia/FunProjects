using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            //Создаем объект car
            Car c1 = new Car("SlugBug", 100, 10);
            //сообщаем car какой метод надо вызвать
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //На этот раз сохраняем объект делегата, чтобы позже можно было отменить регистрацию
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);

            Console.WriteLine("***** Speeding uр *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            c1.UnRegisterWithCarEngine(handler2);
            //сообщения из второго обработчика больше не выводятся
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("OnCarEngineEvent number one!");
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("OnCarEngineEvent number two!");
            Console.WriteLine("=> {0}\n", msg.ToUpper());
        }
    }
}
