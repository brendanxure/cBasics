using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    /// <summary>
    /// An abstarct Deck class that manages a collection of cards. 
    /// It includes methods for shuffling the deck, displaying the cards, 
    /// and dealing them. The base Deck class contain common functionality 
    /// shared by both the StandardDeck and CustomDeck.
    /// </summary>
    internal abstract class Deck
    {
        // Declare variables
        private List<Card> cards;

        /// <summary>
        /// Constructor
        /// </summary>
        public Deck()
        {
            Cards = new List<Card>();
        }

        // Properties
        public List<Card> Cards
        {
            get => cards;
            set
            {
                cards = value;
            }
        }

        /// <summary>
        /// Abstract method to initialize the deck (for StandardDeck and CustomDeck).
        /// </summary>
        public abstract void InitializeDeck();
        /// <summary>
        /// A method to Shuffle the deck of cards.
        /// </summary>
        public void Shuffle()
        {
            int leastNumberOfCards = 1;
            Random randomNumber = new Random();
            int n = Cards.Count;
            while (n > leastNumberOfCards)
            {
                n--;
                int cardNumber = randomNumber.Next(n + 1);
                Card value = Cards[cardNumber];
                Cards[cardNumber] = Cards[n];
                Cards[n] = value;
            }
        }

        /// <summary>
        /// A method to Deal a card from the deck.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Card DealCard()
        {
            if (Cards.Count == 0)
            {
                return null;
            }

            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
        /// <summary>
        /// A method to Display all cards in the deck.
        /// </summary>
        public void DisplayDeck()
        {
            List<Card> cards = new List<Card>();
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
