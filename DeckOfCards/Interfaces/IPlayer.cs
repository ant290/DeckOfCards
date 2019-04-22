namespace DeckOfCards.Interfaces
{
    public interface IPlayer
    {
        int Id { get; }
        int Health { get; }
        /// <summary>
        /// handles damage received from card plays
        /// </summary>
        void TakeDamage(int damage);
        /// <summary>
        /// handles healing received from card plays
        /// </summary>
        void TakeHealing(int healing);
    }
}
