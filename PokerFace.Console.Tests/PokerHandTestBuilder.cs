using System.Collections.Generic;

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
                new Card('S', 'A'),
                new Card('D', 'J'),
                new Card('H', '2'),
                new Card('D', '5'),
                new Card('D', '8')
            };

            return this;
        }
        
        public PokerHandTestBuilder WithPair()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', 'A'),
                new Card('D', '2'),
                new Card('D', '5'),
                new Card('D', '8')
            };

            return this;
        }

        public PokerHandTestBuilder With2Pair()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', 'A'),
                new Card('D', '2'),
                new Card('S', '2'),
                new Card('D', '8')
            };

            return this;
        }

        public PokerHandTestBuilder With3OfAKind()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', 'A'),
                new Card('C', 'A'),
                new Card('S', '2'),
                new Card('D', '8')
            };

            return this;
        }

        public PokerHandTestBuilder With4OfAKind()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', 'A'),
                new Card('C', 'A'),
                new Card('H', 'A'),
                new Card('D', '8')
            };

            return this;
        }

        public PokerHandTestBuilder WithFullHouse()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', 'A'),
                new Card('C', 'A'),
                new Card('H', '8'),
                new Card('D', '8')
            };

            return this;
        }

        public PokerHandTestBuilder WithStraightWheel()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'A'),
                new Card('D', '2'),
                new Card('C', '3'),
                new Card('H', '4'),
                new Card('D', '5')
            };

            return this;
        }

        public PokerHandTestBuilder WithStraight()
        {
            _cards = new List<Card>()
            {
                new Card('S', '3'),
                new Card('D', '4'),
                new Card('C', '5'),
                new Card('H', '6'),
                new Card('D', '7')
            };

            return this;
        }

        public PokerHandTestBuilder WithFlush()
        {
            _cards = new List<Card>()
            {
                new Card('S', '3'),
                new Card('S', '4'),
                new Card('S', 'K'),
                new Card('S', '6'),
                new Card('S', 'T')
            };

            return this;
        }

        public PokerHandTestBuilder WithStraightFlush()
        {
            _cards = new List<Card>()
            {
                new Card('S', '3'),
                new Card('S', '4'),
                new Card('S', '5'),
                new Card('S', '6'),
                new Card('S', '7')
            };

            return this;
        }

        public PokerHandTestBuilder WithRoyalFlush()
        {
            _cards = new List<Card>()
            {
                new Card('S', 'T'),
                new Card('S', 'J'),
                new Card('S', 'Q'),
                new Card('S', 'K'),
                new Card('S', 'A')
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