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
        private Deck gameDeck;
        private List<Player> playerList;

        private const int twentyOne = 21;
        private int dealerLimit = 16;
        private int StartCardNo = 2;
        private int StartPlayer = 0; // 0 = player 1
        //TODO: Player can be dealer or there could be a seperate non-player dealer

        public GameMaster(List<Player> listOfPlayers)
        {
            playerCount = listOfPlayers.Count;
            this.playerList = listOfPlayers;
            bool shuffled = true;
            gameDeck = new Deck(shuffled);

        }

        public void StartGame()
        {
            DealRound(this.StartPlayer);
            
        }

        public void DealRound(int startPlayer)
        {
            int count = 0;
            Player currentPlayer;
            while (count < playerList.Count)
            {
                for (;startPlayer < playerList.Count; startPlayer++)
                {
                    currentPlayer = playerList[startPlayer];
                    if (currentPlayer.CardCount < StartCardNo)
                    {
                        currentPlayer.RecieveCard(gameDeck.DrawCard());
                        continue;
                    }
                    count++;
                }
                startPlayer = 0;
            }
        }
    }
}
