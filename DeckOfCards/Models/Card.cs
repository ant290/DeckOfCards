using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    class Card
    {
        public int id;
        public string name;
        public string effect;

        public Card() { }
        public Card(int i, string n, string e)
        {
            id = i;
            name = n;
            effect = e;
        }
    }
}
