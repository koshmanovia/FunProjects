using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            // Все эти обращения приводят к вызову одного и того же метода Draw() !
            Octagon oct = new Octagon();
           //ДлЯ доступа к Draw используется явное приведение
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            //Или же сокращенное явное приведениен если не нужна переменная
            ((IDrawToPrinter)oct).Draw();
            //так же можно работать через ключевое слово is 
            if (oct is IDrawToMemory itfMemory)
                 itfMemory.Draw();
            
            Console.ReadLine();
        }
    }
}
