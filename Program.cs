using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string option;
            option = GetInput();
            var myDeck = new Deck();
            myDeck.Print();
            ExecuteOption(option,myDeck);
            myDeck.Print();
        }

        public static void ExecuteOption(string myOption, Deck myDeck)
        {
            switch (myOption)
            {
                case "a":
                {
                    //sort by ascending
                    Console.WriteLine("\nYou chose to sort by ascending");
                    myDeck.SortAscending();
                    break;
                }
                case "b":
                    //shuffle randomly
                    Console.WriteLine("\nYou chose to shuffle randomly");
                    myDeck.Shuffle();
                    break;
                default:  
                    Console.WriteLine("\n" + myOption + " is not a valid selection.");  
                    break;       
            }
        }
        
        public static string GetInput(){
            var myOption = "a value was not selected";
            var valid = false;

            while(!valid) {

                System.Console.WriteLine("Please select an option: 'a' or 'b' ");
                System.Console.WriteLine("'a' to sort by ascending");
                System.Console.WriteLine("'b' to shuffle randomly");
                
                myOption = Console.ReadLine();
                switch (myOption)
                {
                    case "a":
                    {
                        //sort by ascending
                        Console.WriteLine("\nYou chose to sort by ascending");
                        valid = true;
                        break;
                    }
                    case "b":
                        //shuffle randomly
                        Console.WriteLine("\nYou chose to shuffle randomly");
                        valid = true;
                        break;
                    default:  
                        Console.WriteLine("\n" + myOption + " is not a valid selection.");  
                        break;       
                }

            }
            
            return myOption;
        }   
        
    }
}