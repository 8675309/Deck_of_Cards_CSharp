namespace DeckOfCards
{
    public class Card
    {
        private string label;
        private int value;

        public Card(string myLabel, int myValue){
            label = myLabel;
            value = myValue;
        }

        //for testing and debugging purposes
        public override string ToString() {
            return "Card{" +
                   "label='" + label + '\'' +
                   ", value=" + value +
                   '}';
        }

        public string getLabel() {
            return label;
        }

        public int getValue() {
            return value;
        }
    }
}