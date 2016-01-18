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

        public Deck()
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

        }

        public void ShuffleDeck()
        {
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

        public void OrderDeck()
        {
            this.DeckofCards = this.DeckofCards.OrderBy(card => card.suit).ThenBy(card => card.value).ToList();
        }

        public List<String> ToFullStringList()
        {
            return this.DeckofCards.Select(card => card.ToFullString()).ToList();
        }
    }
}
