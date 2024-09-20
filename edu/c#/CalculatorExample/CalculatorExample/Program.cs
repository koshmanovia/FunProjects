//cals.cs
using System;
namespace CalculatorExample
    //Класс точки входа в приложение
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine($"10 + 84 is {ans}.");
            //Ожидать нажатия пользователем клавиши <Enter> перед завершением работы
            Console.ReadLine();
        }
    }
    //Калькулятор C#
    class Calc
    {
        public int Add(int x, int y)
        { 
            return x  + y;
        }

    }
}
