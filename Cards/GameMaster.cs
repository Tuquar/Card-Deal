using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class GameMaster
    {
        private int maxPlayers;
        private int playerCount;
        private Deck gameDeck;
        private Player[] playerArray;

        public GameMaster(Player[] playerArray)
        {
            playerCount = playerArray.Length;
            this.playerArray = playerArray;
        }
    }
}
