using NUnit.Framework;

namespace CasinoTests
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
}