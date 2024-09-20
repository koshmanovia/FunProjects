using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
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
        //определяем тип делегада
        public delegate void CarEngineHandler(string msgForCaller);
        //определяем переменную-член этого типа делегата
        private CarEngineHandler listOfHandlers;
        //добавляем регистрационную функцию для вызывающего кода
        public void RegisterWithCarEngine(CarEngineHandler methodToCall) 
        {
            listOfHandlers += methodToCall;
        }
        //реализовываем метод accelerate() для обращения к списку
        //вызовов делегата в подходящих обстоятельствах
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }
        public void Accelerate(int delta)
        {
            //сообщение о поломке автомобиля
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry, this car is dead...");
                }
            }
            else 
            {
                CurrentSpeed += delta;
                //Автомобиль почти сломан?
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                    Console.WriteLine("CurrentSpeed ={0}", CurrentSpeed);
            }
        }
    }
}
