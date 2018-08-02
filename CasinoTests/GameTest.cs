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
}