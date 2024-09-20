using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumericalData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}",99999);
            Console.WriteLine("d6 format: {0:d6}", 9999);
            Console.WriteLine("d3 format: {0:d3}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("f5 format: {0:f5}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
            

            Console.ReadLine();


        }
    }
}
