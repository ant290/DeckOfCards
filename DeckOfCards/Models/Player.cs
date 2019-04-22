using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class Player : IPlayer
    {
        int _id;
        int _health;
        public int Id => _id;

        public int Health => _health;
        public Player()
        {
            _id = 1;
            _health = 10;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }

        public void TakeHealing(int healing)
        {
            _health += healing;
        }
    }
}
