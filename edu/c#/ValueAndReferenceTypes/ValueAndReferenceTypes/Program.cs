using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        #region point
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
        #endregion
        struct Rectangle
        {
            // Структура Rectangle содержит член ссылочного типа
            public ShapeInfo RectInfo;

            public int RectTop, RectLeft, RectBottom, RectRight;

            public Rectangle(string info, int top, int left, int bottom, int right)
            {
                RectInfo = new ShapeInfo(info);
                RectTop = top; RectBottom = bottom;
                RectLeft = left; RectRight = right;
            }

            public void Display()
            {
                Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                                  "Left = {3}, Right = {4}",
                    RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
            }
        }
        static void Main(string[] args)
        {
            ValueTypeAssigning();
            Console.WriteLine();
            ValueTypeAssigningRef();
            Console.WriteLine();
            ValueTypeContainingRefType();
            Console.ReadLine();
        }
        static void ValueTypeAssigning()
        {
            Console.WriteLine("Assigning value types \n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.x = 100;
            Console.WriteLine("\n => Changed p1.X\n");
            p1.Display();
            p2.Display();

        }
        static void ValueTypeAssigningRef()
        {
            Console.WriteLine("Assigning value types \n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            p1.Display();
            p2.Display();

            p1.x = 100;
            Console.WriteLine("\n => Changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        static void ValueTypeContainingRefType() 
        {
            //Создать первую переменную Rectangle
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First rect", 10, 10, 50, 50);
            Console.WriteLine("-> Assingning r2 to r1");
            Rectangle r2 = r1;
            //меняем нeкоторые значения r2
            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            // вывод значений обеих переменных Rectangle
            r1.Display();
            r2.Display();
        }
    }
}
