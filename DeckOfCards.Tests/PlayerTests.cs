using Xunit;
using DeckOfCards.Models;

namespace DeckOfCards.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void Test_Player_SetsId()
        {
            var myPlayer = new Player();

            Assert.Equal(1, myPlayer.Id);
        }

        [Fact]
        public void Test_Player_SetsHealth()
        {
            var myPlayer = new Player();

            Assert.Equal(10, myPlayer.Health);
        }

        [Fact]
        public void Test_Player_TakesDamage()
        {
            var myPlayer = new Player();

            Assert.Equal(10, myPlayer.Health);

            myPlayer.TakeDamage(5);

            Assert.Equal(5, myPlayer.Health);
        }

        [Fact]
        public void Test_Player_TakesHealing()
        {
            var myPlayer = new Player();

            Assert.Equal(10, myPlayer.Health);

            myPlayer.TakeHealing(5);

            Assert.Equal(15, myPlayer.Health);
        }
    }
}
