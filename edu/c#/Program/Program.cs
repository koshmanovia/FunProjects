using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            //получение информации от пользователя
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            //баловство с цветами
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //вывод информации на экран
            Console.Clear();
            Console.WriteLine($"Hello {userName}! You are {userAge} year old.");
            Console.ForegroundColor = prevColor;

        }
    }
}
