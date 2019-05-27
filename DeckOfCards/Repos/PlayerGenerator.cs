using DeckOfCards.Interfaces;
using DeckOfCards.Models;

namespace DeckOfCards.Repos
{
    public class PlayerGenerator
    {
        public IPlayer GeneratePlayer()
        {
            var player = new Player(1, 10);
            return player;
        }
    }
}
