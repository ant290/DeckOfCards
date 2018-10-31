using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    class Deck
    {
        List<Card> _cards = new List<Card>();
        public List<Card> Cards => _cards;

        public Deck() {
            //instantiate deck of cards
            AddCard(1, "Card Name 1", "Card Effect 1");
            AddCard(2, "Card Name 2", "Card Effect 2");
            AddCard(3, "Card Name 3", "Card Effect 3");
        }

        private void AddCard(int i, string n, string e) {
            _cards.Add(new Card(i, n, e));
        }
    }
}
