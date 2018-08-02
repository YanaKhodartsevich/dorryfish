namespace CasinoTests
{
    public class Game
    {
        public int playersCount;

        public void WithNumberOfPlayers(int players)
        {
            for (var i = 0; i < players; i++)
            {
                playersCount += 1;
            }
        }
    }
}