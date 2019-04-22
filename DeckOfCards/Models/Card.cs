﻿using DeckOfCards.Interfaces;
using System;

namespace DeckOfCards.Models
{
    public class Card: ICard
    {
        int _id;
        string _name;
        string _effect;
        public int Id => _id;
        public string Name => _name;
        public string Effect => _effect;

        public Card() { }
        public Card(int i, string n, string e)
        {
            _id = i;
            _name = n;
            _effect = e;
        }
        /// <summary>
        /// as this is the base card, it can only give its own details
        /// here we simply spit out the details of the card
        /// </summary>
        public void Play()
        {
            Console.WriteLine($"Card {Id}: {Name} played!");
        }
    }
}
