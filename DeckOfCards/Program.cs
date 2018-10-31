using DeckOfCards.Models;
using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate deck 
            Deck myDeck = new Deck();

            //iterate through the list of cards to show them
            Console.WriteLine("current deck");
            foreach (Card c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.id}, Name: {c.name}, Effect: {c.effect}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //draw some cards
            var handCard = myDeck.DrawCard();
            Console.WriteLine($"Drawn card is: {handCard.name}!");
            Console.ReadKey();
            handCard = myDeck.DrawCard();
            Console.WriteLine($"Drawn card is: {handCard.name}!");
            Console.ReadKey();

            //show cards in deck and discard pile
            Console.WriteLine("Cards in deck:");
            foreach (Card c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.id}, Name: {c.name}, Effect: {c.effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in discard pile:");
            foreach (Card c in myDeck.DisCards)
            {
                Console.WriteLine($"ID: {c.id}, Name: {c.name}, Effect: {c.effect}");
            }

            //exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
