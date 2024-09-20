using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    interface IPointy
    {
        // Свойство, поддерживающее чтение и запись, в интерфейсе может выглядеть так:
        // retType PropName { get; set; }
        // тогда как свойство только для записи - так:
        // retType PropName { set; }
        byte Points { get; }
    }
}
