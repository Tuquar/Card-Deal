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
            bool shuffled = false;
            eDeck = new Deck(shuffled);
            mainDeckDisplay.Items.Clear();
            mainDeckDisplay.BeginUpdate();
            foreach (var card in eDeck.DeckofCards)
            {
                mainDeckDisplay.Items.Add(card.ValueToString() + " of " + card.SuitToString());
            }
            mainDeckDisplay.EndUpdate();
        }

        private void shuffleDeck_Click(object sender, EventArgs e)
        {
            eDeck.ShuffleDeck();
            UpdateCardListDisplay(eDeck);
        }
        private void orderDeck_Click(object sender, EventArgs e)
        {
            eDeck.OrderDeck();
            UpdateCardListDisplay(eDeck);
        }
        private void mainDeckDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCardIndex = mainDeckDisplay.SelectedIndex;
            if (selectedCardIndex >= 0 && selectedCardIndex <= eDeck.DeckofCards.Count)
            {
                Card NewSelectedCard = eDeck.DeckofCards[selectedCardIndex];
                UpdateMainDeckDisplayImage(NewSelectedCard);
                UpdateCardDataDisplay(NewSelectedCard);
            }
        }



        // Custom Methods
        private void UpdateMainDeckDisplayImage(Card newSelectedCard)
        {
            
            if (CardPictureBox.Image != null)
            {
                CardPictureBox.Image.Dispose();
            }
            Image card = newSelectedCard.GetCardImage(newSelectedCard);
            CardPictureBox.Image = card;   
        }

        private void UpdateCardDataDisplay(Card newSelectedCard)
        {
            cardHeader.Text = newSelectedCard.ToFullString();

            dataCardName.Text = newSelectedCard.ToFullString();
            dataCardSuit.Text = newSelectedCard.SuitToString();
            dataCardValue.Text = newSelectedCard.ValueToString();
            dataCardPlayed.Text = newSelectedCard.GetPlayed().ToString();

            dataCardName.Visible = true;
            dataCardSuit.Visible = true;
            dataCardValue.Visible = true;
            dataCardPlayed.Visible = true;
        }

        private void UpdateCardListDisplay(Deck deckSrc)
        {
            List<String> deckStr = deckSrc.ToFullStringList();
            mainDeckDisplay.DataSource = null;
            mainDeckDisplay.DataSource = deckStr;
            mainDeckDisplay.Update();
        }



        // Unused onclicks
        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void suitLabel_Click(object sender, EventArgs e)
        {

        }

        private void cardHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
