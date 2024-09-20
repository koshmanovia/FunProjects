using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString ;
            myString = "this my character Data";
            bool b1 = true, b2 = false, b3 = true;
            System.Boolean b4 = false;
            Console.WriteLine("your Data:{0} {1} {2} {3} {4} {5}",myInt,myString,b1,b2,b3,b4);
            Console.ReadLine();


        }
    }
}
