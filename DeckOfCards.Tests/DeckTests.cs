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
        public void Test_DrawCard_AddsACardToHand()
        {
            var myDeck = new Deck();
            myDeck.DrawCard();
            Assert.Single(myDeck.Hand);
        }

        [Fact]
        public void Test_DiscardFromHand_AddsCardToDiscard()
        {
            var myDeck = new Deck();
            var myCard = myDeck.DrawCard();
            myDeck.DiscardFromHand(myCard.Id);

            Assert.Single(myDeck.DisCards);
        }

        [Fact]
        public void Test_DiscardFromHand_RemovesCardFromHand()
        {
            var myDeck = new Deck();
            var myCard = myDeck.DrawCard();
            myDeck.DiscardFromHand(myCard.Id);

            Assert.Empty(myDeck.Hand);
        }

        [Fact]
        public void Test_Shuffle_randomisesCards()
        {
            var myDeck = new Deck();
            var cards = myDeck.Cards.ToArray();
            myDeck.ShuffleCards(myDeck.Cards);

            Assert.NotEqual(myDeck.Cards, cards);
        }

        [Fact]
        public void Test_PlayFromHand_Calls_Card_Play()
        {
            //fail until test written
            //currently unable to mock out cards as they are 
            //created when the deck constructor is called
            Assert.Equal(1, 2);
        }
    }
}
