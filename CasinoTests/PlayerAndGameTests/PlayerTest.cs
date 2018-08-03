using NUnit.Framework;

namespace CasinoTests
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void CanBeInGame_WhenGoesToGame()
        {
            Player player = CreatePlayer()
                .ThatJoinedGame()
                .Please();
            Assert.True(player.InGame);
        }

        [Test]
        public void CanNotBeInGame_WhenLeavesGame()
        {
            Player player = CreatePlayer()
                .ThatJoinedGame()
                .Please();
            player.LeaveGame();
            Assert.False(player.InGame);
        }

        [Test]
        public void CanNotLeaveGame_WhenIsNotInGame()
        {
            Player player = CreatePlayer()
                .Please();
            player.LeaveGame();
            Assert.True(player.CantLeaveGame);
        }

//        [Test]
//        public void CanPlayOnlyOneGame_WhenIsInGame()
//        {
//            Player player = CreatePlayer()
//                .ThatJoinedGame()
//                .Please();
//            player.JoinGame();
//            Assert.Catch("");
//        }

        [Test]
        public void CanMakeBets_WhenBuysChipsFromCasino()
        {
            Player player = CreatePlayer()
                .WithChipsNumber(0)
                .Please();
            player.BuyChips(7);
            Assert.True(player.CanBet);
        }

//
//        [Test]
//        [Ignore("hernya kakaya-ta")]
//        public void CanWin_WhenPlaysDiceGame()
//        {
//            var player = CreatePlayer()
//                .ThatPlaysDiceGame()
//                .Please();
//            player.Bet();
//            Assert.True(player.Win);
//        }

        [Test]
        public void CanBetNoMoreChipsThanHas_WhenPlaysGame()
        {
            Player player = CreatePlayer()
                .WithChipsNumber(3)
                .Please();

            player.Bet();
            Assert.That(player.BetNumber <= player.HasChipsNumber);
        }

        private PlayerBuilder CreatePlayer()
        {
            return new PlayerBuilder();
        }

        internal class PlayerBuilder
        {
            private int HasChipsNumber { get; set; }
            private bool InGame { get; set; }
            private int JoinedGamesCount { get; set; }
            private bool CanBet { get; set; }
            private int BetNumber { get; set; }

            public PlayerBuilder WithChipsNumber(int chipsNumber)
            {
                HasChipsNumber = chipsNumber;
                CanBet = true;
                return this;
            }

            public PlayerBuilder ThatJoinedGame()
            {
                InGame = true;
                JoinedGamesCount = 1;
                return this;
            }

            public Player Please()
            {
                return new Player(InGame, null, HasChipsNumber, null, CanBet, BetNumber);
            }

//            public PlayerBuilder ThatPlaysDiceGame()
//            {
//               var diceGame = new Game();
//                diceGame.AddNewPlayer();
//            }
        }
    }
}