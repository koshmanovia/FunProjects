using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел Фибаначчи");
            int count  = int.Parse(Console.ReadLine());
            List<int> arrayFibanacci = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    arrayFibanacci.Add(0);
                }
                else 
                    if (i == 1)
                    {
                    arrayFibanacci.Add(1);
                    }
                    else
                    {
                    arrayFibanacci.Add(arrayFibanacci[i - 1] + arrayFibanacci[i - 2]);
                    }
            }
            Console.Clear();
            foreach (int fibonacciNum in arrayFibanacci)
            {
                Console.Write(fibonacciNum + " ");
            }                        
            Console.ReadLine();
        }
    }
}
