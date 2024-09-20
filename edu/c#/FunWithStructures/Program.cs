using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct Point
    {
        public int x;
        public int y;
        //Добавить к позиции 1
        public void Increment()
        {
            x++; y++;
        }
        // Вычесть 1 из позиции (X, Y) .
        public void Decrement()
        {
            x--; y--;
        }
        // Отобразить текущую позицию,
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", x, y);
        }
        //специальный конструктор
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****★ a First Look at Structures *****\n");                
                // Создать начальную переменную типа Point.
                Point myPoint;
                myPoint.x = 349;
                myPoint.y = 76;
                myPoint.Display();
                // Скорректировать значения X и Y.
                myPoint.Increment();
                myPoint.Display();
            for (int i = 0; i < 555; i++) { myPoint.Decrement(); }
            myPoint.Display();
            //Создать Point при помощи стандартного конструктора
            // Который заполнит значения стандартными
            Point p1 = new Point();
            p1.Display();
            //создание point при помощи специального конструктора
            Point p2 = new Point(50, 60);
            p2.Display();
            Console.ReadLine();
        }
    }
}
