using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Core;

namespace PokerFace.Console
{
    public class PokerTestFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenPokerHandPair_WhenMoreThanFiveCards_ArgumentExceptionReturned()
        {

            var c1 = new Card('D', '2');
            var c2 = new Card('H', '2');
            var c3 = new Card('D', '5');
            var c4 = new Card('H', '6');
            var c5 = new Card('D', 'J');
            var c6 = new Card('H', 'Q');
           Assert.Throws<ArgumentException>(() => new PokerHand(new List<Card>() { c1, c2, c3, c4, c5, c6 }));

        }
    }

    public class CardTestFixture
    {

    }
}