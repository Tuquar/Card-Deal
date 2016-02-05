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
            this.AcceptButton = AddNewPlayerBtn;
            AddNewPlayerBtn.GotFocus += new EventHandler(AddPlayerFocus);
            AddNewPlayerBtn.LostFocus += new EventHandler(AddPlayerLostFocus);
        }

        public List<Player> GetPlayerQueue {get { return this.playerQueue; }}

        private void AddNewPlayerBtn_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player(NewPlayerInput.Text);
            playerQueue.Add(newPlayer);
            Console.WriteLine("Added new Player: " + newPlayer.PlayerName);
            NewPlayerInput.ResetText();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlayerFocus(object sender, EventArgs e)
        {
            this.AcceptButton = AddNewPlayerBtn;

            TableLayoutPanel newPlayer = PlayerLayout; //TODO: This will eventually clone a current tablelayout and create more. Look for a more efficient method.
            
        }

        private void AddPlayerLostFocus(object sender, EventArgs e)
        {
            //this.AcceptButton = this.DoneBtn;
        }
    }
}
