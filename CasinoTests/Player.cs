using System;

namespace TestProject1
{
    public class Player
    {
        public bool? InGame { get; set; }
        public bool? CantLeaveGame { get; set; }
        public int JoinedGamesNumber { get; set; }

        public void JoinGame()
        {
            if (JoinedGamesNumber == 0)
            {
                InGame = true;
                JoinedGamesNumber += 1;
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
    }
}