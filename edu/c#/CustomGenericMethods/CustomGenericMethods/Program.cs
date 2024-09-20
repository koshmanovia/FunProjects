using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");

            int a = 10, b = 20;
            Console.WriteLine($"Before swap:\na = {a}, b = {b}");
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap:\na = {a}, b = {b}\n");

            String s1 = "one", s2 = "two";
            Console.WriteLine($"Before swap:\ns1 = {s1}, s2 = {s2}");
            MyGenericMethods.Swap<String>(ref s1, ref s2);
            Console.WriteLine($"After swap:\ns1 = {s1}, s2 = {s2}\n");

            //При вызове обобщенного метода, параметр типа можно опускать
            //Пример плохого кода
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine($"Before swap:\nb1 = {b1}, b2 = {b2}");
            MyGenericMethods.Swap(ref b1, ref b2);           
            Console.WriteLine($"After swap:\nb1 = {b1}, b2 = {b2}");


            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<String>();
            MyGenericMethods.DisplayBaseClass<bool>();
            Console.ReadLine();
        }        
    }
    public static class MyGenericMethods
    {
       public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }
       public static void DisplayBaseClass<T>()
        {
            //BaseType будет описан в главе 15
            Console.WriteLine("Base class of {0} is: {1}", typeof(T), typeof(T).BaseType);
        }
    }
}
