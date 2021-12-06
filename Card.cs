using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        //----------------Define Card Class field properties-----------------
        private string stringVal;
        private int numValue; 
        private string suit;

        public static string[] Suits = new string[4] {"Spades", "Clubs", "Diamonds", "Hearts"};




        //--------------Card Constructor that takes all three parameter---------------
        public Card(string s, int value)
        {
            switch(value)
            {
                case 11:
                    stringVal = "Jack";
                    break;
                case 12: 
                    stringVal = "Queen";
                    break;
                case 13:
                    stringVal = "King";
                    break;
                case 14:
                    stringVal = "Ace";
                    break;
                default:
                    stringVal = value.ToString();
                    break;
            }
            suit = s;
            numValue = value;
        }


        //Print Card method to show entire Deck of Cards
        public void PrintCard()
        {
            Console.WriteLine("The {0} of {1}", stringVal, suit);
        }


    }
}