using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTest
    {
        //card suits
        //♣
        //♦
        //♥
        //♠
        [TestMethod]
        public void ToString_TwoOfSpades()
        {
            Card card = new Card(CardFace.Two, CardSuit.Spades);
            var result = card.ToString();
            Assert.AreEqual("2♠", result);
        }

        [TestMethod]
        public void ToString_AceOfHearts()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            var result = card.ToString();
            Assert.AreEqual("A♥", result);
        }

        [TestMethod]
        public void ToString_TenOfDiamonds()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);
            var result = card.ToString();
            Assert.AreEqual("10♦", result);
        }

        [TestMethod]
        public void ToString_JackOfClubs()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Clubs);
            var result = card.ToString();
            Assert.AreEqual("J♣", result);
        }
    }
}
