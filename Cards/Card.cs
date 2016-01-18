using System;
using System.Drawing;
using System.Drawing.Configuration;

namespace Cards
{
    class Card
    {
        public int suit;
        public int value;
        private int weight;
        public int order;

        public Card(int suit, int value)
        {
            //standard constructor
            this.suit = suit;
            this.value = value;

            this.weight = standardWeight(value);
        }

        public Card(int suit, int value, int weight)
        {
            // Special constructor for custom card weights
            this.suit = suit;
            this.value = value;
            this.weight = weight;
        }

        private int standardWeight(int value)
        {
            int[] weights = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
            int weight = Array.IndexOf(weights, value);

            return weight;
        }

        public string suitToString()
        {
            switch (this.suit)
            {
                case 1:
                    return "Hearts";
                case 2:
                    return "Diamonds";
                case 3:
                    return "Clubs";
                case 4:
                    return "Spades";
            }
            return null;
        }

        public string valueToString()
        {
            if (this.value < 11 && this.value != 1)
            {
                return this.value.ToString();
            }
            switch (this.value)
            {
                case 11: 
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                case 1:
                    return "Ace";
                case 14:
                    return "Ace";
            }
            return null;
        }

        public string ToFullString()
        {
            string cardString = this.valueToString() + " of " + this.suitToString();
            return cardString;
        }

        public Card CompareCard(Card a, Card b)
        {
            if (a.weight > b.weight)
            {
                return a;
            } else if (a.weight == b.weight)
            {
                return null;
            }
            return b;
        }

        public Image getCardImage(Card card)
        {

            int x = 1, y = 1;

            y = card.suit;
            x = card.value;

            CardImgReader cardImgRdr = new CardImgReader();
            Image CardImage = cardImgRdr.DrawImg(x, y);

            return CardImage;

        }

        private class CardImgReader
        {
            public Image DrawImg (int gridX, int gridY)
            {
                int x = 72;
                int y = 100;
                
                gridX = (x*gridX) - x;
                gridY = (y*gridY) - y;

                Rectangle cardSize = new Rectangle( gridX, gridY, x, y);

                Image CardImg = cropImage(GetImgFromLocation(), cardSize);

                return CardImg;

                //Rectangle cropRectangle = new Rectangle();
                //Bitmap src = Image.FromFile(fileName) as Bitmap;
                //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

                //using (Graphics g = Graphics.FromImage(target))
                //{
                //    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                //                     cropRect,
                //                     GraphicsUnit.Pixel);
                //}
            }

            private Image GetImgFromLocation()
            {
                String fileLocation = "C:\\Git\\Projects\\Cards\\Cards\\assets\\std.gif";

                //Bitmap bmpImage = new Bitmap();
                Bitmap bmpImage = (Bitmap) Image.FromFile(fileLocation);
                //Image bmpImage = new Image();
                return bmpImage;
            }

            private static Image cropImage(Image img, Rectangle cropArea)
            {

                Bitmap bmpImage = new Bitmap(img);
                return bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            }

        }


    }

}
