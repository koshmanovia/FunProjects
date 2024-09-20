using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager() { }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
        : base(fullName, age, empID, currPay, ssn)
        {
            //Это свойство определенно в классе Manager.
            StockOptions = numbOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
    }
}
