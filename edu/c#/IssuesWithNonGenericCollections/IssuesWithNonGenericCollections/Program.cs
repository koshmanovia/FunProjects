using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePersonCollection();

            Console.ReadLine();
        }
        static void SimpleBoxUnboxOperation()
        {
            //boxing запаковка данных
            //Создаем переменную ValueType(int)
            int myInt = 25;
            //Упаковать int в ссылку на объект
            object boxedInt = myInt;
            //unboxing 
            //Распоковываем int обратно из object
            //является явным преобразованием object
            //отличие в том, что не будет работать с другими  типами данных(long,short...)
            int unboxedInt = (int)boxedInt;
            //unboxing в несоответствующий тип
            try
            {
                long unboxLong = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("блок try-catch пройден");
            }
        }
        static void WorkWithArray()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(11);
            myInts.Add(12);

            //int i = myInts[1];
            //такой код работать не будет без явного преобразования
            //так как ArrayList не работает только с классом object
            int i = (int)myInts[1];
            Console.WriteLine("Value of your int: {0}",i);
        }
        static void ArrayListOfRandomObject()
        {
            ArrayList allMyObject = new ArrayList();
            allMyObject.Add(true);
            allMyObject.Add(10);
            allMyObject.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObject.Add(3.14);
        }
        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            //Ошибка компиляции
            //myPeople.AddPerson(new String());
            foreach (Person p in myPeople) { Console.WriteLine(p); }
        }
        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            //Этот объект List<> Может хранить только эллементы Person
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);
            //Этот объект List<> может хранить только целые числа
            List<int> moreInts = new List<int>();
            moreInts.Add(1);
            int sum = moreInts[0] + moreInts[1];

            moreInts.Add(2);

        }
    }
}
