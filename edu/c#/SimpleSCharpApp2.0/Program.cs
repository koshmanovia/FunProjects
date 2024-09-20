using System;
using System.Windows.Forms;

namespace SimpleCSharpApp
{
    class Program
    {       
        public static int Main()
        {
            Console.Title = "My Hacking App";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("***********************************");
            Console.WriteLine("*****Welcome to My Hacking App*****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;           
            string[] theArgs = Environment.GetCommandLineArgs();
            ShowEnvironmentDetails();

            foreach (String arg in theArgs)
            {
                Console.WriteLine($"Arg {arg}");
            }
            Console.ReadKey();
            return -1;
            
        }
        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive {0}", drive);

            Console.WriteLine("OS {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version {0}", Environment.Version);
        }
    }
}
