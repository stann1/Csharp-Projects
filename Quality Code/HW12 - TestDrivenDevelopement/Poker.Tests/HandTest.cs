using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class HandTest
    {
        //card suits
        //♣
        //♦
        //♥
        //♠
        [TestMethod]
        public void ToString_WithNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            var result = hand.ToString();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToString_WithOneCardOnly()
        {
            Hand hand = new Hand(new List<ICard>() {new Card(CardFace.Eight, CardSuit.Clubs)});
            var result = hand.ToString();
            Assert.AreEqual("8♣", result);
        }

        [TestMethod]
        public void ToString_WithMultipleCards()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            Hand hand = new Hand(cardList);
            var result = hand.ToString();
            Assert.AreEqual("2♠ A♥ 10♦ J♣", result);
        }
    }
}
