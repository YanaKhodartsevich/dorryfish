namespace TestProject1
{
    public class Player
    {
        public bool? InGame { get; set; }
        public bool? CantLeaveGame { get; set; }

        public void GoToGame()
        {
            InGame = true;
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