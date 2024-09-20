using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollectons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            List<Car> myCar = new List<Car>()
            {
                new Car() {PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car() {PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car() {PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car() {PetName = "Clunker", Color = "Rust", Speed = 5, Make = "YUGO"},
                new Car() {PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            GetFastCars(myCar);
            Console.ReadLine();
        }
        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 55 && c.Make == "BMW" select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast" , car.PetName);
            }
        }
        static void LINQOverArrayList()
        {
            Console.WriteLine("***** LINQ over ArrayList *****");
            ArrayList myCar = new ArrayList()
            {
                new Car() {PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car() {PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car() {PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car() {PetName = "Clunker", Color = "Rust", Speed = 5, Make = "YUGO"},
                new Car() {PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            //преобразование ArrayList в тип совместимый с IEnumerable<T>
            var myCarsEnum = myCar.OfType<Car>();
            //выражение совместимое с IEnumerable<t>
            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast", car.PetName);
            }
        }

    }
    class Car
    {
        public string PetName { get; set; } = "";
        public string Color { get; set; } = "";
        public int Speed { get; set; }
        public string Make { get; set; } = "";
    }
}
