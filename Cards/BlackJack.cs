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
        PlayerCountPop playerPopup = new PlayerCountPop();

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

            GameMaster BlackjackGM = new GameMaster(playerList);

        }

        private void p1DrawCardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
