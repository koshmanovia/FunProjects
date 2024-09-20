using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StartGame(humanPlayer: true));
            Console.WriteLine("*****Computer Round*****");
            Console.WriteLine(StartGame(humanPlayer: false));
            Console.ReadLine();
        }
        public static string StartGame(bool humanPlayer)
        {
            int attempt = 5;
            var secretNum = new Random().Next(0, 100); 
            int inputNum = -1;
            string stringInputNum = default;
            string finalMessage = default;
            if (humanPlayer == true)
            {
                for (; attempt >= 0; attempt--)
                {
                    Console.WriteLine($"Input number from 0 to 100 \nАttempts left: {attempt}");
                    if (attempt == 0)
                    {
                        finalMessage = $"Sorry, you lose, attempts have ended\nthe riddled number = {secretNum}";
                        return finalMessage;
                    }
                    try
                    {
                        inputNum = int.Parse(Console.ReadLine().ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Incorrect input data, refresh input");
                    }

                    if (inputNum == secretNum)
                    {
                        finalMessage = $"Congratulates, you win!\nYou guessed the riddled number: {secretNum}";
                        return finalMessage;
                    }
                    if (inputNum < secretNum)
                    {
                        Console.WriteLine("Take more");
                    }
                    if (inputNum > secretNum)
                    {
                        Console.WriteLine("Take less");
                    }
                }
            }
            else
            {               
                int max = 100;
                int min = 0;
                for (; attempt >= 0; attempt--)
                {
                    inputNum = (min + max ) / 2;
                    Console.WriteLine($"Input number from 0 to 100 \nАttempts left: {attempt}");                    
                    if (attempt == 0)
                    {
                        finalMessage = $"Computer lose, attempts have ended\nthe riddled number = {secretNum}";
                        return finalMessage;
                    }                    
                    Console.WriteLine($"->>> Computer input number: {inputNum}");
                    if (inputNum == secretNum)
                    {
                        finalMessage = $"Computer win!\nYou guessed the riddled number: {secretNum}";
                        return finalMessage;
                    }
                    if (inputNum < secretNum)
                    {
                        Console.WriteLine("Take more");
                        min = inputNum;                        
                    }
                    if (inputNum > secretNum)
                    {
                        Console.WriteLine("Take less");
                        max = inputNum;
                    }
                }
            }            
            return finalMessage;            
        }
    }
}
