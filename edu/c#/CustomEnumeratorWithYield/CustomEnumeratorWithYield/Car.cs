using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Car
    {
        // Константа максимальной скорости
        public const int MaxSpeed = 220;
        // свойства автомобиля
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // не вышел ли автомобиль из строя
        private bool carIsDead;

        // в автомобиле имеется радиоприемник
        private Radio theMusicBox = new Radio();

        // Конструкторы
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            // Делегировать запрос внутреннему объекту
            theMusicBox.TurnOn(state);
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
    }
}
