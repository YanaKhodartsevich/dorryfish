using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void ShouldBeInGame_WhenGoesToGame()
        {
            var player = new Player();
            player.GoToGame();
            Assert.True(player.InGame);
        }
    }
}