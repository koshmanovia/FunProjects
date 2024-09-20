using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string petName;
        public int currSpeed;
        public void PrintState() => Console.WriteLine("{0} is going {1} KMH.", petName, currSpeed);
        public void Speedup(int delta) => currSpeed += delta;
        public Car()
        {
            petName = "Chuck Norris";
            currSpeed = 9999;
        }
        public Car(string pn) => petName = pn;
            // Позволяет вызывающему коду установить полное состояние объекта Саr.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
    }
}
