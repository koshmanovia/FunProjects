using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEventsArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers.
            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.Exploded -= CarExploded;

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if(sender is Car c)
            {
                c = (Car)sender;
                Console.WriteLine($"Critical Message from {sender}: {e.msg}");
            }           
        }
        public static void CarExploded(object sender, CarEventArgs e)
        { Console.WriteLine(e.msg); }
    }
}
