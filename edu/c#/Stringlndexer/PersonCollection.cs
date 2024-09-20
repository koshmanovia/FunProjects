using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringlndexer
{
    class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();
        //Приведение для вызывающего кода
        public Person GetPerson(string name) => (Person)listPeople[name];
        //вставка только объектов Person
        public void AddPerson(string name, Person p) => listPeople.Add(name, p);
        public void ClearPeople() => listPeople.Clear();

        public int Count => listPeople.Count;

        public IEnumerator GetEnumerator() => listPeople.GetEnumerator();

        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }
    }
}

