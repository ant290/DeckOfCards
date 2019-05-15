using DeckOfCards.Interfaces;
using DeckOfCards.Models;
using DeckOfCards.Repos;
using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeckGenerator deckGenerator = new DeckGenerator();
            //instantiate deck 
            IDeck myDeck = deckGenerator.GenerateDeck();

            //iterate through the list of cards to show them
            Console.WriteLine("current deck");
            foreach (ICard c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //shuffle the deck and write them out again
            myDeck.ShuffleCards(myDeck.Cards);
            Console.WriteLine("shuffled deck");
            foreach (ICard c in myDeck.Cards)
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
            foreach (ICard c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in hand:");
            foreach (ICard c in myDeck.Hand)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in discard pile:");
            foreach (ICard c in myDeck.DisCards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();

            //play first card in hand
            myDeck.PlayFromHand(myDeck.Hand[0].Id);

            //show cards in hand and discard pile
            Console.WriteLine();
            Console.WriteLine("Cards in hand:");
            foreach (ICard c in myDeck.Hand)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();
            Console.WriteLine("Cards in discard pile:");
            foreach (ICard c in myDeck.DisCards)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Effect: {c.Effect}");
            }
            Console.WriteLine();

            //exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
