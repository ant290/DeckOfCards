using System.Collections.Generic;
using DeckOfCards.Extensions;
using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class Deck
    {
        List<ICard> _cards = new List<ICard>();
        List<ICard> _hand = new List<ICard>();
        List<ICard> _disCards = new List<ICard>();
        public List<ICard> Cards => _cards;
        public List<ICard> Hand => _hand;
        public List<ICard> DisCards => _disCards;

        public Deck() {
            //instantiate deck of cards
            AddCard(1, "Card Name 1", "Card Effect 1");
            AddCard(2, "Card Name 2", "Card Effect 2");
            AddCard(3, "Card Name 3", "Card Effect 3");
        }

        private void AddCard(int i, string n, string e) {
            _cards.Add(new Card(i, n, e));
        }

        public void PlayFromHand(int id)
        {
            //plays a card and then moves it from _hand to _disCards
            var card = _hand.Find(x => x.Id == id);
            card.Play();
            DiscardFromHand(card.Id);
        }

        public void DiscardFromHand(int id)
        {
            //TODO: unit test this DiscardFromHand()
            //moves a card from _hand to _disCards
            var card = _hand.Find(x => x.Id == id);
            _disCards.Add(card);
            _hand.Remove(card);
        }

        public ICard DrawCard()
        {
            //removes a card from _cards and moves it to _hand
            var card = _cards[0];
            _hand.Add(card);
            _cards.RemoveAt(0);
            return card;
        }

        public void ShuffleCards(List<ICard> toShuffle)
        {
            toShuffle.Shuffle();
        }

    }
}
