using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    internal class CustomDeck : Deck
    {
        // Allows adding custom cards to the deck.
        public void AddCustomCard(Card card)
        {
            Cards.Add(card);
        }

        public override void InitializeDeck()
        {
            // Custom initialization logic can be added here.
            // For example, an empty deck or a deck with specific custom cards.
        }
    }
}
