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
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Game");
        }

        private void cardList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hideCard_Click(object sender, EventArgs e)
        {

        }

        private void viewCard_Click(object sender, EventArgs e)
        {
            Program.LinkTest("Viewing Card: " + cardList1.SelectedItem);
        }

        private void newCard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New card added");
            cardList1.Items.Add("Diamond");
        }

        private void newDeck_Click(object sender, EventArgs e)
        {
            cardList1.Items.Clear();
            cardList2.Items.Clear();

            Console.WriteLine("New deck added");
            Deck currentDeck = new Deck();

            foreach (Card card in currentDeck.cards)
            {
                cardList1.Items.Add(card.valueToString() + " of " + card.suitToString());
            }

            currentDeck.shuffleDeck();
            foreach (Card card in currentDeck.cards)
            {
                cardList2.Items.Add(card.valueToString() + " of " + card.suitToString());
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
