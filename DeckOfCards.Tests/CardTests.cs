using Xunit;
using DeckOfCards.Models;

namespace DeckOfCards.Tests
{
    public class CardTests
    {
        [Fact]
        public void Test_Card_SetsID()
        {
            var myCard = new Card(1, "name", "");

            Assert.Equal(1, myCard.Id);
        }

        [Fact]
        public void Test_Card_SetsName()
        {
            var myCard = new Card(1, "name", "");

            Assert.Equal("name", myCard.Name);
        }

        [Fact]
        public void Test_Card_SetsEffect()
        {
            var myCard = new Card(1, "name", "effect");

            Assert.Equal("effect", myCard.Effect);
        }
    }
}
