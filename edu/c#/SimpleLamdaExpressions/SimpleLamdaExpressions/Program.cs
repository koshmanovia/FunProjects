using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLamdaExpressions
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****");
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            Console.WriteLine();
            LambdaExpressionSyntax();
            Console.ReadLine();
        }
        static void TraditionalDelegateSyntax()
        {
            //Создать список целочисленных значений.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44, 33, 22, 453 });
            //Вызвать FindAll() с применением традиционного синтаксиса делегатов
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t",evenNumber);
            }
        }
        //Метод класса System.Collections.Generic.List<T>.
        static public bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
        /*public List<T> FindAll(Predicate<T> match)
        {
            
        }*/
        static void AnonymousMethodSyntax()
        {
            //Создать список целочисленных значений.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44, 33, 22, 453 });
            
            //теперь использовать анонимный метод            
            List<int> evenNumbers = list.FindAll(
                delegate (int i) 
                { 
                    return (i % 2) == 0; 
                });           

            Console.WriteLine("\nHere are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
        static void LambdaExpressionSyntax()
        {
            //Создать список целочисленных значений.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44, 33, 22, 453 });
            //теперь использовать анонимный метод
            //List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });
            //тоже самое что и анонимный метод но с использованием лямда выражения
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine($"value of i is currently: {i}");
                bool isEven = ((i % 2) == 0);
                return isEven;
            });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
    }

}
