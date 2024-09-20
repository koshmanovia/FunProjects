using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            SavingsAccount.SetlnterestRate(0.08);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            SavingsAccount s2 = new SavingsAccount(100);            
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetlnterestRate());
            Console.ReadLine();
        }
    }
}
