using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForeachExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            Console.ReadLine();
        }
        static void ForLoopExample()
        {
            Console.WriteLine("=> Loop For: \n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}",i);
            }

        }
        static void ForeachExample()
        {
            Console.WriteLine("\n=> Loop ForEach: \n");
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.Write("{0}, ",c);
            }
            Console.WriteLine();
            int[] myInts = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            foreach (int i in myInts)
            {
                Console.Write("{0}, ",i);
            }

        }
        static void LinqQueryOverInts()
        {
            Console.WriteLine("\n\n=> Loop ForEach LINQ: \n");
            int[] numbers = { 10,20,30,40,50,60,70,1,2,3,4,5,6,9,8,7,55};
            //Запрос LINQ
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0}, ",i);
            }
        }
        static void WhileLoopExample()
        {
            Console.WriteLine("\n => Loop while: \n");
            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop!");
                Console.WriteLine("Are you done? [yes][no]: ");
                userIsDone = Console.ReadLine();
            }
        }
        static void DoWhileLoopExample()
        {
            Console.WriteLine("\n => Loop while: \n");
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop!");
                Console.WriteLine("Are you done? [yes][no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "yes");
           
        }
    }
}
