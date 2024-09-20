using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwichCase
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElseExample();
            ExecutelfElseUsingConditionalOperator();
            SwitchExample();
            SwitchOnEnumExample();
            ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchWithWhen();
            Console.ReadLine();
        }
        static void IfElseExample()
        {
            // Недопустимо, т.к. свойство Length возвращает int, а не bool,
            string stringData = "Му textual data";
            if (stringData.Length > 0)
            {
                // Строка длиннее 0 символов
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                // Строка не длиннее 0 символов
                Console.WriteLine("string is not greater than 0 characters");
            }
            Console.WriteLine();
        }
        private static void ExecutelfElseUsingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");
            Console.WriteLine();
        }
        // Переход на основе числового значения,
        static void SwitchExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");
            // Выберите предпочитаемый язык:
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    // VB: ООП, многопоточность и многое другое!
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    // Хорошо, удачи с этим!
                    break;
            }
        }
        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            // Введите любимый день недели:
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input! ");
                // Недопустимое входное значение!
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    // Футбол!!
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar.");
                    // Еще один день, еще один доллар.
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday.");
                    //Во всяком случае, не понедельник.
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    // Хороший денек.
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    // Почти пятница...
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    //Да, пятница рулит!
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    // Действительно великолепный день.
                    break;
            }
            Console.WriteLine();
        }
        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal(2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;
            // Стандартный оператор switch, в котором применяется
            // сопоставление с образцом с константами
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }
            // Новый оператор switch, в котором применяется
            // сопоставление с образцом с типами
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}.", i);
                    // Выбрано целое число
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string {0}.", s);
                    // Выбрана строка
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}.", d);
                    // Выбрано десятичное число
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    // Выбрано что-то другое
                    break;
            }
            Console.WriteLine();

        }
        static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    // VB: ООП, многопоточность и многое другое!
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    // Хороший выбор. C# - замечательный язык.
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    // Хорошо, удачи с этим!
                    break;
            }
            Console.WriteLine();
        }
    }
}

