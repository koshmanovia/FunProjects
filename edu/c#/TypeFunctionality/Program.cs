using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TypeFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFunctionality();
            DataTypeFunctionality();
            BoolFunctionality();
            CharFunctionality();
            ParseFromString();
            ParseFromStringWithTryParse();
            UseDatesAndTimes();
            UseBigInteger();
            DigitSeparators();
            BinaryLiterals();
            Console.ReadLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:\n");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("\n=> Data type Functionality:\n ");
            Console.WriteLine("max of int = {0}", int.MaxValue);
            Console.WriteLine("min of int = {0}", int.MinValue);
            Console.WriteLine("max of double = {0}", double.MaxValue);
            Console.WriteLine("min of double = {0}", double.MinValue);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

        }
        static void BoolFunctionality()
        {
            Console.WriteLine("\n=> bool data type:\n");
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
           
        }
        static void CharFunctionality()
        {
            Console.WriteLine("\n=> char data type:\n");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit(myChar): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter(myChar): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace(\"Hello There\", 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        }
        static void ParseFromString()
        {
            Console.WriteLine("\n=> Data type parsing\n");
            bool b = bool.Parse("True");
            double d = double.Parse("99,884");
            int i = int.Parse("8");
            char c = char.Parse("w");
            Console.WriteLine("Value of b: {0}\nValue of d: {1}\nValue of i: {2}\nValue of c: {3}",b,d,i,c);
        }
        static void ParseFromStringWithTryParse()
        {
            Console.WriteLine("\n=> Data type parsing with TryParse:\n");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}\n", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double\n", value);
            }
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("\n=> Dates and Times\n");
            //Этот конструктор принимает год, месяц и день
            DateTime dt = new DateTime(2015, 10, 17);
            //Какой сейчас день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date,dt.DayOfWeek);
            //Сейчас месяц декабрь
            dt = dt.AddMonths(2);
            Console.WriteLine("Days savings: {0}",dt.IsDaylightSavingTime());
            //Этот конструктор принимает часы, минуты и секунды
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            //Вычесть 15 минут из текущего значения  TimeSpan и вывести результат
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15,0)));
        }
        static void UseBigInteger()
        {
            Console.WriteLine("\n=> BigInteger: \n");
            BigInteger biggy = BigInteger.Parse("88888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888");
            Console.WriteLine("Value of biggy is {0}", biggy);//значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);//bigge четное?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);//степень biggy 2
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"));
            reallyBig = reallyBig * biggy;
            Console.WriteLine("Value of reallyBig is {0}",reallyBig);
        }
        static void DigitSeparators()
        {
            var i = 123_456;
            long l = 123_456_789L;
            float f = 123_456.12346789f;
            double d = 123_456.123456;
            decimal dec = 123_456.12M;
                        
            Console.WriteLine("\n=> Use Digit Separators:\n");
            Console.WriteLine("Integer:");
            Console.WriteLine(i);
            Console.WriteLine("Long");
            Console.WriteLine(l);
            Console.WriteLine("Float");
            Console.WriteLine(f);
            Console.WriteLine("Double");
            Console.WriteLine(d);
            Console.WriteLine("Decimal");
            Console.WriteLine(dec);
        }
        private static void BinaryLiterals()
        {
            Console.WriteLine("=> Use Binary Literals");
            Console.WriteLine("Шеснадцать: {0}", 0b0001_0000);
            Console.WriteLine("Тридцать два: {0}", 0b0010_0000);
            Console.WriteLine("Шестьдесят четыре: {0}", 0b0100_0000);
        }
    }
}
