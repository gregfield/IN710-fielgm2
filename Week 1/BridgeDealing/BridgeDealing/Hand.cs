//The hand class holds the information for each 
//of the four playeres in the game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeDealing
{
    class Hand
    {
        private const int handSize = 13;

        Card[] cards;

        //Hand constructor makes a hand of 13 cards for each player
        public Hand()
        {
            cards = new Card[handSize];
        }

        //displays the hand to the screen
        public void displayHand(ListBox listbox)
        {
            sort();

            string hearts = "H:\t";            
            string diamonds = "D:\t";
            string spades = "S:\t";
            string clubs = "C:\t";
            string rank = "";

            for (int i = 0; i < handSize; i++)
            {
                switch (cards[i].getNumber())
                {
                    case 10:
                        rank = "T";
                        break;
                    case 11:
                        rank = "J";
                        break;
                    case 12:
                        rank = "Q";
                        break;
                    case 13:
                        rank = "K";
                        break;
                    case 14:
                        rank = "A";
                        break;
                    default:
                        rank = cards[i].getNumber().ToString();
                        break;
                }

                switch (cards[i].getSuit())
                {
                    case 1:
                        hearts += rank;
                        break;
                    case 2:
                        diamonds += rank;
                        break;
                    case 3:
                        spades += rank;
                        break;
                    case 4:
                        clubs += rank;
                        break;
                }
            }
            listbox.Items.Add(hearts);
            listbox.Items.Add(diamonds);
            listbox.Items.Add(spades);
            listbox.Items.Add(clubs);
            listbox.Items.Add("High Card Point Total: " + calcHCP());
        }

        //calculates the high card point for the hand
        public int calcHCP()
        {
            int hcp = 0;

            for (int i = 0; i < handSize; i++)
            {
                switch (cards[i].getNumber())
                {
                    case 11:
                        hcp = hcp + 1;
                        break;
                    case 12:
                        hcp = hcp + 2;
                        break;
                    case 13:
                        hcp = hcp + 3;
                        break;
                    case 14:
                        hcp = hcp + 4;
                        break;
                }
            }

            return hcp;
        }

        //sorts the hand by highest number first
        public void sort()
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 0; i < handSize - 1; i++)
                {
                    if (cards[i].getSuit() < cards[i + 1].getSuit())
                    {
                        swap(i, i + 1);
                        sorted = false;
                    }

                    if (cards[i].getSuit() == cards[i + 1].getSuit())
                    {
                        if (cards[i].getNumber() < cards[i + 1].getNumber())
                        {
                            swap(i, i + 1);
                            sorted = false;
                        } 
                    } 
                } 
            }
        }

        //swap method to swap the cards when sorting
        public void swap(int place1, int place2)
        {
            Card tempCard;

            tempCard = cards[place1];
            cards[place1] = cards[place2];
            cards[place2] = tempCard;
        }

        //get set methods for the cards in the hand
        internal Card[] Cards
        {
            get { return cards; }
            set { cards = value; }
        }
    }
}
