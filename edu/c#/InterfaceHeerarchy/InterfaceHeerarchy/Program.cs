using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHeerarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****");
            //Вызов на уровне объекта
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(1,1,1,1);
            myBitmap.DrawUpsideDown();
            //Получить IAdvancedDraw Явным образом
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();
            Console.ReadLine();
        }
    }
}
