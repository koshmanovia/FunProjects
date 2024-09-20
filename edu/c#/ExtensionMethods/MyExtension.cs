using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtension
    {
        // Этот метод позволяет объекту любого типа
        // отобразить сборку, в которой он определен..
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}"
                , obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }
        // Этот метод позволяет любому целочисленному значению изменить порядок
        // следования десятичных цифр на обратный. Например, для 56 возвратится 65.
        public static int ReverseDigits(this int i)
        {
            // Транслировать int в string и затем получить все его символы.
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);

            //поместить обратно в строку
            string newDigits = new string(digits);

            //Возвратить модифицированную строку как int                      
            return int.Parse(newDigits);
        }
    }
}
