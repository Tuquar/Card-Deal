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

        public Player(String name)
        {
            this.playerName = name;
            playerHand = new Hand();
        }

        public Player(int PlayerID)
        {

        }

        public void RecieveCard(Card card)
        {
            this.playerHand.RecieveCard(card);
            Console.WriteLine(playerName + " has recieved " + card.ToFullString());
        }

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
