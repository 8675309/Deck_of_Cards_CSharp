namespace DeckOfCards
{
    public class Card
    {
        private readonly string label;
        private readonly int value;
        private readonly string suit;
        private readonly string rank;

        public Card(string myLabel, int myValue, string mySuit,string myRank){
            label = myLabel;
            value = myValue;
            suit = mySuit;
            rank = myRank;
        }

        //for testing and debugging purposes
        public override string ToString() {
            return "Card{" +
                   "label='" + label + '\'' +
                   ", value=" + value +
                   '}';
        }

        public string GetLabel() {
            return this.label;
        }

        public int GetValue() {
            return this.value;
        }

        public string GetSuit()
        {
            return this.suit;
        }
        
        public string GetRank()
        {
            return this.rank;
        }
    }
}