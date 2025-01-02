using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    /// <summary>
    /// This class defines the properties of a card, 
    /// specifically its suit and rank. We will also override the ToString() method
    /// to display the card's information.
    /// </summary>
    internal class Card
    {
        private string suit;
        private string rank;
        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public string Suit 
        { 
            get => suit; 
            set {
                    suit = value;
                } 
        }
        public string Rank 
        {   
            get => rank; 
            set { 
                    rank = value;
                } 
        }

        // Override ToString to display the card information.
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
