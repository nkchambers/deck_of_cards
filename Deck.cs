using System;
using System.Collections.Generic;


namespace deck_of_cards
{
    public class Deck
    {
        //Define property called "Cards" that is List of Card Objects
        public List<Card> Cards;
        

    //Initialize Deck with list of 52 unique cards as "cards" property
        public Deck()
        {
            Cards = new List<Card>();
            
            string[] suits = {"Spades", "Clubs", "Diamonds", "Hearts"};
            string[] stringVal = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            int value = 1;

            foreach(string suit in suits) 
            {
                foreach(string val in stringVal) 
                {
                    value++;
                    Cards.Add(new Card(suit, val, value));
                    Console.WriteLine($"This is the {val} of {suit} with a value of {value}");
                }
                value = 1;
            }

        }
        //Give Deck a deal method that selects "top-most" card, removes it from list and then returns Card

    }
}