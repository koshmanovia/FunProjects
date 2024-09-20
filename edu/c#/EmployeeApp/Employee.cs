using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {

        //свойства
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


        // Методы.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void Displaystats()
        {
            Console.WriteLine("Name: {0}", Name); // имя сотрудника
            Console.WriteLine("ID: {0}", ID); // идентификационный номер сотрудника
            Console.WriteLine("Age: {0}", Age); 
            Console.WriteLine("Pay: {0}", Pay);// текущая выплата
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

