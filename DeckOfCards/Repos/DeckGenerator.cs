using DeckOfCards.Interfaces;
using DeckOfCards.Models;
using System.Collections.Generic;

namespace DeckOfCards.Repos
{
    class DeckGenerator : IDeckGenerator
    {
        public IDeck GenerateDeck()
        {
            var cards = new List<ICard>
            {
                new Card(1, "Card Name 1", "Card Effect 1"),
                new Card(2, "Card Name 2", "Card Effect 2"),
                new Card(3, "Card Name 3", "Card Effect 3"),
                new DamageCard(4, "Damage Card Name", "Deals 5 Damage", 5),
                new DamageCard(5, "Damage Card Name", "Deals 5 Damage", 5)
            };
            var deck = new Deck(1, cards);
            return deck;
        }
    }
}
