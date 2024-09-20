using System;
delegate int Incr(int v);
delegate bool IsEven(int v);
class SimpleLambdaDemo
{
    static void Main(string[] args)
    {
        Incr incr = count => count + 2;
        IsEven isEven = result => (result % 2 == 0);
        Incr decr = count => count - 2;
        int x = 0;
        Console.WriteLine("Использование лямбда выражения incr: ");
        x = -10;
        while (x <= 0)
        {
            Console.Write($"{x}\t");
            x=incr(x);
        }
        Console.WriteLine("\n");

        Console.WriteLine("Использование лямбда выражения decr: ");
        x = 10;
        while (x >= 0)
        {
            Console.Write($"{x}\t");
            x = decr(x);
        }
        Console.WriteLine("\n");

        Console.WriteLine("Использование лямбда выражения isEven: ");
        for (int i = 1; i <= 11; i++)
        {
            if (isEven(i))
            {
                Console.WriteLine($"{i} четное");
            }
            else
            {
                Console.WriteLine($"{i} нечетное");
            }
        }
        Console.ReadLine();
    }
}

