using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{ 
    class Octagon : IDrawToPrinter, IDrawToMemory, IDrawToForm
    {
        void IDrawToForm.Draw() { Console.WriteLine("Drawing to Fowm"); }
        void IDrawToPrinter.Draw() { Console.WriteLine("Drawing to Printer"); }
        void IDrawToMemory.Draw() { Console.WriteLine("Drawing to Memory"); }

    }
}
