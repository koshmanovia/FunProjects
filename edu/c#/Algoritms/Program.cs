using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch(20, 2);
            SelectionSort(65,3,7,9,0);
            Recursion(1);
            checked 
            {
                Console.WriteLine(Factorial(65));
            }            
            Console.ReadLine();
        }
        static void BinarySearch(int high, int item)
        {
            Console.WriteLine("=> Binary Search: \n");
            var low = 0;
            var mid = 0;
            var guess = 0;
            
            List<int> list = new List<int>();
            for (int i = 0; i < high; i++)
            {
                list.Add(i);               
            }
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = list[mid];
                if (guess == item)
                {
                    Console.WriteLine(mid);
                    break;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }              
            }
            Console.WriteLine();
        }

        static void SelectionSort(int num1, int num2, int num3, int num4, int num5) 
        {
            Console.WriteLine("=> Selection Sort: \n");
            
            List<int> arr = new List<int>();
            List<int> newArr = new List<int>();
            int smallest = 0;        
            arr.Add(num1);
            arr.Add(num2);
            arr.Add(num3);
            arr.Add(num4);
            arr.Add(num5);

            for (int i = 0; i < arr.Count; i++)
            {
                smallest = FindSmallest(arr);
                newArr.Add(arr[smallest]);
                arr[smallest] = Int32.MaxValue; //если не делать так, то алгоритм не работает
            }
            for (int i = 0; i < newArr.Count; i++)
            {
                Console.Write(newArr[i]+"\t");
            }
            Console.WriteLine();
        }
        static int FindSmallest(List<int> arr) 
        {
            var smallest = Int32.MaxValue;
            var smallestIndex = 0;
            for (int i = 0;i < arr.Count;i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
        static void Recursion(int i)
        {
            Console.WriteLine(i);
            i++;
            if (i > 20)
            {
                //базовый случай, делать чтото
            }
            else
            {
                Recursion(i); // рекурсивный случай
            }
            
        }
        static ulong Factorial(ulong ul)
        {
            if (ul == 1)
            {
                return 1;
            }
            else 
            {
                return ul * Factorial(ul - 1);
            }

        }
    }
}
