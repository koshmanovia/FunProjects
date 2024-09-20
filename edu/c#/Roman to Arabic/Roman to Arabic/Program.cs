using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Roman_to_Arabic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string romeNum = default;
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Введите римское число: ");
                romeNum = Console.ReadLine();
                foreach (char c in romeNum)
                {
                    if (c == 'I' || c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M')
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                        break;
                    }
                }
            }
            int arabNum = default;
            List<int> vs = new List<int>();
            for (int i = 0; i < romeNum.Length; i++)
            {
                switch (romeNum[i])
                {
                    case 'I':
                        vs.Add(1);
                        break;
                    case 'V':
                        vs.Add(5);
                        break;
                    case 'X':
                        vs.Add(10);
                        break;
                    case 'L':
                        vs.Add(50);
                        break;
                    case 'C':
                        vs.Add(100);
                        break;
                    case 'D':
                        vs.Add(500);
                        break;
                    case 'M':
                        vs.Add(1000);
                        break;
                }
            }
            for (int i = 0; i < vs.Count; i+=2)
            {
                if (i == vs.Count - 1)
                {
                    arabNum += vs[i];
                }
                else 
                    if (vs[i] < vs[i + 1])
                    {
                        arabNum = arabNum + vs[i + 1] - vs[i];                 
                    }
                    else
                    {
                        arabNum = arabNum + vs[i] + vs[i + 1];
                    }
            }
            Console.WriteLine("Arabic Num: {0}",arabNum);
            Console.ReadLine();
        }
    }
}
