using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Using new to create variables: ");
            bool b = new bool();
            int i = new int();
            double d = new double() +1;
            DateTime dt = new DateTime();
            decimal dec = new decimal();
            char c = new char();
            float f = new float();
            Console.WriteLine("bool = {0},\nint = {1},\ndouble = {2},\n" +
                "DateTime = {3},\ndecimal = {4},\nchar = {5}," +
                "\nfloat = {6}",b,i,d,dt,dec,c,f);
            Console.ReadLine();
        }
    }
}
