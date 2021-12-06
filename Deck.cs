using System;
using System.Collections.Generic;


namespace deck_of_cards
{
    public class Deck
    {
        //Define property called "Cards" that is List of Card Objects
        private List<Card> Cards = new List<Card>();
        

        //Initialize Deck with list of 52 unique cards as "cards" property
        public Deck()
        {
            Reset();
        }

        //Give Deck Reset Method 
        public List<Card> Reset()
        {
            Cards.Clear();
            
            for(int i = 0; i < 4; i++)
            {
                int cdV = 2;
                while(cdV < 15)
                {
                    Cards.Add(new Card(Card.Suits[i], cdV));
                    cdV++;
                }
            }
            
            return Cards;
        }


        //Getter method to retrieve Cards List 
        public List<Card> CardsInDeck
        {
            get {return this.Cards;}
        }
        

        //Print all cards currently in deck
        public void PrintDeck()
        {
            foreach (Card cd in Cards)
            {
                cd.PrintCard();
            }
        }


        //Give Deck a deal method that selects "top-most" card, removes it from list and then returns Card
        public Card Deal()
        {
            Card drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;
        }


        //Add Shuffle constructor method to randomly shuffle deck  
        public void Shuffle()
        {
            List<Card> deck2shuffle = this.Cards;
            List<Card> shuffled = new List<Card>();
            Random rand = new Random();
            while(deck2shuffle.Count > 0)
            {
                int idx = rand.Next(0, deck2shuffle.Count);
                shuffled.Add(deck2shuffle[idx]);
                deck2shuffle.RemoveAt(idx);
            }
            this.Cards = shuffled;
        }
    }
}