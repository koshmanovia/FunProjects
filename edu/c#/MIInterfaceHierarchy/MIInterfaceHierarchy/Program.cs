using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Развлекаюсь с множественным наследованием интерфейсов *****\n");
            Square s = new Square();
            Rectangle r = new Rectangle();
            if (s is IPrintable ip)
            { ip.Draw(); }
            if (s is IDrawable id)
            { id.Draw(); }
            ((IPrintable)s).Draw();
            ((IDrawable)s).Draw();
            Console.ReadLine();

        }
    }
}
