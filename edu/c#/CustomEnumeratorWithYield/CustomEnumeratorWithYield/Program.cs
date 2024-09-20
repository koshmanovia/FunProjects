using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with thr Yield Keyword *****\n");
            Garage carLot = new Garage();
            //получить эллементы, используя GetEnumerator().
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",c.PetName,c.CurrentSpeed);
            }
            //получить эллументы (в обратном порядке!)
            //с применением именованного итератора
            Console.WriteLine();
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}
