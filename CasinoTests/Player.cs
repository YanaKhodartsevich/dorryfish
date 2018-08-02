namespace TestProject1
{
    public class Player
    {
        public bool? InGame { get; set; }

        public void GoToGame()
        {
            InGame = true;
        }
        
        public void LeaveGame()
        {
            InGame = false;
        }
    }
}