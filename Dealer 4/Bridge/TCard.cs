using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Bridge
{
    class TCard
    {
        private int suit;   // Spade, Hearts, Diamonds, Clubs
        private int rank;   // 2 thru 10, Jack, Queen, King, Ace 

        // constructor
        public TCard(int startSuit, int startRank)
        {
          // initialise the properties
          this.suit = startSuit;
          this.rank = startRank;
        }
      

        /*
         * pre - none 
         * post - returns an int
         */
        // set and get methods for the rank property
        public int Rank
        {
          get
          {
            return rank;
          }

          set
          {
            rank = value;
          }
        }

        /*
         * pre - none 
         * post - returns an int
         */
        // set and get methods for the suit property
        public int Suit
        {
          get
          {
            return suit;
          }

          set
          {
            suit = value;
          }
        }


        /*
         * pre - none 
         * post - returns a String
         */
        // gets the rank as an integer, adds 2 to it's value and 
        // returns it as a String. 2 is added because the array starts at 
        // index position 0 whereas the card values start at 2.
        // ToString is for the purpose of printing it out to a ListBox
        public String getRankString()
        {
          return (rank+2).ToString();
        }


        /*
         * pre - none 
         * post - returns a String
         */
        // Override the native ToString method so we can print out
        // our own special text.
        public override string ToString()
        {
          String tmpRank = getRankString();
          String tmpSuit = "";
            
            // assign the tmpRank String value to a picture card name
            // if it is above 10 otherwise the tmpRank String value stays
            // the same.
            if(tmpRank == "14")
            {
                tmpRank = "Ace";
            }
            if (tmpRank == "13")
            {
                tmpRank = "King";
            }
            if (tmpRank == "12")
            {
                tmpRank = "Queen";
            }
            if (tmpRank == "11")
            {
                tmpRank = "Jack";
            }

            // assign the tmpSuit variable a suit name depending on it's value.
            switch (suit)
            {
              case 0:
                tmpSuit = "Clubs";
                break;

              case 1:
                tmpSuit = "Diamonds";
                break;

              case 2:
                tmpSuit = "Hearts";
                break;

              case 3:
                tmpSuit = "Spades";
                break;
            }

            return tmpRank + "\t of  " + tmpSuit;
        } // end ToString
    } //  end TCard class
}
