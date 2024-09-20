using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("***** Fun with System.GC *****");
            // Вывести оценочное количество байтов, выделенных в куче.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
            // Значения MaxGeneration начинаются c 0, поэтому при выводе добавить 1.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));
            Car refToMyCar = new Car("Zippy", 100);
            Console.WriteLine(refToMyCar.ToString());
            // Вывести поколение объекта refToMyCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
            //Создать большое количество объектов для тестирования
            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
            {
                tonsOfObjects[i] = new object();
            }
            //выполнить уборку мусора только для объектов покаления 0.
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            //Вывод покаление refToMyCar.
            Console.WriteLine($"Generation of refToMyCar is {GC.GetGeneration(refToMyCar)}");
            //Посмотреть существует ли еще tonsOfObjects[9000].
            if (tonsOfObjects[9000] != null)
            {
                Console.WriteLine($"Generations of tonsOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
            }
            else
            {
                Console.WriteLine("tonsOfObjects[9000] is no longer alive");
            }
            //Вывести количество проведенных сборок мусора для разных поколений.
            Console.WriteLine("\nGen 0 has been swept {0} times", GC.CollectionCount(0));
            Console.WriteLine("\nGen 1 has been swept {0} times", GC.CollectionCount(1));
            Console.WriteLine("\nGen 2 has been swept {0} times", GC.CollectionCount(2));

            Console.ReadLine();
        }
    }
}
