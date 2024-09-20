﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Object Sorting *****\n");
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            Console.WriteLine("Here is the unordered set of cars:");
            foreach(Car c in myAutos)
            { Console.WriteLine("{0} {1}", c.CarID, c.PetName); }

            Array.Sort(myAutos);
            Console.WriteLine();

            Console.WriteLine("Here is the ordered set of cars:");
            foreach (Car c in myAutos)
            { Console.WriteLine("{0} {1}", c.CarID, c.PetName); }

            Array.Sort(myAutos, new PetNameComparer());
            Console.WriteLine("Here is the ordered set of cars:");
            foreach (Car c in myAutos)
            { Console.WriteLine("{0} {1}", c.CarID, c.PetName); }

            Console.ReadLine();
        }
    }
}
