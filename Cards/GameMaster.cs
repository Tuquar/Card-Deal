using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    class GameMaster
    {
        private int maxPlayers;
        private int playerCount;
        private Player Dealer;
        private int startDealer; // 
        private Deck gameDeck;
        private List<Player> playerList; // Should not contain CPU
        private List<Player> dealOrder; // Can include CPU
        private Form GameBoard;

        private const int twentyOne = 21;
        private int dealerLimit = 16;
        private int StartCardNo = 2; // number of cards you start with
        private int StartPlayer = 0; // 0 = player 1
        //TODO: Player can be dealer or there could be a seperate non-player dealer

        public GameMaster(List<Player> listOfPlayers, Form board)
        {
            playerCount = listOfPlayers.Count;
            this.playerList = listOfPlayers;
            bool shuffled = true;
            gameDeck = new Deck(shuffled);
            dealOrder = new List<Player> (playerList);
            GameBoard = board;
        }

        public void StartGame()
        {
            Dealer = new Player("CPU");
            dealOrder.Add(Dealer);
            Dealer.dealer = true;
            DealRound();
            
        }

        public void DealRound()
        {
            int count = 0;
            Player currentPlayer;
            while (count < dealOrder.Count)
            {
                for (; StartPlayer < dealOrder.Count; StartPlayer++)
                {
                    currentPlayer = dealOrder[StartPlayer];
                    if (currentPlayer.CardCount < StartCardNo)
                    {
                        currentPlayer.RecieveCard(gameDeck.DrawCard());
                        continue;
                    }
                    count++;
                }
                StartPlayer = 0;
            }
        }
        // TODO: recievecard event needs to be thrown to update gameboard
        //public void DealCard(Player toDeal, Card card)
        //{
        //    toDeal.RecieveCard(card);
        //    EventHandler CardRecieved = new System.EventHandler(GameBoard);

        //}
    }
}
