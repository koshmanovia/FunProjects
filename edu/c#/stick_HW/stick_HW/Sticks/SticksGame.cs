using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stick_HW.Sticks
{

    internal class SticksGame
    {
        private readonly Random randomizer;
        public int InitialStickNumber { get;}
        public Player Turn { get; private set; }
        public int RemainigSticks{  get;private set; }
        public GameStatus GameStatus { get; private set; }

        public event Action<int> MachinePlayed;
        public event EventHandler<int> HumanTurnToMakeMove;
        public event Action<Player> EndOfGame;

        public SticksGame(int initialStickNumber, Player whoMakesFirstMove)
        {
            if (initialStickNumber < 7 || initialStickNumber > 30)
            {
                throw new ArgumentException("Inial number of Sticks should be >= 7 & <= 30");
            }
            InitialStickNumber = initialStickNumber;
            randomizer = new Random();
            GameStatus = GameStatus.NotStarted;
            RemainigSticks = InitialStickNumber;
            Turn = whoMakesFirstMove;
        }
        public void HumanTakes(int sticks)
        {
            if (sticks < 1 || sticks > 3)
            {
                throw new ArgumentException("You can take from 1 to 3 stick in a sinhle move");
            }
            if (sticks > RemainigSticks)
            {
                throw new ArgumentException($"You can't take more than remaining. Reains:{RemainigSticks}");    
            }
            TakeSticks(sticks);
        }
        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
            {
                RemainigSticks = InitialStickNumber;
            }
            if (GameStatus == GameStatus.InProgress)
            {
                throw new InvalidOperationException("Can't call Start when game is alredy in progress");
            }
            GameStatus = GameStatus.InProgress;
            while (GameStatus == GameStatus.InProgress)
            {
                if (Turn == Player.Computer)
                {
                    CompMakeMove();
                }
                else
                {
                    HumanMakeMove();
                }
                FireEndOfGameIfRequired();
                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }

        private void FireEndOfGameIfRequired()
        {
           if (RemainigSticks == 0)
           {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame != null)
                {
                    EndOfGame(Turn == Player.Computer ? Player.Human : Player.Computer);
                }
           }
        }

        private void CompMakeMove()
        {
            int maxNumber = RemainigSticks >= 3 ? 3 : RemainigSticks;
            int sticks = randomizer.Next(1, maxNumber);
            TakeSticks(sticks);
                if (MachinePlayed != null)
                {
                    MachinePlayed(sticks);
                }
        }

        private void TakeSticks(int sticks)
        {
            RemainigSticks -= sticks;
        }

        private void HumanMakeMove()
        {
            if (HumanTurnToMakeMove != null)
            {
                HumanTurnToMakeMove(this, RemainigSticks);
            }
        }
    }
}
