using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine();

            UseGenericStack();
            Console.WriteLine();

            UseGenericQueue();
            Console.WriteLine();

            UseSortedSet();
            Console.WriteLine();

            UseDictionary();
            Console.WriteLine();

            Console.ReadLine();
        }
        static void UseGenericList()
        {
            //Создать список объектов Person и заполнить его с помощью
            //синтаксиса инициализации объектов и коллекции
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Homer", LastName="Simpson", Age=47},
                new Person { FirstName = "Marge", LastName="Simpson", Age=45},
                new Person { FirstName = "Lisa", LastName="Simpson", Age=9},
                new Person { FirstName = "Bart", LastName="Simpson", Age=8},               
            };
            //Выводим количество эллементов в списке
            Console.WriteLine("Items in List: {0}", people.Count);
            //перечисление в списке
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            //добавляем новый элемент в список
            Console.WriteLine("\n-> Inserting new Person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Item in list: {0}", people.Count);
            //копируем данные в новый массив
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in people)
            {
                Console.WriteLine($"First Nmaes: {p.FirstName}");
            }
        }
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            stackOfPeople.Push(new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });
            stackOfPeople.Push(new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            for (int i = stackOfPeople.Count; i >= 0; i--)
            {
                try
                {
                Console.WriteLine("\nfirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Pooped off {0}", stackOfPeople.Pop());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("\nError! {0}", ex.Message); // ошибка стек пуст
                }
            }   
        }
        static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee!");
        }
        static void UseGenericQueue()
        {
            //Создадим очередь
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            peopleQ.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });
            peopleQ.Enqueue(new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

            //возвращает первого в очереди
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            //Удаляем всех из очереди
            for (int i = peopleQ.Count; i > -1; i--)
            {
                try
                {
                    GetCoffee(peopleQ.Dequeue());
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine("Error! {0} ",ex.Message);
                }
            }
        }
        static void UseSortedSet()
        {
            // Создать несколько объектов Person с разными значениями возраста.
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
        {
            new Person {FirstName= "Homer", LastName="Simpson", Age=47},
            new Person {FirstName= "Marge", LastName="Simpson", Age=45},
            new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
            new Person {FirstName= "Bart", LastName="Simpson", Age=8}
        };
            // Обратите внимание, что элементы отсортированы по возрасту.
            foreach (Person р in setOfPeople)
            {
                Console.WriteLine(р);
            }
            Console.WriteLine();
            // Добавить еще несколько объектов Person с разными значениями возраста.
            setOfPeople.Add(new Person
            {
                FirstName = "Saku",
                LastName = "Jones",
                Age = 1
            });
            setOfPeople.Add(new Person
            {
                FirstName = "Mikko",
                LastName = "Jones",
                Age = 32
            });
            // Элементы по-прежнему отсортированы по возрасту.
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
        private static void UseDictionary()
        {
            // Наполнить с помощью метода Add().
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Age = 47
            });
            peopleA.Add("Marge", new Person
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Age = 45
            });
            peopleA.Add("Lisa", new Person
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Age = 9
            });
            // Получить элемент с ключом Homer.
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);
            // Наполнить с помощью синтаксиса инициализации.
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47} },
                {"Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
                {"Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
            };
            // Получить элемент с ключом Lisa.
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };
            Person Marge = peopleC["Marge"];
            Console.WriteLine(Marge);
        }
    }    
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if (firstPerson?.Age > secondPerson?.Age)
            {
                return 1;
            }
            if (firstPerson?.Age < secondPerson?.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
