﻿using System;
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
    public partial class Blackjack : Form
    {
        private Deck gameDeck;
        public Blackjack()
        {
            InitializeComponent();

            gameDeck = new Deck();
        }


    }
}