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
    public partial class PlayerCountPop : Form
    {
        private List<Player> playerQueue = new List<Player>();  

        public PlayerCountPop()
        {
            InitializeComponent();

         //   this.Closed += new System.EventHandler();
        }

        public List<Player> GetPlayerQueue {get { return this.playerQueue; }}

        public void UnlockGame()
        {

        }

    }
}
