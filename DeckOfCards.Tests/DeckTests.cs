using Xunit;
using DeckOfCards.Models;

namespace DeckOfCards.Tests
{
    public class DeckTests
    {
        [Fact]
        public void Test_Deck_CreatesSomeCards()
        {
            var myDeck = new Deck();

            Assert.NotEmpty(myDeck.Cards);
        }

        [Fact]
        public void Test_DrawCard_DiscardsACard()
        {
            var myDeck = new Deck();
            var card = myDeck.DrawCard();
            Assert.Single(myDeck.DisCards);
        }
    }
}
