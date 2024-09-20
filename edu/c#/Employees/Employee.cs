using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   abstract partial class Employee
    {
        //свойства
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            // Предположим, что есть другие члены, представляющие
            // медицинские/стоматологические программы и т.д.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
       
        public string Name
        {
            get => empName; 
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else { empName = value; }
            }
        }
        public int ID
        {
            get => empID; 
            set => empID = value;
        }
        public float Pay
        {
            get => currPay; 
            set => currPay = value;
        }
        public int Age
        {
            get => empAge; 
            set => empAge = value; 
        }
        // Открывает доступ к объекту через специальное свойство,
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        // Открывает доступ к некоторому поведению, связанному со льготами,
        public double GetBenefitCost() 
        {
            return empBenefits.ComputePayDeduction();
        }         
        // Методы.
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public virtual void Displaystats()
        {
            Console.WriteLine("Name: {0}", Name); // имя сотрудника
            Console.WriteLine("ID: {0}", ID); // идентификационный номер сотрудника
            Console.WriteLine("Age: {0}", Age); 
            Console.WriteLine("Pay: {0}", Pay);// текущая выплата
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
        // Метод доступа (метод get) .
        public string GetName()
        {
            return empName;
        }
        // Метод изменения (метод set) .
        public void SetName(string name)
        {
            // Перед присваиванием проверить входное значение,
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            // Ошибка' Длина имени превышает 15 символов!
            else
                Name = name;
        }
    }
}

