using Xunit;
using Moq;
using DeckOfCards.Models;
using System.Collections.Generic;
using DeckOfCards.Interfaces;

namespace DeckOfCards.Tests
{
    public class DeckTests
    {
        List<ICard> cards = new List<ICard>
        {
            new Card(1, "Card Name 1", "Card Effect 1"),
            new Card(2, "Card Name 2", "Card Effect 2"),
            new Card(3, "Card Name 3", "Card Effect 3"),
            new DamageCard(4, "Damage Card Name", "Deals 5 Damage", 5),
            new DamageCard(5, "Damage Card Name", "Deals 5 Damage", 5)
        };

        [Fact]
        public void Test_Deck_CreatesSomeCards()
        {
            var myDeck = new Deck(1, cards);

            Assert.NotEmpty(myDeck.Cards);
        }

        [Fact]
        public void Test_DrawCard_AddsACardToHand()
        {
            var myDeck = new Deck(1, cards);
            myDeck.DrawCard();
            Assert.Single(myDeck.Hand);
        }

        [Fact]
        public void Test_DiscardFromHand_AddsCardToDiscard()
        {
            var myDeck = new Deck(1, cards);
            var myCard = myDeck.DrawCard();
            myDeck.DiscardFromHand(myCard.Id);

            Assert.Single(myDeck.DisCards);
        }

        [Fact]
        public void Test_DiscardFromHand_RemovesCardFromHand()
        {
            var myDeck = new Deck(1, cards);
            var myCard = myDeck.DrawCard();
            myDeck.DiscardFromHand(myCard.Id);

            Assert.Empty(myDeck.Hand);
        }

        [Fact]
        public void Test_Shuffle_randomisesCards()
        {
            var myDeck = new Deck(1, cards);
            var cardsControl = myDeck.Cards.ToArray();
            myDeck.ShuffleCards(myDeck.Cards);

            Assert.NotEqual(myDeck.Cards, cardsControl);
        }

        [Fact]
        public void Test_PlayFromHand_Calls_Card_Play()
        {
            //arrange
            //mock out the card
            var mockedCard = new Mock<ICard>();
            mockedCard.Setup(x => x.Play());
            mockedCard.Setup(x => x.Id).Returns(1);
            var listOfCards = new List<ICard> { mockedCard.Object };
            //call the deck of cards
            var deck = new Deck(1, listOfCards);

            //act
            //using this method in the test is bad,
            //but i cant think of a better way to get
            //the card in the hand without creating
            //loads more code
            deck.DrawCard();
            //play the card
            deck.PlayFromHand(1);

            //assert
            mockedCard.Verify(x => x.Play(), Times.Once);
        }
    }
}
