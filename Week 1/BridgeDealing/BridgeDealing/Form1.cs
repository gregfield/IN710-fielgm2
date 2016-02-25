/*
 * Author: Greg Field
 * Application: Bridge Dealing
 * Desciprtion: Deals a bridge hand of 13 cards to 4 players
 * then sorts it into the suits and from high to low card.
 * It then calculates the High Card Point and displays it
 * all to the screen.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeDealing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Deals the cards and Displays it to the screen when
        //the button is clicked
        private void DealButton_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            Player1.Items.Clear();
            Player2.Items.Clear();
            Player3.Items.Clear();
            Player4.Items.Clear();
            Player1.Items.Add("North");
            Player2.Items.Add("East");
            Player3.Items.Add("South");
            Player4.Items.Add("West");           
            deck.dealAndDisplay(Player1,Player2,Player3,Player4);
        }
    }
}
