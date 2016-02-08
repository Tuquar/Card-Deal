using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public class Player
    {
        private String playerName;
        private int score;
        private int playerID;
        private Hand playerHand;
        private bool isDealer = false;

        public Player(String name)
        {
            this.playerName = name;
            playerHand = new Hand();
        }

        public Player(int PlayerID)
        {

        }

        public bool dealer {
            get {return isDealer; }
            set { isDealer = value; }
        }

        public void RecieveCard(Card card)
        {
            this.playerHand.RecieveCard(card);
            Console.WriteLine(playerName + " has recieved " + card.ToFullString());
            
             
            
        }

        public void OnCardRecieved(EventArgs eventArgs)
        {
            EventHandler handler = CardReceived;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        public event EventHandler CardReceived;

        public string PlayerName
        {
            get { return this.playerName; }
            set { }
        }
        public void CreateHand() 
        {
            this.playerHand = new Hand();
        }

        public int CardCount
        {
            get { return this.playerHand.CardCount; }
        }

    }
}
