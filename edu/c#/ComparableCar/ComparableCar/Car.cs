using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparableCar
{
    class Car : IComparable
    {
        // Константа максимальной скорости
        public const int MaxSpeed = 220;
        public int CarID { get; set; }

        // свойства автомобиля
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // не вышел ли автомобиль из строя
        private bool carIsDead;
        // Конструкторы
        public Car() { }
        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }
        // Проверить не перегрелся ли автомобиль
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;
                    Exception ex = new Exception($"{PetName} Has overheated");
                    ex.HelpLink = "http://www.cars.ru";
                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot.");
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0} KMH", CurrentSpeed);
            }
        }
        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                if (this.CarID > temp.CarID)
                { return 1; }
                if (this.CarID < temp.CarID)
                { return -1; }
                else { return 0; }

            }
            else
                throw new ArgumentException("Parametr is not a Car!");
        }
    }
    public class PetNameComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            Car t1 = o1 as Car;
            Car t2 = o2 as Car;
            if (t1 != null && t2 != null)
            {
                return String.Compare(t1.PetName, t2.PetName);
            }
            else
                throw new ArgumentException("Parameter is not a Car!");
        }
    }
}
