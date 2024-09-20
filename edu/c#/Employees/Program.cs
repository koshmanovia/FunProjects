using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();
            chucky.GiveBonus(11556);
            chucky.Displaystats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(3124);
            fran.Displaystats();
            Console.WriteLine();

            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }
                    Console.ReadLine();
        }
        static void CastingExamples()
        {
            // Manager "является" System.Object, поэтому в переменной
            // типа object можно сохранять ссылку на Manager.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            // PTSalesPerson "является" Salesperson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(moonUnit);
            GivePromotion(jill);
            GivePromotion((Manager)frank);

        }
        static void GivePromotion(Employee emp)
        {            
            // Повысить зарплату...
            // Предоставить место на парковке компании...
            Console.WriteLine("{0} was promoted!", emp.Name);

            switch (emp)
            {
                case SalesPerson s when s.SalesNumber >5:
                    Console.WriteLine("{0} made {1} sale(s)!\n", emp.Name, s.SalesNumber);
                    Console.WriteLine("Nise Work!");
                    break;

                case SalesPerson s when s.SalesNumber > 1:
                    Console.WriteLine("{0} made {1} sale(s)!\n", emp.Name, s.SalesNumber);
                    Console.WriteLine("Good Work!");
                    break;
                case SalesPerson s when s.SalesNumber > 0:
                    Console.WriteLine("{0} made {1} sale(s)!\n", emp.Name, s.SalesNumber);
                    Console.WriteLine("Bad Job!");
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...\n", emp.Name, m.StockOptions);
                    break;
                case Intern _:
                    //Игнорим практиков
                    break;
                case null:
                    Console.WriteLine("Error Value is null");
                    break;
            }
        }
    }
}
