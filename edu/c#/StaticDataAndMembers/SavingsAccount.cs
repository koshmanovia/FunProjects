using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;     
        public static double currlnterestRate = 0.04;
        public static double InterestRate
        {
            get { return currlnterestRate; }
            set { currlnterestRate = value; }
        }
        public SavingsAccount(double balance)
        {
            currlnterestRate = 0.04;
            currBalance = balance;
        }
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!"); // в статическом конструкторе
            currlnterestRate = 0.04;
        }
        // Статические члены для установки/получения процентной ставки,
        public static void SetlnterestRate(double newRate) => currlnterestRate = newRate;
        public static double GetlnterestRate() { return currlnterestRate; }
    }
}
