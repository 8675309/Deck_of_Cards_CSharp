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
            int valueCount = cards.Count(x => x.GetValue() == 14);
            Assert.AreEqual(4,valueCount);
        }
        
        [Test]
        public void Create_Deck_aces_have_value_14()
        {
            var myDeck = new Deck();
            List<Card> cards = myDeck.GetCards();
            int valueCount = cards.Count(x => x.GetValue() == 14);
            Assert.AreEqual(4,valueCount);
        }
        
        //*****************TEST SHUFFLE******************
        [Test]
        public void Shuffle_Deck_does_not_equal_new_deck()
        {

 
        }
        
        public void Shuffle_Deck_does_not_equal_previous_shuffle()
        {

 
        }
        
        
        
        
        
        //*****************TEST SORT BY ASCENDING******************
        
    }
}