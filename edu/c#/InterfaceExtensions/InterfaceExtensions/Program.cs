using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Extending Interface Compatible Types *****\n");
            //System.Array реализует IEnumerable
            string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "weird", "way", "fun!" };
            data.PrintDataAndBeep();
            Console.WriteLine();
            //List<T> реализует Ienumerable!
            List<int> myInts = new List<int>() { 1, 2, 3, 4, 5 };
            myInts.PrintDataAndBeep();
            Console.ReadLine();
        }
    }
}
