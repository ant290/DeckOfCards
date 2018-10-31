using DeckOfCards.Models;
using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate deck and iterate through the list of cards to show them
            Deck myDeck = new Deck();

            foreach(Card c in myDeck.Cards)
            {
                Console.WriteLine($"ID: {c.id}, Name: {c.name}, Effect: {c.effect}");
            }

            Console.ReadLine();
        }
    }
}
