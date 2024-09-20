using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Запросить имя пользователя. Вывести Hello, [имя пользователя].
            Console.WriteLine( "Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

            //2.Запросить у пользователя два целых числа и сохранить в двух переменных.
            //Вывести значения.
            //Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5,
            //сделать так, чтобы в y стало 3, а в x стало 5.Вывести значения после обмена.
            Console.WriteLine("Введите два целых числа ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" number one = {0}, number two = {1}", a, b);
            int tempInt = a;
            a = b;
            b = tempInt;
            Console.WriteLine(" number one = {0}, number two = {1}", a, b);

            //3.Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.

            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            Console.WriteLine(s.Length);
            Console.ReadLine();
        }
    }
}
