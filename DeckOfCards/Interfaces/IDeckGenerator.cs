namespace DeckOfCards.Interfaces
{
    public interface IDeckGenerator
    {
        /// <summary>
        /// stand in for loading a stored deck of cards
        /// </summary>
        /// <returns></returns>
        IDeck GenerateDeck();
    }
}
