using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Deck
    {
        public List<Card> DeckofCards = new List<Card>();

        public Deck(bool shuffled)
        {
            int order = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    this.DeckofCards.Add(new Card(suit , value));
                    DeckofCards.Last().order = order;
                    order++;
                }
            }
            if (shuffled)
            {
                this.ShuffleDeck();
            }
        }

        public void ShuffleDeck()
        {
            Console.WriteLine("Shuffling cards...");
            Random rng = new Random();
            int deckLength = this.DeckofCards.Count;
            while (deckLength > 1)
            {
                deckLength--;
                int k = rng.Next(deckLength + 1);
                Card temp = this.DeckofCards[k];
                this.DeckofCards[k] = this.DeckofCards[deckLength];
                this.DeckofCards[deckLength] = temp;
            }
        }

        public Card DrawCard()
        {
            Card toDraw;

            toDraw = this.DeckofCards.FindLast(FindDrawn);

            toDraw.drawn = true;

            return toDraw;
        }

        private bool FindDrawn(Card card)
        {
            if (card.drawn)
            {
                return false;
            }
            return true;
        }

        public void OrderDeck()
        {
            Console.WriteLine("Ordering cards...");
            this.DeckofCards = this.DeckofCards.OrderBy(card => card.suit).ThenBy(card => card.value).ToList();
        }

        public List<String> ToFullStringList()
        {
            return this.DeckofCards.Select(card => card.ToFullString()).ToList();
        }
    }
}
