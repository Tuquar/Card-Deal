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
    public partial class Form1 : Form
    {
        private Deck currentDeck;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Game");
        }

        private void deckExplorer_Click(object sender, EventArgs e)
        {
            DeckExplorer wDeck = new DeckExplorer();
            wDeck.Show();
        }
    }
}
