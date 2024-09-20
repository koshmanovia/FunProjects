using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = new Hangman();
            //Console.WriteLine(h.numStrWord + "\n" + h.secretWord);
            h.StartGame();
            Console.ReadKey();
        }
    }
    public class Hangman
    {
        public int numStrWord = default;
        public string secretWord = default;
        int attempt = 6;
        char[] checkChar = default;
        string tempStr = default;
        bool charContain = false;

        public Hangman()
        {
            numStrWord = new Random().Next(1, 11650);
           // numStrWord = 11650;
            secretWord = File.ReadLines("WordsStockRus.txt").Skip(numStrWord - 1).First().Normalize().Trim();
            checkChar = new char[secretWord.Length];
            for (int i = 0; i < checkChar.Length; i++)
            {
                checkChar[i] = '*';
            }

        }

        public void StartGame()
        {            
            for (;attempt > -1;)
            {
                if (!checkChar.Contains<char>('*'))
                {
                    Console.Clear();
                    Console.WriteLine("\nПоздравляю ты победил!\n");
                    break;
                }

                if (attempt == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Ты проиграл");
                    Console.WriteLine(secretWord);
                    break;
                }
                if (charContain == false && attempt != 6)
                {
                    Console.WriteLine("Такой буквы нет!");                    
                }
                Console.WriteLine($"Количество попыток: {attempt}\n");
                Console.WriteLine("Загаданное слово:\n");
                OutputWord();
                Console.WriteLine("\nВведите букву");
                tempStr = Console.ReadLine();
                CheckSecretNumContainNum(tempStr.Normalize());
                Console.Clear();
            }
        }

        private void CheckSecretNumContainNum(string s)
        {
            charContain = false;         
            for (int i = 0; i < secretWord.Length; i++)
            {
                for (int j = 0; j < checkChar.Length; j++)
                {
                    if (secretWord[i] == s[0])
                    {
                        checkChar[i] = s[0];
                        charContain = true;
                    }
                }                  
            }
            if (charContain == false)
            {
                --attempt;
            }
        } 
        private void OutputWord()
        {
            for (int i = 0; i < checkChar.Length; i++)
            {
                Console.Write(checkChar[i] + " ");
            }
        }
    }
}

