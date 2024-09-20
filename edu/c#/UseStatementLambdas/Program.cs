using System;
using System.Collections.Generic;

//Объявить тип делегата
delegate string StrMod(string str);
class DelegateTest
{
    static void Main()
    {
        //Сконструировали делегаты
        //StrMod strOp;

        StrMod strReplaceSP = s =>
            {
                Console.WriteLine("Замена пробелов дефисами");
                return s.Replace(' ', '-');
            };

        StrMod strRemoveSP = s =>
        {
            Console.WriteLine("Удаление пробелов");
            string temp = "";
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != '-')
                {
                    temp += s[i];
                }
            }
            return temp;
        };

        StrMod strReverce = s =>
        {
            string temp = "";
            int i, j;

            Console.WriteLine("Обращение строки");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            {
                temp += s[i];
            }           
            return temp;
        };
        /*  string str = "Это простой тест";

          //Вызвать методы с помощью делегата
          strOp = strReplaceSP;
          strOp += strReverce;

          //Обратится к групповому делегату
          strOp(str);
          Console.WriteLine($"Результирующая строка: {str}\n");
          //удалить метод замены пробелов и добавить метод удаления пробелов
          strOp -= strReplaceSP;
          strOp += strRemoveSP;

          //снова обратимся к групповому делегату
          strOp(str);
          Console.WriteLine($"Результирующая строка: {str}\n");*/
        StrMod strOp = strReplaceSP;        
        string str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
        strOp = strRemoveSP;
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
        strOp = strReverce;
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.ReadKey();
    }
}
