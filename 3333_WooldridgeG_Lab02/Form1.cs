// This program will take five cards, which when
// clicked will show the face of the card and display
// the name of the card in a label

// Written by Gage Wooldridge

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_WooldridgeG_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardOneBack_Click(object sender, EventArgs e)
        {
            // Shows face of card one

            cardOneFront.BringToFront();
            cardTwoFront.SendToBack();
            cardThreeFront.SendToBack();
            cardFourFront.SendToBack();
            cardFiveFront.SendToBack();

            // Display card name in a label

            cardNameLabel.Text = "Four of Clubs";
        }

        private void cardTwoBack_Click(object sender, EventArgs e)
        {
            // Shows face of card two

            cardTwoFront.BringToFront();
            cardOneFront.SendToBack();
            cardThreeFront.SendToBack();
            cardFourFront.SendToBack();
            cardFiveFront.SendToBack();

            // Display card name in a label

            cardNameLabel.Text = "Jack of Clubs";
        }

        private void cardThreeBack_Click(object sender, EventArgs e)
        {
            // Shows face of card three

            cardThreeFront.BringToFront();
            cardTwoFront.SendToBack();
            cardOneFront.SendToBack();
            cardFourFront.SendToBack();
            cardFiveFront.SendToBack();

            // Display card name in a label

            cardNameLabel.Text = "Nine of Diamonds";
        }

        private void cardFourBack_Click(object sender, EventArgs e)
        {
            // Shows face of card four

            cardFourFront.BringToFront();
            cardTwoFront.SendToBack();
            cardThreeFront.SendToBack();
            cardOneFront.SendToBack();
            cardFiveFront.SendToBack();

            // Display card name in a label

            cardNameLabel.Text = "Ace of Hearts";
        }

        private void cardFiveBack_Click(object sender, EventArgs e)
        {
            // Shows face of card five

            cardFiveFront.BringToFront();
            cardTwoFront.SendToBack();
            cardThreeFront.SendToBack();
            cardFourFront.SendToBack();
            cardOneFront.SendToBack();

            // Doisplay card name in a label

            cardNameLabel.Text = "Ten of Diamonds";
        }

        private void cardOneFront_Click(object sender, EventArgs e)
        {
            // Shows back of card one
            // Clears label

            cardOneBack.BringToFront();
            cardNameLabel.Text = " ";
        }

        private void cardTwoFront_Click(object sender, EventArgs e)
        {
            // Shows back of card two
            // Clears label

            cardTwoBack.BringToFront();
            cardNameLabel.Text = " ";
        }

        private void cardThreeFront_Click(object sender, EventArgs e)
        {
            // Shows back of card three
            // Clears label

            cardThreeBack.BringToFront();
            cardNameLabel.Text = " ";
        }

        private void cardFourFront_Click(object sender, EventArgs e)
        {
            // Shows back of card Four
            // Clears label

            cardFourBack.BringToFront();
            cardNameLabel.Text = " ";
        }

        private void cardFiveFront_Click(object sender, EventArgs e)
        {
            // Shows back of card Five
            // Clears label

            cardFiveBack.BringToFront();
            cardNameLabel.Text = " ";
        }
    }
}
