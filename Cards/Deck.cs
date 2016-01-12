using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int value = 1; value < 14; value++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    cards.Add(new Card(suit , value));
                }
            }

        }

        public void shuffleDeck()
        {
            Random rng = new Random();

            int deckLength = this.cards.Count;
            while (deckLength > 1)
            {
                deckLength--;
                int k = rng.Next(deckLength + 1);
                Card temp = this.cards[k];
                this.cards[k] = this.cards[deckLength];
                this.cards[deckLength] = temp;
            }

        }


    }
}
