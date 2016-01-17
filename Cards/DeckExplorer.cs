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
    public partial class DeckExplorer : Form
    {
        private Deck eDeck;
        public DeckExplorer()
        {
            InitializeComponent();
            eDeck = new Deck();
            mainDeckDisplay.Items.Clear();
            mainDeckDisplay.BeginUpdate();
            foreach (var card in eDeck.DeckofCards)
            {
                mainDeckDisplay.Items.Add(card.valueToString() + " of " + card.suitToString());
            }
            mainDeckDisplay.EndUpdate();
        }

        private void mainDeckDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shuffleDeck_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Shuffle");
            eDeck.ShuffleDeck();
            Console.WriteLine(eDeck);
            UpdateDisplay(eDeck);
        }
        private void orderDeck_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Order");
            eDeck.OrderDeck();
            Console.WriteLine(eDeck);
            UpdateDisplay(eDeck);
        }
        private void UpdateDisplay(Deck deckSrc)
        {
            List<String> deckStr = deckSrc.ToFullString();
            mainDeckDisplay.DataSource = null;
            mainDeckDisplay.DataSource = deckStr;
            mainDeckDisplay.Update();
        }
    }
}
