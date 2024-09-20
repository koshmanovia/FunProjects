using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Tuples *****\n");
            Console.WriteLine("=> First Example");
            (string, int, string) values = ("a", 5, "c");
            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine();
            Console.WriteLine("=> Using Named Properties");
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            //По прежнему работает itemX!
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            Console.WriteLine();
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
            Console.WriteLine($"First item: {valuesWithNames2.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames2.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames2.SecondLetter}");
            Console.WriteLine();
            (int Field1, int Field2) example = (Custom1: 5, Custom2: 7);
            // Console.WriteLine($"First item: {example.custom1}"); - не скопилируется т.к. обьявлено слева
            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
            Console.WriteLine($"{bar.Item1};{bar.Item2}");

            Console.WriteLine("=> Tuples as Return Values");
            var samples = FillTheseValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");
            Console.WriteLine();

            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first} {last}");
            Console.WriteLine();


            Console.WriteLine("=> Deconstructing Tuples");
            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();
            Console.WriteLine($"X is: {pointValues.Item1}");
            Console.WriteLine($"Y is: {pointValues.YPos}");
            Console.WriteLine();

            Console.ReadLine();
        }
        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            //код необходимый для расщепления
            return ("Philip", "F", "Japikse");
        }
        struct Point
        {
            // Поля структуры.
            public int X;
            public int Y;

            // Специальный конструктор.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }
    }
}
