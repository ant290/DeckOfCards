using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class HealingCard : Card, IHealingCard
    {
        int _healing;
        public int Healing => _healing;

        public HealingCard(int id, string name, string effect, int healing): base(id, name, effect)
        {
            _healing = healing;
        }
    }
}
