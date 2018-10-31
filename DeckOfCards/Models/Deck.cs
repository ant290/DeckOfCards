using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Deck
    {
        List<Card> _cards = new List<Card>();
        List<Card> _disCards = new List<Card>();
        public List<Card> Cards => _cards;
        public List<Card> DisCards => _disCards;

        public Deck() {
            //instantiate deck of cards
            AddCard(1, "Card Name 1", "Card Effect 1");
            AddCard(2, "Card Name 2", "Card Effect 2");
            AddCard(3, "Card Name 3", "Card Effect 3");
        }

        private void AddCard(int i, string n, string e) {
            _cards.Add(new Card(i, n, e));
        }

        public Card DrawCard()
        {
            //removes a card from the _cards list and moves it to the _disCards list
            Card card = _cards[0];
            _disCards.Add(card);
            _cards.RemoveAt(0);
            return card;
        }
    }
}
