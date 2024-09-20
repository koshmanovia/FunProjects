using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With type Conversions *****");
            short num1 = 32233;
            short num2 = 32001;
            //явное приведение приводит к потере данных
            short answer = (short)Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {answer}");
            NarrowingAttempt();
            ProcessBytes();
            LinqQueryQverInts();
            Console.ReadLine();

        }
        static int Add (int a, int b)
        {
            return (a + b);      
        }
        //Attempt - Попытка, Narrowing - сужение
        static void NarrowingAttempt()
        {
            byte b1 = 0;
            int i1 = 200;
            b1 = (byte)i1;
            Console.WriteLine("Value b1: {0}",b1);
        }
        static void ProcessBytes()
        {
            byte b1 = 100, b2 = 250;
            try
            {
                checked
                {
                    byte sum = ((byte)Add(b1, b2));
                    Console.WriteLine($"sum = {sum}");
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //пример на неявную типизацию
        static void LinqQueryQverInts()
        {
            int[] numbers = { 10, 20, 30, 50, 1, 2, 3, 65, 2 };
            var subject = from i in numbers where i < 10 select i;
            foreach (var i in subject)
            {
                Console.WriteLine("\n\n\n{0}",i);
            }
            Console.WriteLine();
            Console.WriteLine("subject is a: {0}", subject.GetType().Name);
            Console.WriteLine("subject is defined in: {0}", subject.GetType().Namespace);
        }

    }
}
