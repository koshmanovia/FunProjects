using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    //Этот делегат может указывать на любой метод, который принимает
    //два целочисленных значения и возвращает целочисленное значение.
    public delegate int BinaryOp(int x, int y);
    //этот класс содержит методы, на которые будет указывать BinaryOp
    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Substract(int x, int y) => x - y;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");
            //создать объект делегата BinaryOp, который "указывает" на SimpleMath.Add().
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);

            //Вызвать метод Add() косвенно с использованием объекта делегата.
            //Console.WriteLine("10 + 10 is {0}", b.Invoke(10, 10)); - Допустимый вызов делегата
            Console.WriteLine("10 + 10 is {0}", b(10,10));
           
            DisplayDelegateInfo(b);
            Console.ReadLine();
        }
        static void DisplayDelegateInfo(Delegate delObj)
        {
            //Вывести имена всех членов в списке вызовов делегата.
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method); // имя метода 
                Console.WriteLine("Type Name: {0}", d.Target); // имя типа
            }
        }
    }
}
