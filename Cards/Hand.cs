using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Hand
    {
        List<Card> currentHand;

        public Hand()
        {
            currentHand = new List<Card>();
        }

        public List<Card> PlayerHand 
        {
        get { return currentHand; }
        set { this.currentHand = this.PlayerHand; }
        }

        public void RecieveCard(Card newCard)
        {
            currentHand.Add(newCard);
        }

        public List<Card> ShowHand()
        {
            return this.currentHand;
        }

        public int CardCount {
            get { return currentHand.Count; }
        }

    }
}
