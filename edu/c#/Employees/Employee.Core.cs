using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   abstract partial class Employee
    {
        // Поля данных.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();

        //Конструкторы
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, null) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }

        public Employee(string name, int age, int id, float pay, string ssn) :this(name, age, id, pay)
        {
            empSSN = ssn;
        }
    }

}
