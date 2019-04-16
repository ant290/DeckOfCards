namespace DeckOfCards.Interfaces
{
    public interface ICard
    {
        int Id { get; }
        string Name { get; }
        string Effect { get; }
    }
}
