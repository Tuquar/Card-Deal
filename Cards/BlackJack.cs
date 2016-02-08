using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Blackjack : Form
    {
        private static int maxPlayers = 1;
        PlayerCountPop playerPopup = new PlayerCountPop(maxPlayers);
        private GameMaster BlackjackGM;

        public Blackjack()
        {
            InitializeComponent();

            this.Shown += new EventHandler(this.BlackjackWindowShown);
            

            

        }

        private void BlackjackWindowShown(object sender, EventArgs e)
        {

            this.Enabled = false;
            playerPopup.Show();

            playerPopup.Closed += new System.EventHandler(PlayerPopupClosed);
        }

        private void PlayerPopupClosed(object sender, EventArgs e)
        {


            this.Enabled = true;
            List<Player> playerList = playerPopup.GetPlayerQueue;
            if (playerList.Count > 0)
            {
                BlackjackGM = new GameMaster(playerList, this);
                BlackjackGM.StartGame();
            }
            else
            {
                Console.WriteLine("No players chosen");
                this.Dispose();
            }
            playerPopup.Dispose();

        }

        public void CardDrawn(Object sender, EventArgs e)
        {
        }

        private void p1DrawCardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
