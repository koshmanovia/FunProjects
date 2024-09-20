using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Car
    {
        //Данные состояния.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName{ get; set; }

        //Исправен ли автомобиль?
        private bool carIsDead;
        //КОнструкторы класса
        public Car() { }
        public Car(string name, int MaxSpd, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = MaxSpd;
            PetName = name;
        }
        //определяем тип делегада и событий
        public delegate void CarEngineHandler(string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        public void Accelerate(int delta)
        {
            //Если автомобиль сломан инициализировать событие Exploded
            if (carIsDead)
            {
                //if (Exploded != null){Exploded("Sorry, this car is dead...");}
                //Запись ниже функционально идентична записи выше.
                Exploded?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                //Почти сломан?
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }            
        }
    }
}
