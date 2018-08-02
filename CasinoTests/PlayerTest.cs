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
        
        [Test]
        public void ShouldNotBeInGame_WhenLeaveGame()
        {
            var player = new Player();
            player.LeaveGame();
            Assert.False(player.InGame);
        }   
        
        [Test]
        public void ShouldNotCanLeaveGame_WhenIsNotInGame()
        {
            var player = new Player();
            player.LeaveGame();
            Assert.True(player.CantLeaveGame);
        }
    }
}