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
            player.JoinGame();
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
        public void ShouldNotLeaveGame_WhenIsNotInGame()
        {
            var player = new Player();
            player.LeaveGame();
            Assert.True(player.CantLeaveGame);
        }

        [Test]
        public void ShouldCanPlayOnlyOneGame_WhenIsInGame()
        {
            var player = new Player();
            player.JoinGame();
            Assert.AreEqual(1, player.JoinedGamesNumber);
        }

        [Test]
        public void SholdBeAbleBuyChips_WhenDoBet()
        {
            var player = new Player();
            player.DoBet();
            Assert.True(player.CanBuyChips);
        }

        [Test]
        public void SholdBeAbleToMakeBets_WhenBuyChipsFromCasino()
        {
            var player = new Player();
            player.BuyChips(0);
            Assert.True(player.CanBet);
        }

        
        
//        internal class PlayerBuilder
//        {
//            private DateTime? openingDate;
//            private PizzeriaFormat pizzeriaFormat;
//
//            public PlayerBuilder ThatIsNotOpened()
//            {
//                openingDate = null;
//                return this;
//            }
//        }
    }
}