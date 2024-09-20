using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0} \nptTwo = {1}", ptOne, ptTwo);
            Console.WriteLine("ptOne + ptTwo = {0}", ptOne + ptTwo);
            Console.WriteLine("ptOne - ptTwo = {0}", ptOne - ptTwo);
            Console.WriteLine("ptOne + 10 = {0}", ptOne + 10);
            Console.WriteLine("ptOne - 10 = {0}", ptOne - 10);
            Console.WriteLine("10 + ptTwo = {0}", 10 + ptTwo);
            Console.WriteLine("10 - ptTwo = {0}", 10 - ptTwo);
            Console.WriteLine();
            //Перегрузка операции += и -= происходит автоматически
            Point ptThree = new Point(90, 5);
            Console.WriteLine("ptThree = {0}", ptThree);
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);
            Console.WriteLine();
            Point ptFour = new Point(500, 0);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);
            Console.WriteLine();
            Point ptFive = new Point(1, 1);
            Console.WriteLine("ptFive++ = {0}", ++ptFive);
            Console.WriteLine("ptFive-- = {0}", --ptFive);
            Point ptSix = new Point(20, 20);
            ptSix++;
            Console.WriteLine("ptSix++ = {0}", ptSix);
            ptSix--;
            Console.WriteLine("ptSix-- = {0}", ptSix);
            Console.WriteLine();
            Console.WriteLine("ptOne == ptTwo : {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);
            Console.WriteLine();
            Console.WriteLine("ptOne < ptTwo : {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne > ptTwo : {0}", ptOne > ptTwo);

            Console.ReadLine();
        }
    }
}
