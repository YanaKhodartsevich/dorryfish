using System.Collections.Generic;

namespace CasinoTests
{
    public class Game
    {
        public int playersCount;
        public List<Player> Players;

        public void WithNumberOfPlayers(int players)
        {
            for (var i = 0; i < players; i++)
            {
                playersCount += 1;
            }
        }

        public void AddNewPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}