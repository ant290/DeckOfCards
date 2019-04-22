namespace DeckOfCards.Interfaces
{
    public interface ICard
    {
        int Id { get; }
        string Name { get; }
        string Effect { get; }
        /// <summary>
        /// Play will enact any features of the card
        /// </summary>
        void Play();
        
    }
}
