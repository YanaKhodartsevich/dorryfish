using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void ShouldNotIncludeMoreThanSixPlayers_WhenOnlyOneGame()
        {
            var game = new Game();
            game.WithNumberOfPlayers(6);
            Assert.That(game.playersCount <= 6);
        }
    }

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