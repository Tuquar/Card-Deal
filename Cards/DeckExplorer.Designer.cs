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
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CardPictureBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 396);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.AccessibleName = "";
            this.CardPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardPictureBox.Location = new System.Drawing.Point(57, 49);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(72, 100);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CardPictureBox.TabIndex = 0;
            this.CardPictureBox.TabStop = false;
            this.CardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // DeckExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeckExplorer";
            this.Text = "DeckExplorer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.PictureBox CardPictureBox;
    }
}