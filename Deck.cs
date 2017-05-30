using System;
using System.Collections.Generic;
using System.Linq;


namespace DeckOfCards
{
    public class Deck
    {
        private enum Rank{two, three, four, five, six, seven,
            eight, nine, ten, jack, queen, king, ace};
        private enum Suit{hearts, clubs, diamonds, spades };
        private List<Card> deck;
        private readonly Random rnd = new Random();


        //Create cards consisting of a label and a numerical value
        public Deck(){
            deck = new List<Card>();
            //for each suit(hearts, clubs...), create a card of each rank(two through ace)
            foreach(Suit s in Enum.GetValues(typeof(Suit))){
                var value = 2;
                foreach (Rank r in Enum.GetValues(typeof(Rank))){
                    var label = r + " of " + s;
                    var newCard = new Card(label,value, s.ToString(), r.ToString());
                    deck.Add(newCard);
                    value++;
                }
            }
        }
        //https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
        public void SortAscending()
        {
            this.deck = this.deck.OrderBy(card => card.GetValue()).ToList();
        }

        //https://stackoverflow.com/questions/5383498/shuffle-rearrange-randomly-a-liststring
        public void Shuffle()
        {
            this.deck = this.deck.OrderBy(item => rnd.Next()).ToList();
        }

        public List<Card> GetCards()
        {
            return this.deck;
        }

        //for testing and debugging purposes
        public override string ToString() {
            return "Deck{" +
                   "deck=" + deck +
                   '}';
        }

        public void Print()
        {
            foreach (var card in this.deck)
            {
                System.Console.WriteLine(card.GetLabel());
            }
        }
        
        public int GetCount()
        {
            return this.deck.Count;
        }


    }
}