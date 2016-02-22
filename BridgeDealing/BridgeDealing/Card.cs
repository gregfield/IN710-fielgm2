//The card class hold the information for each card

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDealing
{
    //enum for the suits
    public enum suit {Hearts = 1 , Diamonds = 2, Spades = 3, Clubs = 4}

    //enum for numbers
    public enum numbers {Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, 
        Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13, Ace = 14}

    class Card
    {
        private suit suit;
        private numbers numbers;

        //constructor sets the card suit and number to what is passed in
        public Card(int suit, int number)
        {
            this.suit = (suit)suit;
            this.numbers = (numbers)number;
        }

        //to string
        public override string ToString()
        {
            return numbers.ToString() + " of " + suit.ToString();
        }

        //get suit
        public int getSuit()
        {
            return (int)suit;
        }

        //get number
        public int getNumber()
        {
            return (int)numbers;
        }
    }
}
