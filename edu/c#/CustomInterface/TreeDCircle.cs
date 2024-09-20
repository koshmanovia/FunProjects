using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class TreeDCircle : Circle, IDraw3D
    {
        //скрыть свойство PetName, определенное выше в иерархии.
        public void Draw3D() 
        {Console.WriteLine("Drawing Circle in 3D!");}
        public new string PetName { get; set; }
        //скрыть любую реализацию Draw(), находящуюся выще иерархией.
        public new void Draw() =>  Console.WriteLine("Drawing a 3D Circle");
    }
}
