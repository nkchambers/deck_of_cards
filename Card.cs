using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        //----------------Define Card Class field properties-----------------
        public string stringVal; 
        public string suits; 
        public int numValue; 




        //--------------Card Constructor that takes all three parameter---------------
        public Card(string suit, string val, int value)
        {
            suits = suit;
            stringVal = val;
            numValue = value;
        }


        public override string ToString()
        { 
            return @$"
    Suits:           {suits}
    StringVal:       {stringVal}
    Value:           {numValue}
            ";
        }
    }
}