using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class TreeDCircle : Circle
    {
        //скрыть свойство PetName, определенное выше в иерархии.
        public new string PetName { get; set; }
        //скрыть любую реализацию Draw(), находящуюся выще иерархией.
        public new void Draw() =>  Console.WriteLine("Drawing a 3D Circle");
    }
}
