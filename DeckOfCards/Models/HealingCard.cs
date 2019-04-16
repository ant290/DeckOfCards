using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class HealingCard : Card, IHealingCard
    {
        int _healing;
        public int Healing => _healing;

        public HealingCard(int i, string n, string e, int h): base(i, n, e)
        {
            _healing = h;
        }
    }
}
