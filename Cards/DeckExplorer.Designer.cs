namespace Cards
{
    partial class DeckExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainDeckDisplay = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.shuffleDeck = new System.Windows.Forms.Button();
            this.orderDeck = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.valueLabel = new System.Windows.Forms.Label();
            this.suitLabel = new System.Windows.Forms.Label();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.timeplayedLabel = new System.Windows.Forms.Label();
            this.cardHeader = new System.Windows.Forms.Label();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.dataCardName = new System.Windows.Forms.Label();
            this.dataCardSuit = new System.Windows.Forms.Label();
            this.dataCardValue = new System.Windows.Forms.Label();
            this.dataCardPlayed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainDeckDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainDeckDisplay
            // 
            this.mainDeckDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDeckDisplay.FormattingEnabled = true;
            this.mainDeckDisplay.Location = new System.Drawing.Point(3, 3);
            this.mainDeckDisplay.Name = "mainDeckDisplay";
            this.mainDeckDisplay.Size = new System.Drawing.Size(194, 396);
            this.mainDeckDisplay.TabIndex = 0;
            this.mainDeckDisplay.SelectedIndexChanged += new System.EventHandler(this.mainDeckDisplay_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.shuffleDeck, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderDeck, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 405);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 66);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // shuffleDeck
            // 
            this.shuffleDeck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shuffleDeck.Location = new System.Drawing.Point(108, 21);
            this.shuffleDeck.Name = "shuffleDeck";
            this.shuffleDeck.Size = new System.Drawing.Size(75, 23);
            this.shuffleDeck.TabIndex = 2;
            this.shuffleDeck.Text = "Shuffle";
            this.shuffleDeck.UseVisualStyleBackColor = true;
            this.shuffleDeck.Click += new System.EventHandler(this.shuffleDeck_Click);
            // 
            // orderDeck
            // 
            this.orderDeck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDeck.Location = new System.Drawing.Point(11, 21);
            this.orderDeck.Name = "orderDeck";
            this.orderDeck.Size = new System.Drawing.Size(75, 23);
            this.orderDeck.TabIndex = 3;
            this.orderDeck.Text = "Order Deck";
            this.orderDeck.UseVisualStyleBackColor = true;
            this.orderDeck.Click += new System.EventHandler(this.orderDeck_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(374, 396);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cardHeader, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(188, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(183, 194);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.CardPictureBox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(179, 194);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.suitLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.valueLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.cardNameLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.timeplayedLabel, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.dataCardName, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dataCardSuit, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.dataCardValue, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.dataCardPlayed, 1, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(171, 142);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(42, 81);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(40, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Value :";
            // 
            // suitLabel
            // 
            this.suitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.suitLabel.AutoSize = true;
            this.suitLabel.Location = new System.Drawing.Point(51, 46);
            this.suitLabel.Name = "suitLabel";
            this.suitLabel.Size = new System.Drawing.Size(31, 13);
            this.suitLabel.TabIndex = 7;
            this.suitLabel.Text = "Suit :";
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Location = new System.Drawing.Point(41, 11);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(41, 13);
            this.cardNameLabel.TabIndex = 8;
            this.cardNameLabel.Text = "Name :";
            // 
            // timeplayedLabel
            // 
            this.timeplayedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeplayedLabel.AutoSize = true;
            this.timeplayedLabel.Location = new System.Drawing.Point(6, 117);
            this.timeplayedLabel.Name = "timeplayedLabel";
            this.timeplayedLabel.Size = new System.Drawing.Size(76, 13);
            this.timeplayedLabel.TabIndex = 9;
            this.timeplayedLabel.Text = "Times Played :";
            // 
            // cardHeader
            // 
            this.cardHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardHeader.AutoSize = true;
            this.cardHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cardHeader.Location = new System.Drawing.Point(84, 11);
            this.cardHeader.Margin = new System.Windows.Forms.Padding(0);
            this.cardHeader.Name = "cardHeader";
            this.cardHeader.Size = new System.Drawing.Size(15, 20);
            this.cardHeader.TabIndex = 1;
            this.cardHeader.Text = "-";
            this.cardHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardHeader.Click += new System.EventHandler(this.cardHeader_Click);
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.AccessibleName = "";
            this.CardPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardPictureBox.Location = new System.Drawing.Point(35, 22);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(108, 150);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPictureBox.TabIndex = 3;
            this.CardPictureBox.TabStop = false;
            // 
            // dataCardName
            // 
            this.dataCardName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCardName.AutoSize = true;
            this.dataCardName.Location = new System.Drawing.Point(110, 11);
            this.dataCardName.Name = "dataCardName";
            this.dataCardName.Size = new System.Drawing.Size(35, 13);
            this.dataCardName.TabIndex = 10;
            this.dataCardName.Text = "label1";
            this.dataCardName.Visible = false;
            // 
            // dataCardSuit
            // 
            this.dataCardSuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCardSuit.AutoSize = true;
            this.dataCardSuit.Location = new System.Drawing.Point(110, 46);
            this.dataCardSuit.Name = "dataCardSuit";
            this.dataCardSuit.Size = new System.Drawing.Size(35, 13);
            this.dataCardSuit.TabIndex = 11;
            this.dataCardSuit.Text = "label1";
            this.dataCardSuit.Visible = false;
            // 
            // dataCardValue
            // 
            this.dataCardValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCardValue.AutoSize = true;
            this.dataCardValue.Location = new System.Drawing.Point(110, 81);
            this.dataCardValue.Name = "dataCardValue";
            this.dataCardValue.Size = new System.Drawing.Size(35, 13);
            this.dataCardValue.TabIndex = 12;
            this.dataCardValue.Text = "label1";
            this.dataCardValue.Visible = false;
            // 
            // dataCardPlayed
            // 
            this.dataCardPlayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataCardPlayed.AutoSize = true;
            this.dataCardPlayed.Location = new System.Drawing.Point(110, 117);
            this.dataCardPlayed.Name = "dataCardPlayed";
            this.dataCardPlayed.Size = new System.Drawing.Size(35, 13);
            this.dataCardPlayed.TabIndex = 13;
            this.dataCardPlayed.Text = "label1";
            this.dataCardPlayed.Visible = false;
            // 
            // DeckExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "DeckExplorer";
            this.Text = "DeckExplorer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox mainDeckDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button shuffleDeck;
        private System.Windows.Forms.Button orderDeck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label suitLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.Label timeplayedLabel;
        private System.Windows.Forms.Label cardHeader;
        private System.Windows.Forms.PictureBox CardPictureBox;
        private System.Windows.Forms.Label dataCardName;
        private System.Windows.Forms.Label dataCardSuit;
        private System.Windows.Forms.Label dataCardValue;
        private System.Windows.Forms.Label dataCardPlayed;
    }
}