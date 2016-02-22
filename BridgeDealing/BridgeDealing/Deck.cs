//This class creates a deck of 52 cards, shuffles them
//then deals them out to the four players

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeDealing
{
    class Deck
    {
        private const int deckSize = 52;
        private const int numPlayers = 4;
        private const int handSize = 13;

        Card[] deck;
        Hand[] hands;
        Random rand;

        //creates the deck
        public Deck()
        {
            int count = 0;
            deck = new Card[deckSize];
            //the i and j start at one and two as that is where the enums start
            // for creating the cards
            for (int i = 1; i < numPlayers+1; i++)
            {
                for (int j = 2; j < handSize+2; j++)
                {
                    Card card = new Card(i, j);
                    deck[count] = card;
                    count++;
                }
            }
            shuffle();
        }

        //shuffles the deck
        public void shuffle()
        {
            rand = new Random();
            int random1, random2;
            Card tempCard;

            for (int i = 0; i < deckSize; i++)
            {
                random1 = rand.Next(deckSize);
                random2 = rand.Next(deckSize);

                tempCard = deck[random1];
                deck[random1] = deck[random2];
                deck[random2] = tempCard;
            }
        
        }

        //deals the deck to the players
        public void dealAndDisplay(ListBox player1,ListBox player2,ListBox player3,ListBox player4)
        {
            hands = new Hand[numPlayers];
            //initialises hand array get null exception error without it
            for (int i = 0; i < numPlayers; i++)
            {
                hands[i] = new Hand();
            }

            int count=0;
            
            for (int i = 0; i < handSize; i++)
            {
                for (int j = 0; j < numPlayers; j++)
                {
                    hands[j].Cards[i] = deck[count];
                    count++;
                }
            }
  
            hands[0].displayHand(player1);
            hands[1].displayHand(player2);
            hands[2].displayHand(player3);
            hands[3].displayHand(player4);
        }
    }
}
