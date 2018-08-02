using System;

namespace TestProject1
{
    public class Player
    {
        public bool? InGame { get; set; }
        public bool? CantLeaveGame { get; set; }
        public int? JoinedGamesNumber { get; set; }
        public int ChipsNumber { get; set; }
        public bool? CanBuyChips { get; set; }
        public bool CanBet { get; set; }

        public void JoinGame(int? number = 1)
        {
            if (number == 1)
            {
                InGame = true;
                JoinedGamesNumber = 1;
            }
            else
            {
                throw new ArgumentException("You can join only one game at a time");
            }
        }

        public void LeaveGame()
        {
            if (InGame is true)
            {
                InGame = false;
            }
            else
            {
                CantLeaveGame = true;
            }
        }

        public void DoBet()
        {
            CanBuyChips = true;
        }

        public void BuyChips(int chipsNumber)
        {
            if (chipsNumber > 0)
            {
                ChipsNumber = chipsNumber;
                CanBet = true;
            }
            else
            {
                throw new ArgumentException("You want not enough chips. Buy more");
            }
        }
    }
}