using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) : this()
        {
            Width = w; Height = h;
        }
    
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => ($"Width = {Width}; Height = {Height}");
        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle
            {
                Height = s.Length,
                Width = s.Length * 2
            };
            return r;
        }
    }
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l) : this()
        {
            Length = l;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => ($"Length = {Length}");
        
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }
        public static explicit operator Square(int sideLength)
        {
            Square newSq = new Square { Length = sideLength };
            return newSq;
        }
        public static explicit operator int(Square s) => s.Length;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversion *****");

            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            // Преобразовать Rectangle в Square для вызова метода.
            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);
            Console.WriteLine();

            //преобразование Square в int и обратно
            Square sq2 = (Square)6;
            Console.WriteLine(sq2.ToString());
            sq2.Draw();

            int side = (int)sq2;
            Console.WriteLine("Side length of sq2 = {0}", side);
            Console.WriteLine();

            //неявное преобразование
            Square s3 = new Square { Length = 7 };
            Rectangle rect2 = s3;
            Console.WriteLine();
            Console.WriteLine("rect2 = {0}", rect2);
            rect2.Draw();

            Square s4 = new Square { Length = 3 };
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);
            rect3.Draw();

            Console.ReadLine();
        }
        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}

   

