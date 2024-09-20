using System;
delegate int CountIt(int i);
class AnonMethDemo3
{
    static void Main()
    {
        int result = 0;
        CountIt count =
            delegate (int end)
            {
                int sum = 0;
                // Этот кодовый блок передается делегату.
                for (int i = 0; i <= end; i++)
                {
                    sum += i;
                }
                return sum;
            }; // обратите внимание на точку с запятой
        //Так же для удобства код можно записать так
        //CountIt count1 = delegate { for (int i = 0; i <= 5; i++) { Console.WriteLine(i); } }; 
        result = count(3);
        Console.WriteLine("Сумма 3 равна:  {0}", result);
        result = count(5);
        Console.WriteLine("Сумма 5 равна:  {0}", result);
        Console.ReadLine();
    }

}