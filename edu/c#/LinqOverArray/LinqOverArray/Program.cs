using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to objects *****\n");
            QueryOverStringsWithExtensionMethods();
            Console.WriteLine();
            QueryOverStrings();
            Console.ReadLine();
        }
        static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            //Построить выражение запроса для нахождения 
            //элементов массива, которые содержат пробелы
            IEnumerable<String> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;
            ReflectOverQueryResults(subset);
            foreach (string s in subset)
            {
                Console.WriteLine($"Item: {s}");
            }
        }
        static void QueryOverStringsWithExtensionMethods()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            IEnumerable<String> subset = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);
            ReflectOverQueryResults(subset, "Extension Expressions");
            foreach (string s in subset)
            {
                Console.WriteLine($"Item: {s}");
            }
        }
        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"***** Info about your query using {queryType}");
            //Вывести тип результируещего набора
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            //Вывести местоположение результирующего набора
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);


        }
    }
}
