using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                ICard cardToCheck = hand.Cards[i];

                for (int j = i+1; j < hand.Cards.Count; j++)
                {
                    ICard nextCard = hand.Cards[j];
                    if (cardToCheck.Face.Equals(nextCard.Face) && cardToCheck.Suit.Equals(nextCard.Suit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }
        
        public bool IsFourOfAKind(IHand hand)
        {
            if (IsValidHand(hand) && IsOfTheSameFace(hand, 4))
            {
                return true;
            }
            
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {            
            if (IsValidHand(hand) && IsThreeOfAKind(hand) && IsOnePair(hand))
            {
                return true;
            }
            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (IsValidHand(hand) && IsOfTheSameSuit(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (IsValidHand(hand) && IsOfTheSameFace(hand, 3))
            {
                return true;
            }
            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            if (IsValidHand(hand) && IsOfTheSameFace(hand, 2))
            {
                return true;
            }
            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool IsOfTheSameSuit(IHand hand)
        {
            var suit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (!(hand.Cards[i].Suit.Equals(suit)))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsOfTheSameFace(IHand hand, int cardsCount)
        {
            //var face = fourCardList[0].Face;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var cardList = hand.Cards.ToList().FindAll(x => x.Face.Equals(hand.Cards[i].Face));
                if (cardList.Count == cardsCount)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
