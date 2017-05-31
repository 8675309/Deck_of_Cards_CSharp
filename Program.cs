using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DeckOfCards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string option;
            var myDeck = new Deck();
            Console.WriteLine("Here are the contents of your new deck:");
            myDeck.Print();
            while (true)
            {
                option = ProgramDriver.SelectOption();
                ProgramDriver.ExecuteOption(option, myDeck);
                myDeck.Print();
            }
        }        
    }
}