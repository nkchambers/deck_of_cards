using System;
using System.Collections.Generic;


namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Test Initializing------------------------------
            //Initialize new deck 
            Deck deck1 = new Deck();
            //deck1.PrintDeck();
            
            //Shufle Deck
            //deck1.Shuffle();
            deck1.PrintDeck();

            //Initialize Players
            Player nick = new Player("Nick");
            Console.WriteLine($"{nick.Name} has joined the table!");
            
            Player joe = new Player("Joe");
            Console.WriteLine($"{joe.Name} has joined the table!");
            
            Player max = new Player("Max");
            Console.WriteLine($"{max.Name} has joined the table!");
            
            
            Console.WriteLine("----------------------------Players Draw-----------------------------------");
            
            //Player Draw
            nick.Draw(deck1);
            joe.Draw(deck1);
            max.Draw(deck1);
            nick.Draw(deck1);
            joe.Draw(deck1);
            max.Draw(deck1);

            //Deck Deal
            Console.WriteLine("----------------------------Deck Deals-----------------------------------");

            deck1.Deal();
            deck1.Deal();
            deck1.Deal();
            

            //Print Current Cards in Deck
            Console.WriteLine("--------------------------Cards Now in Deck------------------------------");
            deck1.PrintDeck();


            //Player Discard >>> Deck Print All
            nick.Discard(1);
            joe.Discard(1);
            max.Discard(2);
            
            

            //Deck Reset
            deck1.Reset();
            Console.WriteLine("--------------------------Reset Deck------------------------------");
            deck1.PrintDeck();


        }
    }
}
