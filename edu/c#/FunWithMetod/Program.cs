using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fun wint out
            Console.WriteLine("***** Fun with Methods: ***** \n");
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Add(x, y, out int ans);
            Console.WriteLine("Answer is: {0}", ans);
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            int i = default;
            string s = default;
            bool b = default;
            //FillTheseValues(out i,out s, out b);
            FillTheseValues(out _, out _, out _); //пример с отбрасыванием вывода
            Console.WriteLine("\nInt is: {0}\nString is: {1}\nbool is: {2}", i, s, b);
            #endregion
            #region Fun with ref
            string strl = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", strl, str2);
            SwapStrings(ref strl, ref str2);
            Console.WriteLine("After: {0}, {1} \n", strl, str2);
            #endregion
            #region Ref locals and params
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            ref var refoutput = ref SimpleRefReturn(stringArray, pos);
            refoutput = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            Console.WriteLine();
            #endregion
            #region Fun with params
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            // ... или передать массив значении double.
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            // Среднее из 0 равно О!
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            #endregion            
            #region необязательные параметры
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can’t find the payroll data", "CFO");
            #endregion
            #region Метод с использование именованных параметров
            Console.WriteLine();
            DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...",
                textColor: ConsoleColor.DarkBlue);
            #endregion
            Console.ReadLine();
        }
        static void Add(int x, int y, out int sum)
        {
            sum = x + y;
            // Вызывающий код не увидит эти изменения,
            // т.к. модифицируется копия исходных данных,
            x = 10000;
            y = 88888;
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        public static ref string SimpleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++) { sum += values[i]; }
            return (sum / values.Length);
        }
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Сохранить старые цвета для их восстановления после вывода сообщения.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Установить новые цвета и вывести сообщение.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Восстановить предыдущие цвета.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
