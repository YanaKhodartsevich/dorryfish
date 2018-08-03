using System;

namespace CasinoTests
{
    public class Player
    {
        public bool? InGame { get; set; }
        public bool? CantLeaveGame { get; set; }
        public int? JoinedGamesCount { get; set; }
        public int HasChipsNumber { get; set; }
        public bool? CanBuyChips { get; set; }
        public bool? CanBet { get; set; }
        public int Bet { get; set; }
        public bool? Win { get; set; }

        public Player(bool? inGame, bool? cantLeaveGame, int? joinedGamesCount, int hasChipsNumber, bool? canBuyChips,
            bool? canBet, int bet)
        {
            InGame = inGame;
            CantLeaveGame = cantLeaveGame;
            JoinedGamesCount = joinedGamesCount;
            HasChipsNumber = hasChipsNumber;
            CanBuyChips = canBuyChips;
            CanBet = canBet;
            Bet = bet;
        }

        public void JoinGame(int? number = 1)
        {
            if (number == 1)
            {
                InGame = true;
                JoinedGamesCount = 1;
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

        public void BuyChips(int chipsNumber)
        {
            if (chipsNumber > 0 || HasChipsNumber > 0)
            {
                HasChipsNumber = chipsNumber;
                CanBet = true;
            }
            else
            {
                throw new ArgumentException("You want not enough chips. Buy more");
            }
        }

        public void PlayDiceGame()
        {
//            throw new NotImplementedException();
        }
    }
}