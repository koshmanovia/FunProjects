using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        public Garage() 
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }
       public IEnumerator GetEnumerator()//IEnumerable.GetEnumerator() 
        {
            //исключение не сгенерируется до тех пор, пока не будет вызван метод MoveNext().
            //throw new Exception("This will get called");
            return actualImplementation();

            IEnumerator actualImplementation() 
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
        public IEnumerable GetTheCars(bool returnReserved)
        {
            //Выполнить проверку на предмет ошибок
            return actualImplementation();

            IEnumerable actualImplementation() 
            {
                //Выразить эллементы в обратном порядке
                if (returnReserved)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];

                    }
                }
                else
                {
                    //Возвращает эллементы в том порядке, в котором она размещены в массиве
                    foreach (Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}
