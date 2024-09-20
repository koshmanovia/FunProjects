using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    public struct Point<T> 
    {
        //обобщенные данные состояния
        private T xPos;
        private T yPos;
        //обобщенный конструктор
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }
        //Обобщенные свойства
        public T X 
        { 
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y 
        {
            get { return yPos; }
            set { yPos = value; }
        }
        public override string ToString() => $"[{xPos}],[{yPos}] ";
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Structures *****\n");
            //Точка с координатами int
            Point<int> p1 = new Point<int>(10, 10);
            Console.WriteLine($"p1.ToString()={p1.ToString()}");
            p1.ResetPoint();
            Console.WriteLine($"p1.ToString()={p1.ToString()}");
            //Точка с координатами типа Double
            Point<double> p2 = new Point<double>(1.20, 1.30);
            Console.WriteLine($"p2.ToString()={p2.ToString()}");
            p2.ResetPoint();
            Console.WriteLine($"p2.ToString()={p2.ToString()}");
            //Точка с ссылочными типами String
            Point<string> p3 = new Point<string>("10", "10");
            Console.WriteLine($"p3.ToString()={p3.ToString()}");
            p3.ResetPoint();
            Console.WriteLine($"p3.ToString()={p3.ToString()}");
            Console.ReadLine();
        }
    }
}
