using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //работа с action
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Before Any Text!", ConsoleColor.DarkBlue, 6);
            Console.WriteLine("After Any Text!");
            //работа с func
            Func<int,int,int>funcTarget= Add;
            Func<int, int, string> funcString = SumToString;

            Console.WriteLine(funcTarget(1, 2));
            Console.WriteLine(SumToString(2, 3));

            Console.ReadLine();
        }
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //Установить цвет текста консоли
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
