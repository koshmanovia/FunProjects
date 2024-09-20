using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with method overload: *****");
            Console.WriteLine(Add(23,22));
            Console.WriteLine(Add(4.3,4.4));
            Console.WriteLine(Add(900_000_000_000,800_355_546_655));
            Console.WriteLine(AddWrapper(1,2));
            Console.ReadLine();
        }
        static int Add(int a, int b){return a+b;}
        static double Add(double a, double b) { return a + b; }
        static long Add(long a, long b) { return a + b; }
        static int AddWrapper(int a, int b) 
        {
            return Add();
            int Add()
            {
                return (a + b);
            }
        }
    }
}
