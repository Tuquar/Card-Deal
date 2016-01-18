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
                mainDeckDisplay.Items.Add(card.ValueToString() + " of " + card.SuitToString());
            }
            mainDeckDisplay.EndUpdate();
        }

        private void mainDeckDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCardIndex = mainDeckDisplay.SelectedIndex;
            if (selectedCardIndex >= 0 && selectedCardIndex <= eDeck.DeckofCards.Count)
            {
                Card card = eDeck.DeckofCards[selectedCardIndex];
                UpdateMainDeckDisplayImage(card);
            }
            
        }

        private void UpdateMainDeckDisplayImage(Card cardToDisplay)
        {
            if (CardPictureBox.Image != null)
            {
                CardPictureBox.Image.Dispose();   
            }
            Image card = cardToDisplay.GetCardImage(cardToDisplay);
            CardPictureBox.Image = card;
        }

        private void shuffleDeck_Click(object sender, EventArgs e)
        {
            eDeck.ShuffleDeck();
            UpdateDisplay(eDeck);
        }
        private void orderDeck_Click(object sender, EventArgs e)
        {
            eDeck.OrderDeck();
            UpdateDisplay(eDeck);
        }
        private void UpdateDisplay(Deck deckSrc)
        {
            List<String> deckStr = deckSrc.ToFullStringList();
            mainDeckDisplay.DataSource = null;
            mainDeckDisplay.DataSource = deckStr;
            mainDeckDisplay.Update();
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
