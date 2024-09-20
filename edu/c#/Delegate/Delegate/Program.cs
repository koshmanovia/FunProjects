using System;
using System.Collections.Generic;

//Объявить тип делегата
delegate void StrMod(ref string str);
class MultiCastDemo
{
    public static void ReplaseSpaces(ref string s)
    {
        Console.WriteLine("Замена пробелов дефисами");
        s = s.Replace(' ', '-');
    }
    public static void RemoveSpaces(ref string s)
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
        s = temp;
    }
    public static void Reverce(ref string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("Обращение строки");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
        {
            temp += s[i];
        }
        s = temp;
    }

}
class DelegateTest
{  
    static void Main()
    {
        //Сконструировали делегаты
        StrMod strOp;
        StrMod strReplaceSP = MultiCastDemo.ReplaseSpaces;
        StrMod strRemoveSP = MultiCastDemo.RemoveSpaces;
        StrMod strReverce = MultiCastDemo.Reverce;         
        string str = "Это простой тест";

        //Вызвать методы с помощью делегата
        strOp = strReplaceSP;
        strOp += strReverce;

        //Обратится к групповому делегату
        strOp(ref str);
        Console.WriteLine($"Результирующая строка: {str}\n");
        //удалить метод замены пробелов и добавить метод удаления пробелов
        strOp -= strReplaceSP;
        strOp += strRemoveSP;

        //снова обратимся к групповому делегату
        strOp(ref str);
        Console.WriteLine($"Результирующая строка: {str}\n");

        Console.ReadKey();
    }
}

