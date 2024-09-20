using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMidle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int temp = default;
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("Введите целое цисло: ");
               temp = (int.Parse(Console.ReadLine()));
               if (temp == 0)
               {
                   break;
               }
               else
               {
                   list.Add(temp);
               }                
            }
            temp = 0;
            int iteratorThree = default;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 3 == 0)
                { 
                    temp += list[i];
                    iteratorThree++;
                }
            }
            double average = (double)temp / iteratorThree;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
