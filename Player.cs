using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        private string name;
        private List<Card> hand;
        
        
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }


        public string Name
        {
            get { return name; }
        }


        public Card Draw(Deck dk)
        {
            Card currDraw = dk.Deal();
            hand.Add(currDraw);
            return currDraw;
        }


        public Card Discard(int idx)
        {
            Card currCard;
            if(idx < hand.Count)
            {
                currCard = hand[idx];
                hand.RemoveAt(idx);
                return currCard;
            }
            else { return null; }
        }

    }
}