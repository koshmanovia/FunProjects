using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_and_O_Consol_Game
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            XOGame game = new XOGame();
            game.StartGame();
            Console.ReadLine(); 
        }
    }
    public class XOGame
    {
        int whoMove = 0;
        bool gameOver = false;
        int move = 0;
        bool checkCorrectMove = false;
        List<List<string>> gameArea = new List<List<string>>()
        { 
           new List<string> { "1" , "2" , "3" }, // 0, 1, 2
           new List<string> { "4" , "5" , "6" }, // 3, 4, 5
           new List<string> { "7" , "8" , "9" }  // 6, 7, 8
        };
        public void StartGame()
        {
            for (; whoMove < 10; whoMove++)
            {
                Console.Clear();
                if (whoMove == 9)
                {
                    Console.WriteLine("Ничья");
                    break;
                }
                if ( CheckWin() == true)
                {
                    break;
                }
                DrawGameArea();                
                if (whoMove % 2 == 0)
                {                    
                    MoveX();
                }
                else
                {                    
                    MoveO();
                }
            }
        }
        public void DrawGameArea()
        {
            for (int i = 0; i < gameArea.Count; i++)
            {
                for (int j = 0; j < gameArea[i].Count; j++)
                {
                    Console.Write(gameArea[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MoveX()
        {
            Move("X");
        }
        public void MoveO()
        {
            Move("O");
        }
        public void Move(string s)
        {
            Console.WriteLine($"\nХод игрока {s}:");           
           
            move = int.Parse(Console.ReadLine());
            for (int i = 0; i < gameArea.Count; i++)
            {
                for (int j = 0; j < gameArea[i].Count; j++)
                {
                    try
                    {
                        if (int.Parse(gameArea[i][j]) == move)
                        {
                            gameArea[i][j] = s;
                        }
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
             
        }
        public bool CheckWin()
        {
            if (gameArea[0][1] == gameArea[0][2] && gameArea[0][1] == gameArea[0][2])
            {
                return MessageWin(gameArea[0][1]);
            }
            if (gameArea[1][1] == gameArea[1][2] && gameArea[1][1] == gameArea[1][2])
            {
                return MessageWin(gameArea[1][1]);
            }
            if (gameArea[2][1] == gameArea[2][2] && gameArea[2][1] == gameArea[2][2])
            {
                return MessageWin(gameArea[2][1]);
            }
            if (gameArea[0][0] == gameArea[1][0] && gameArea[2][0] == gameArea[0][0])
            {
                return MessageWin(gameArea[0][0]);
            }
            if (gameArea[0][1] == gameArea[1][1] && gameArea[2][1] == gameArea[0][1])
            {
                return MessageWin(gameArea[0][1]);
            }
            if (gameArea[0][2] == gameArea[1][2] && gameArea[2][2] == gameArea[0][2])
            {
                return MessageWin(gameArea[0][2]);
            }
            if (gameArea[0][0] == gameArea[1][1] && gameArea[2][2] == gameArea[0][0])
            {
                return MessageWin(gameArea[0][0]);
            }
            if (gameArea[0][2] == gameArea[1][1] && gameArea[1][1] == gameArea[2][0])
            {
                return MessageWin(gameArea[0][2]);
            }
            return false;
        }
        public bool MessageWin(string s)
        {
            Console.WriteLine($"победил игрок {s}");        
            return true;
        }
    }
}
