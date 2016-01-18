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

        public string SuitToString()
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

        public string ValueToString()
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
            string cardString = this.ValueToString() + " of " + this.SuitToString();
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

        public Image GetCardImage(Card card)
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
                String fileLocation = "C:\\Git\\Projects\\Cards\\Cards\\assets\\std.gif";
                int x = 72;
                int y = 100;
                
                gridX = (x*gridX) - x;
                gridY = (y*gridY) - y;

                Rectangle cardSize = new Rectangle( gridX, gridY, x, y);
                
                Image CardImg = cropImage(GetImgFromLocation(fileLocation), cardSize);

                return CardImg;
            }

            private Image GetImgFromLocation(String fileLocation)
            {
                Bitmap bmpImage = (Bitmap) Image.FromFile(fileLocation);
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
