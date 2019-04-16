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

    //todo: refactor out if it gets lengthy
    public class DamageCardTests
    {
        [Fact]
        public void Test_DamageCard_SetsDamage()
        {
            var myCard = new DamageCard(1, "name", "effect", 3);

            Assert.Equal(3, myCard.Damage);
        }
    }

    //todo: refactor out if it gets lengthy
    public class HealingCardTests
    {
        [Fact]
        public void Test_HealingCard_SetsHealing()
        {
            var myCard = new HealingCard(1, "name", "effect", 4);

            Assert.Equal(4, myCard.Healing);
        }
    }
}
