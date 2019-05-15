using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class DamageCard : Card, IDamageCard
    {
        int _damage;
        public int Damage => _damage;

        public DamageCard(int id, string name, string effect, int damage): base(id,name,effect)
        {
            _damage = damage;
        }
    }
}
