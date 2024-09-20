using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class PointRef
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
            public PointRef(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }
        
    }
}
