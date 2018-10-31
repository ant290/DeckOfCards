using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Card
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
    }
}
