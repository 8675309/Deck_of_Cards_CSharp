using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DeckOfCards
{
    public class ProgramDriver
    {
        public static void ExecuteOption(string myOption, Deck myDeck)
        {
            switch (myOption)
            {
                case "a":
                {
                    //sort by ascending
                    Console.WriteLine("\nYou chose to sort by ascending:");
                    myDeck.SortAscending();
                    break;
                }
                case "b":
                    //shuffle randomly
                    Console.WriteLine("\nYou chose to shuffle randomly:");
                    myDeck.Shuffle();
                    break;
                case "q":
                    //shuffle randomly
                    Console.WriteLine("\nYou chose to exit the program. Goodbye.");
                    Environment.Exit(0);
                    break;                   
                    
                default:  
                    Console.WriteLine("\n" + myOption + " is not a valid selection.");  
                    break;       
            }
        }

        public static string SelectOption()
        {
            var myOption = "a valid value was not selected";
            var valid = false;
            while (!valid)
            {                
                PrintOptions();
                myOption = ReadOption();
                valid = ValidateOption(myOption);
            }

            return myOption;
        }

        public static void PrintOptions()
        {
            System.Console.WriteLine("\nPlease select an option:");
            System.Console.WriteLine("'a' to sort by ascending");
            System.Console.WriteLine("'b' to shuffle randomly"); 
            System.Console.WriteLine("'q' to exit the program."); 
        }

        public static string ReadOption()
        {
            string myOption = Console.ReadLine();
            return myOption;
        }

        public static bool ValidateOption(string myOption)
        {

            bool valid = false;
            switch (myOption)
            {
                case "a":
                case "b":
                case "q":
                {
                    //sort by ascending
                    valid = true;
                    break;
                }
                default:  
                    Console.WriteLine("\n" + myOption + " is not a valid selection.");  
                    break;       
            }
            return valid;

        }  
    }
}