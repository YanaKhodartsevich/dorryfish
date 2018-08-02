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
                .Please();
            player.JoinGame();
            Assert.True(player.InGame);
        }

        [Test]
        public void CanNotBeInGame_WhenLeaveGame()
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

        [Test]
        public void CanPlayOnlyOneGame_WhenIsInGame()
        {
            Player player = CreatePlayer()
                .Please();
            player.JoinGame();
            Assert.AreEqual(1, player.JoinedGamesCount);
        }

        [Test]
        public void CanMakeBets_WhenBuyChipsFromCasino()
        {
            Player player = CreatePlayer()
                .WithChipsNumber(1)
                .Please();
            player.BuyChips(7);
            Assert.True(player.CanBet);
        }

        [Test]
        public void CanBetNoMoreChipsThanHas_WhenPlayGame()
        {
            Player player = CreatePlayer()
                .WithChipsNumber(3)
                .WithBet(2)
                .Please();

            Assert.That(player.Bet <= player.HasChipsNumber);
        }

        private PlayerBuilder CreatePlayer()
        {
            return new PlayerBuilder();
        }

        internal class PlayerBuilder
        {
            private int HasChipsNumber { get; set; }
            private int Bet { get; set; }
            private bool InGame { get; set; }
            private int JoinedGamesCount { get; set; }
            private bool CanBet { get; set; }

            public PlayerBuilder WithChipsNumber(int chipsNumber)
            {
                HasChipsNumber = chipsNumber;
                CanBet = true;
                return this;
            }

            public PlayerBuilder WithBet(int chipsNumber)
            {
                Bet = chipsNumber;
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
                return new Player(InGame, null, JoinedGamesCount, HasChipsNumber, null, CanBet, Bet);
            }
        }
    }
}