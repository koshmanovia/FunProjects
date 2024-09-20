using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_test
{
    public static class LINQExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            foreach (var item in source)
            {
                action(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("not linq");
            DisplayLargestFileWithoutLinq(@"C:\Users\k0shm\Downloads");
            Console.WriteLine("\nwith linq");
            DisplayLargestFileWithLinq(@"C:\Users\k0shm\Downloads");
            Console.ReadLine();
        }

        public static void DisplayLargestFileWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderByDescending(file => file.Length)
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} weights {file.Length}"));
        }


        #region Без LINQ
        public static void DisplayLargestFileWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();
            Array.Sort(files, FilesComparison);
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }

        private static int FilesComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }
        #endregion
    }
}
