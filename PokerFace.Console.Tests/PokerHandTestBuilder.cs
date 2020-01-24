using System.Collections.Generic;
using PokerFace.Core;

namespace PokerFace.Console
{
    public class PokerHandTestBuilder
    {
        private PokerHand _pokerHand;
        private List<Card> _cards;

        public PokerHandTestBuilder WithHighCard()
        {
            _cards = new List<Card>()
            {
                new Card('A','S' ),
                new Card('J','D' ),
                new Card('2','H' ),
                new Card('5', 'S'),
                new Card('T', 'S')
            };

            return this;
        }
        
        public PokerHandTestBuilder WithPair()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('A', 'D'),
                new Card('5','D'),
                new Card('8','D'),
                new Card('T','D')
            };

            return this;
        }

        public PokerHandTestBuilder With2Pair()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('A', 'D'),
                new Card('8','S'),
                new Card('8','D'),
                new Card('T','D')
            };

            return this;
        }

        public PokerHandTestBuilder With3OfAKind()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('A', 'D'),
                new Card('A','H'),
                new Card('8','D'),
                new Card('T','D')
            };

            return this;
        }

        public PokerHandTestBuilder With4OfAKind()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('A', 'D'),
                new Card('A','H'),
                new Card('A','C'),
                new Card('T','D')
            };

            return this;
        }

        public PokerHandTestBuilder WithFullHouse()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('A', 'D'),
                new Card('A','H'),
                new Card('8','D'),
                new Card('8','S')
            };

            return this;
        }

        public PokerHandTestBuilder WithStraightWheel()
        {
            _cards = new List<Card>()
            {
                new Card('A', 'S'),
                new Card('2', 'D'),
                new Card('3','H'),
                new Card('4','D'),
                new Card('5','D')
            };

            return this;
        }

        public PokerHandTestBuilder WithStraight()
        {
            _cards = new List<Card>()
            {
                new Card('2', 'D'),
                new Card('3','H'),
                new Card('4','D'),
                new Card('5','D'),
                new Card('6', 'S'),
            };

            return this;
        }

        public PokerHandTestBuilder WithFlush()
        {
            _cards = new List<Card>()
            {
                new Card('2', 'D'),
                new Card('3','D'),
                new Card('4','D'),
                new Card('8','D'),
                new Card('T', 'D'),
            };

            return this;
        }

        public PokerHandTestBuilder WithStraightFlush()
        {
            _cards = new List<Card>()
            {
                new Card('2', 'D'),
                new Card('3','D'),
                new Card('4','D'),
                new Card('5','D'),
                new Card('6', 'D')
            };

            return this;
        }

        public PokerHandTestBuilder WithRoyalFlush()
        {
            _cards = new List<Card>()
            {
                new Card('T', 'D'),
                new Card('J','D'),
                new Card('Q','D'),
                new Card('K','D'),
                new Card('A', 'D')
            };

            return this;
        }

        public PokerHandTestBuilder WithStub()
        {
            _cards = new List<Card>(5);
            return this;
        }

        public PokerHand Build()
        {

            _pokerHand = new PokerHand(_cards); 
            return _pokerHand;
        }
    }
}