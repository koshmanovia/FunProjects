using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticLINQwithParsing
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MinMaxSumAverage(@"C:\MyProg\VS\projects\Apress\udemy\c#\PracticLINQwithParsing\PracticLINQwithParsing\top100ChessGamer.cvs");
            Console.ReadLine();
        }
        static void LinqDemo(string file)
        {
            IEnumerable<ChessPlayer> list = File.ReadAllLines(file)
                                               .Skip(1)
                                               .Select(ChessPlayer.ParseFideCsv)
                                               .Where(player => player.BirthYear > 1988)
                                               .OrderByDescending(player => player.Rating)
                                               .Take(10)
                                               .ToList();
            Console.WriteLine($"The lowest rating in TOP 10 {list.Min(x => x.Rating)}");
            Console.WriteLine($"The lowest rating in TOP 10 {list.Max(x => x.Rating)}");
            Console.WriteLine($"The lowest rating in TOP 10 {list.Average(x => x.Rating)}");
        }
        static void MinMaxSumAverage(string file)
        {
            IEnumerable<ChessPlayer> list =  File.ReadAllLines(file)
                                               .Skip(1)
                                               .Select(ChessPlayer.ParseFideCsv)
                                               .Where(player => player.BirthYear > 1988)
                                               .OrderByDescending(player => player.Rating)
                                               .Take(10)
                                               .ToList();
            Console.WriteLine($"The lowest rating in TOP 10 {list.Min(x=>x.Rating)}");
            Console.WriteLine($"The lowest rating in TOP 10 {list.Max(x => x.Rating)}");
            Console.WriteLine($"The lowest rating in TOP 10 {list.Average(x => x.Rating)}");
        }
    }
}
