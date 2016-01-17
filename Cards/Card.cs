using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        public int suit;
        public int value;
        private int weight;
        //public int order;

        public Card(int suit, int value)
        {
            //standard constructor
            this.suit = suit;
            this.value = value;

            this.weight = standardWeight(value);
        }

        public Card(int suit, int value, int weight)
        {
            // Special constructor for custom card weights
            this.suit = suit;
            this.value = value;
            this.weight = weight;
        }

        private int standardWeight(int value)
        {
            int[] weights = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
            int weight = Array.IndexOf(weights, value);

            return weight;
        }

        public string suitToString()
        {
            switch (this.suit)
            {
                case 1:
                    return "Diamonds";
                case 2:
                    return "Hearts";
                case 3:
                    return "Spades";
                case 4:
                    return "Clubs";
            }
            return null;
        }

        public string valueToString()
        {
            if (this.value < 11 && this.value != 1)
            {
                return this.value.ToString();
            }
            switch (this.value)
            {
                case 11: 
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                case 1:
                    return "Ace";
                case 14:
                    return "Ace";
            }
            return null;
        }

        public Card CompareCard(Card a, Card b)
        {
            if (a.weight > b.weight)
            {
                return a;
            } else if (a.weight == b.weight)
            {
                return null;
            }
            return b;
        }

    }

}
