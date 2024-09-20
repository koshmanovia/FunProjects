using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FunWithObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Observable Collections *****\n");
            //Сделать коллекцию наблюдаемой и добавить в нее несколько объектов Person
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            { 
                new Person { FirstName = "Peter", LastName = "Murphy", Age = 52},
                new Person { FirstName = "Kevin", LastName = "Key", Age = 48 },
            };
            //Привязать к событию CollectionChanged.
            people.CollectionChanged += people_CollectionChanged;
            
            people.Add(new Person("Fred", "Smith", 32));
            people.RemoveAt(0);
            Console.ReadLine();
        }
        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Определение действия, которое привело к генерации события
            Console.WriteLine("Action for this event: {0}", e.Action);
            //Проверка на удаленные элементы
            if(e.Action ==System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems) 
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            //Проверка на добавленные элементы
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }            
        }
    }
}
