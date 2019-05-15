using System.Collections.Generic;

namespace DeckOfCards.Interfaces
{
    public interface IDeck
    {
        int Id { get; }
        /// <summary>
        /// List of cards in draw pile
        /// </summary>
        List<ICard> Cards { get; }
        /// <summary>
        /// list of cards currently drawn
        /// </summary>
        List<ICard> Hand { get; }
        /// <summary>
        /// list of discarded cards
        /// </summary>
        List<ICard> DisCards { get; }
        /// <summary>
        /// play a drawn card
        /// </summary>
        /// <param name="id"></param>
        void PlayFromHand(int id);
        /// <summary>
        /// moves a card from the hand to the discard list
        /// </summary>
        /// <param name="id"></param>
        void DiscardFromHand(int id);
        /// <summary>
        /// pulls the first card from the draw pile into the hand
        /// </summary>
        /// <returns>ICard of playable card</returns>
        ICard DrawCard();
        /// <summary>
        /// randomly sorts the given list of ICard
        /// </summary>
        /// <param name="toShuffle"></param>
        void ShuffleCards(List<ICard> toShuffle);
    }
}
