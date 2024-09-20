using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; }
        //public override int GetHashCode()
        //{
        //    return SSN.GetHashCode();
        //}
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override string ToString() => $"[First Name:{FirstName}; Last Name:{LastName}; Age {Age}]";
        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null) 
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }
        public Person(string fName, string IName, int personAge) 
        {
            FirstName = fName;
            LastName = IName;
            Age = personAge;
        }            
        public Person() { }
    }
}
