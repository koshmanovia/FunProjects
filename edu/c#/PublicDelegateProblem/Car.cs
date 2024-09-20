using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        // Теперь это член public!
        public CarEngineHandler listOfHandlers;

        // Просто вызывать уведомление Exploded
        public void Accelerate(int delta)
        {
            if (listOfHandlers != null)
                listOfHandlers("Sorry, this car is dead...");
        }
    }
}
