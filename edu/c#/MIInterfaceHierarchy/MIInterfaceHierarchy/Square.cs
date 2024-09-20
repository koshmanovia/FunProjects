using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        public int GetNumberOfSides()
        { return 4;}
        void IPrintable.Draw()
        { Console.WriteLine("Drawing IPrintable..."); }
        void IDrawable.Draw()
        { Console.WriteLine("Drawing IDrawable..."); }
        public void Print()
        { Console.WriteLine("Printing...");}       
    }
}
