using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
       public int X { get; set; }
        public int Y { get; set;}
        public PointDiscription desc = new PointDiscription();
        public Point(int xPos, int yPos, string petName) { X = xPos; Y = yPos; desc.PetName = petName; }
        public Point() { }
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();
            PointDiscription currentDesc = new PointDiscription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }                                                   //public object Clone() => this.MemberwiseClone();
                                                           //метод выше создает копии всех свойств объекта
                                                           //ссылочные переменные-члены, все равно будут копировать только ссылку
                                                           //поэтому данный метод подходит только для клонирования не содержащих
                                                           //ссылочные типы.
    }
}
