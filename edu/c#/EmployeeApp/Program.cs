using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.Displaystats();
            // Использовать методы get/set для взаимодействия
            // с именем сотрудника, представленного объектом,
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);                    
           
            Employee emp2 = new Employee();
            emp2.SetName("Xena the warrior princess");

            Employee joe = new Employee();
            joe.Age++;

            Console.ReadLine();
        }
    }
}
