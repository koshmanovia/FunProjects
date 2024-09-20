using System;
delegate void CountIt(int i);
class AnonMethDemo2
{
    static void Main()
    {
        // Далее следует код для подсчета чисел, передаваемый делегату
        // в качестве анонимного метода.
        CountIt count =
            delegate (int end)
            {
                // Этот кодовый блок передается делегату.
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }; // обратите внимание на точку с запятой
        //Так же для удобства код можно записать так
        //CountIt count1 = delegate { for (int i = 0; i <= 5; i++) { Console.WriteLine(i); } }; 
        count(3);
        count(5);
        Console.ReadLine();
    }

}