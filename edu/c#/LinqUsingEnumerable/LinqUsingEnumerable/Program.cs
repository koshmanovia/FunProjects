using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Dexter", "System Shock 2" };
            QueryStringWithOperators(currentVideoGames);
            System.Console.WriteLine();
            QuerySttringWithEnumerableAndLambdas(currentVideoGames);
            Console.WriteLine();
            QueryStringsWithEnumerableAndLambdas2(currentVideoGames);
            Console.WriteLine();
            QueryStringsWithAnonymousMethods(currentVideoGames);
            Console.WriteLine();
            VeryComplexQueryExpression.QueryStringsWithRawDelegates(currentVideoGames);
            Console.WriteLine();
            Console.ReadLine();
        }

        static void QueryStringWithOperators(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Query Operators*****\n");
            var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        static void QuerySttringWithEnumerableAndLambdas(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****\n");
            //Построить выражение запроса с использование расширяемых методов,
            //Предоставленных типу Array  через тип Enumerable 
            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }
        }
        static void QueryStringsWithEnumerableAndLambdas2(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions 2*****\n");
            // Разбить на части.
            var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }
        static void QueryStringsWithAnonymousMethods(string[] currentVideoGames)
        {
            Console.WriteLine("***** Using Anonymous Methods *****");
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate (string s) { return s; };
            // Передать делегаты в методы класса Enumerable.
            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
            // Вывести результаты,
            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }
            Console.WriteLine();
        }
        class VeryComplexQueryExpression
        {
            public static void QueryStringsWithRawDelegates(string[] currentVideoGames)
            {
                Console.WriteLine("***** Using Raw Delegates *****");
                // Построить необходимые делегаты Funco.
                Func<string, bool> searchFilter = new Func<string, bool>(Filter);
                Func<string, string> itemToProcess = new Func<string, string>(Processltem);
                // Передать делегаты в методы класса Enumerable.
                var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
                // Вывести результаты
                foreach (var game in subset)
                {
                    Console.WriteLine("Item: {0}", game);
                }
                Console.WriteLine();
            }
            // Цели делегатов.
            public static bool Filter(string game) { return game.Contains(" "); }
            public static string Processltem(string game) { return game; }
        }

    }

}

