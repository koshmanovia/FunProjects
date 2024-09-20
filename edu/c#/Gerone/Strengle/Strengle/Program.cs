using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strengle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a,b,c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                string result = string.Format($"{s:f2}");
                Console.WriteLine("S = {0}", result);
            }
            else 
            {
                Console.WriteLine("Thriangle not alive");
            }
            Console.ReadLine();
        }
    }
}
