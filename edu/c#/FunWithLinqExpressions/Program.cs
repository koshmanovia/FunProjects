using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Query Expressions * ****\n");
            // Этот массив будет основой для тестирования. . .
            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo {Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo {Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo {Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo {Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo
                    {Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo
                    {Name = "Classic Valpo Pizza", Description = "Everyone loves pizza'", NumberInStock = 73}
            };

            SelectEverything(itemsInStock);
            Console.WriteLine();

            ListProductNames(itemsInStock);
            Console.WriteLine();

            GetOverstock(itemsInStock);
            Console.WriteLine();

            GetNameAndDescriptions(itemsInStock);
            Console.WriteLine();

            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object о in objs)
            {
                Console.WriteLine(о); //Вызывает метод ToStringO на каждом анонимном объекте.
            }
            Console.WriteLine();

            GetCountFromQuery();
            Console.WriteLine();

            ReverseEverything(itemsInStock);
            Console.WriteLine();

            AlphabetizeProductNames(itemsInStock);
            Console.WriteLine();

            DisplayDiff();
            Console.WriteLine();

            Displaylntersection();
            Console.WriteLine();

            DisplayUnion();
            Console.WriteLine();

            DisplayConcat();
            Console.WriteLine();

            DisplayConcatNoDups();
            Console.WriteLine();

            AggregateOps();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void ListProductNames(ProductInfo[] products)
        {
            // Теперь получить только наименования товаров.
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;
            foreach (var n in names)
            {
                Console.WriteLine("Name: {0}", n);
            }
        }
        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");
            var overstock = from p in products where p.NumberInStock > 25 select p;
            foreach (ProductInfo c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }
        static void GetNameAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions");
            var nameDesc = from p in products select new {p.Name, p.Description};
            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new {p.Name, p.Description};
            // Отобразить набор анонимных объектов на объект Array,
            return nameDesc.ToArray();
        }
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};
            // Получить количество элементов из запроса.
            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();
            // Вывести количество элементов.
            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }
        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            // Получить названия товаров в алфавитном порядке,
            var subset = from p in products orderby p.Name descending select p;
            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void DisplayDiff()
        {
            List<string> myCars = new List<String> {"Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<String> {"BMW", "Saab", "Aztec"};
            var carDiff = (from c in yourCars select c).Except(from c2 in myCars select c2);
            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s); // Выводит Yugo.
        }
        static void Displaylntersection()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carlntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carlntersect)
            Console.WriteLine(s); // Выводит Aztec и BMW.
        }
        static void DisplayUnion()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
            {
                Console.WriteLine(s); 
            }
        }
        static void DisplayConcat()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Display Concat with Duplicate:");
            foreach (string s in carConcat)
            {
                Console.WriteLine(s);
            }
        }
        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Display Concat not Duplicate:");
            foreach (string s in carConcat.Distinct())
            {
                Console.WriteLine(s);
            }
        }
        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
            // Разнообразные примеры агрегации.
            // Выводит максимальную температуру:
            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());
            // Выводит минимальную температуру:
            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
            // Выводит среднюю температуру:
            Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average ());
            // Выводит сумму всех температур:
            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
        }
    }
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = ""; 
        public int NumberInStock { get; set; } = 0;
        public override string ToString() => $"Name = {Name}, Descnption = {Description}, Number in Stock = {NumberInStock}";
    }
}
