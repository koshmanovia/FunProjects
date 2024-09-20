using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Обратиться к свойству Points, определенному в интерфейсе IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            // Перехватить возможное исключение InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy ltfPt = null;
            try
            {
                ltfPt = (IPointy)c;
                Console.WriteLine(ltfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            //проверка без блока try/catch при помощи as
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS I Not pointy...");

            //проверка без блока try/catch при помощи is
            
            // Создать массив элементов Shape.
            Shape[] myShapes = { new Hexagon(), new Circle(),
                        new Triangle("Joe"), new Circle("JoJo")};
            for (int i = 0; i < myShapes.Length; i++)
            {   // Вспомните, что базовый класс Shape определяет абстрактный
                // член Draw(), поэтому все фигуры знают, как себя рисовать.
                myShapes[i].Draw();
                //У каких фигур есть вершины?
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}", ip.Points); // есть вершины
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                // нет вершин
                Console.WriteLine();
                // Можно ли нарисовать эту фигуру в трехмерном виде?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
            }
            //Получить первый эллемнт имеющий вершины
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);
            Console.ReadLine();
        }
        static void DrawIn3D(IDraw3D itf3d) 
        {
            itf3d.Draw3D();
        }
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                { return ip; }
            }
            return null;
        }
    }
}
