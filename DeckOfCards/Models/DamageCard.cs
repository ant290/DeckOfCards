using DeckOfCards.Interfaces;

namespace DeckOfCards.Models
{
    public class DamageCard : Card, IDamageCard
    {
        int _damage;
        public int Damage => _damage;

        public DamageCard(int i, string n, string e, int d): base(i,n,e)
        {
            _damage = d;
        }
    }
}
