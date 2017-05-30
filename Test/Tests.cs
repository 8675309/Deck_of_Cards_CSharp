using System;
using NUnit.Framework;
using System.Collections.Generic;
using DeckOfCards;
using System.Linq;


namespace Test
{    
    [TestFixture]
    public class Tests
    {
        //*****************TEST CREATE DECK******************
                
        [Test]
        public void Create_Deck_count_52_cards()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            Assert.AreEqual(52,cards.Count);    
        }

        [Test]
        public void Create_Deck_13_hearts()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int heartCount = cards.Count(x => x.GetSuit() == "hearts");
            Assert.AreEqual(13, heartCount);
        }

        [Test]
        public void Create_Deck_13_spades()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int spadeCount = cards.Count(x => x.GetSuit() == "spades");
            Assert.AreEqual(13,spadeCount);
        }
        
        [Test]
        public void Create_Deck_13_of_diamonds()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int diamondCount = cards.Count(x => x.GetSuit() == "diamonds");
            Assert.AreEqual(13,diamondCount); 
        }
        
        [Test]
        public void Create_Deck_13_clubs()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int clubCount = cards.Count(x => x.GetSuit() == "clubs");
            Assert.AreEqual(13,clubCount);
        }
        
        [Test]
        public void Create_Deck_4_cards_valued_at_2()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int valueCount = cards.Count(x => x.GetValue() == 2);
            Assert.AreEqual(4,valueCount);
        }
        
        [Test]
        public void Create_Deck_4_Cards_Valued_at_14()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int valueCount = cards.Count(x => x.GetValue() == 14);
            Assert.AreEqual(4,valueCount);
        }
                
        [Test]
        public void Create_Deck_twos_have_value_2()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            List<Card> twos = cards.FindAll(x => x.GetRank().ToString() == "two");
            Assert.AreEqual(4,twos.Count);
            foreach (var card in twos)
            {
              Assert.AreEqual(2,card.GetValue());  
            }   
        }
        
        [Test]
        public void Create_Deck_aces_have_value_14()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            List<Card> aces = cards.FindAll(x => x.GetRank().ToString() == "ace");
            Assert.AreEqual(4,aces.Count);
            foreach (var card in aces)
            {
                Assert.AreEqual(14,card.GetValue());  
            }   
        }
        //*****************END TEST CREATE DECK******************
        
        //*****************TEST SHUFFLE******************
        [Test]
        public void Shuffle_Deck_has_different_order_from_new_deck()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            myDeck.Shuffle();
            List<Card> shuffled = myDeck.GetCards();
            Assert.False(cards.SequenceEqual(shuffled));
        }
        
        [Test]
        public void Shuffle_Deck_does_not_equal_order_from_previous_shuffle()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            myDeck.Shuffle();
            List<Card> shuffled1 = myDeck.GetCards();
            myDeck.Shuffle();
            List<Card> shuffled2 = myDeck.GetCards();
            Assert.False(shuffled1.SequenceEqual(shuffled2));
        }

        //https://stackoverflow.com/questions/22173762/check-if-two-lists-are-equal
        [Test]
        public void Shuffle_Deck_has_same_contents_as_new_deck()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            myDeck.Shuffle();
            List<Card> shuffled = myDeck.GetCards();
            //'All' tells us if all items meet condition in parameters
            Assert.True(cards.All(shuffled.Contains));
            Assert.True(shuffled.All(cards.Contains));
        }
        
        //*****************END TEST SHUFFLE******************
        
        //*****************TEST SORT BY ASCENDING******************
        
        public void Ascending_Sort_has_same_contents_as_new_deck()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            myDeck.SortAscending();
            List<Card> sorted = myDeck.GetCards();
            //'All' tells us if all items meet condition in parameters
            Assert.True(cards.All(sorted.Contains));
            Assert.True(sorted.All(cards.Contains));
        }
        
        public void Ascending_Sort_has_different_order_than_shuffle()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            myDeck.Shuffle();
            List<Card> shuffled1 = myDeck.GetCards();
            myDeck.SortAscending();
            List<Card> sorted = myDeck.GetCards();
            Assert.False(shuffled1.SequenceEqual(sorted));
        }
        
        //*****************END TEST SORT BY ASCENDING******************
        
        
        
        
      //*****************TEST GET INPUT*****************************
      //  https://stackoverflow.com/questions/3161341/c-sharp-unit-test-for-a-method-which-calls-console-readline
        
        
      //*****************TEST EXECUTE OPTION************************
        
    }
}