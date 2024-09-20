using System;
delegate ulong IntOp(ulong end);
class StatementLambdaDemo
{
    static void Main(string[] args)
    {
        //Блочное лямбда-выражение возвращает факториал
        //передаваемоего ему значания
        IntOp fact = n =>
        {
            ulong r = 1;
            for (int i = 1; i <= (int)n; i++)
            {
                r = (ulong)i * r;
            }
            return r;
        };
        Console.WriteLine($"Факториал 3 равен: {fact(3)}");
        Console.WriteLine($"Факториал 5 равен: {fact(5)}");
        Console.WriteLine($"Факториал 55 равен: {fact(55)}");
        Console.ReadLine();
    }
}

