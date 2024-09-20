using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your surname");
            string surname = Console.ReadLine();   
            Console.WriteLine("Input your name");
            string name = Console.ReadLine();
            Console.WriteLine("Input your age");
            string age = Console.ReadLine();
            Console.WriteLine("Input your weight kg");
            string weight = Console.ReadLine(); 
            Console.WriteLine("Input your height meter's");
            string height = Console.ReadLine(); 

            double IMT = double.Parse(weight) / (double.Parse(height) * double.Parse(height));
            
            Console.WriteLine($"Your Profile:\n" +
                $"Fill name: {surname}, {name}\n" +
                $"Age: {age}\n" +
                $"Weight: {weight}\n" +
                $"Height: {height}\n" +
                $"Body Mass Index: {IMT:f2}");
            Console.ReadLine();
        }
    }
}
