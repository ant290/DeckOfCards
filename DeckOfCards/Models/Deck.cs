using System.Collections.Generic;
using DeckOfCards.Extensions;
using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class Deck : IDeck
    {
        private int _id;
        private List<ICard> _cards = new List<ICard>();
        private List<ICard> _hand = new List<ICard>();
        private List<ICard> _disCards = new List<ICard>();
        public int Id => _id;
        public List<ICard> Cards => _cards;
        public List<ICard> Hand => _hand;
        public List<ICard> DisCards => _disCards;

        public Deck(int id, List<ICard> cards)
        {
            _id = id;
            _cards = cards;
            _cards.Shuffle();
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
