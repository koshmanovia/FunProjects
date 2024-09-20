using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        //Приведение для вызывающего кода
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        //вставка только объектов Person
        public void AddPerson(Person p) => arPeople.Add(p);
        public void ClearPeople() => arPeople.Clear();       

        public int Count => arPeople.Count;

        public IEnumerator GetEnumerator()
        {
          return arPeople.GetEnumerator();
        }
    }
}
