using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
   partial class Employee
    {
        // Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        string empSSN;

        // Конструкторы.
        public Employee() { }
        public Employee(string name, int id, float pay, )
            : this(name, 0, id, pay, null) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = id;
            Pay = pay;
            Age = age;
            // Проверить надлежащим образом входной параметр ssn и затем установить значение.
            empSSN = ssn;
        }

    }

}
