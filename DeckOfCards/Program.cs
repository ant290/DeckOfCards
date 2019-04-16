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
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //shuffle the deck and write them out again
            myDeck.ShuffleCards(myDeck.Cards);
            Console.WriteLine("shuffled deck");
            foreach (Card c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //draw some cards
            var drawnCard = myDeck.DrawCard();
            Console.WriteLine($"Drawn card is: {drawnCard.Name}!");
            Console.ReadKey();
            drawnCard = myDeck.DrawCard();
            Console.WriteLine($"Drawn card is: {drawnCard.Name}!");
            Console.ReadKey();

            //show cards in deck, hand and discard pile
            Console.WriteLine("Cards in deck:");
            foreach (Card c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in hand:");
            foreach (Card c in myDeck.Hand)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in discard pile:");
            foreach (Card c in myDeck.DisCards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }

            //exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
