using System;
//using NUnit.Framework;



namespace Test
{
    using NUnit.Framework;
    using DeckOfCards;
    
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Test]
        public void Create_Deck_Count_52()
        {
            var myDeck = new Deck();
            System.Console.WriteLine(myDeck.GetCount());
            Assert.AreEqual(50,myDeck.GetCount());
            Assert.True(true);
        }
        
    }
}