using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Point p1 = new Point(50, 50, "name1");
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("Clonned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100, "name2");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.desc.PetName = "My new Point";
            p4.X = 999;
            Console.WriteLine("\nChanged p4.disc.PetName and p4.X");
            Console.WriteLine("after modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.ReadLine();
        }
    }
}
