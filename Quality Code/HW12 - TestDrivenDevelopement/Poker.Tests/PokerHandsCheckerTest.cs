using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void IsValidHand_CardsCountDifferentThanFive()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsValidHand(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidHand_FiveCardsWithTwoExactlyTheSame()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsValidHand(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidHand_FiveCardsWithTwoOfSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsValidHand(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFlush_AllCardsWithSameSuit()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFlush(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFlush_OneCardWithDifferentSuit()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFlush(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFourOfAKind_ExactlyFourCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFourOfAKind(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFourOfAKind_TwoCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFourOfAKind(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsThreeOfAKind_ExactlyThreeCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsThreeOfAKind(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThreeOfAKind_FourCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsThreeOfAKind(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsThreeOfAKind_TwoCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsThreeOfAKind(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsOnePair_ExactlyTwoCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsOnePair(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOnePair_ThreeCardsOfTheSameFace()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsOnePair(hand);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFullHouse_ThreeOfOneFaceAndTwoOfAnother()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFullHouse(hand);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFullHouse_TwoOfOneFaceAndTwoOfAnother()
        {
            List<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cardList);
            PokerHandsChecker handChecker = new PokerHandsChecker();
            var result = handChecker.IsFullHouse(hand);
            Assert.IsFalse(result);
        }
    }
}
