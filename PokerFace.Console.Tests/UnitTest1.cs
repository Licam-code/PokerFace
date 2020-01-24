using System;
using System.Collections.Generic;
using NUnit.Framework;

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

            var c1 = new Main.Card('D', '2');
            var c2 = new Main.Card('H', '2');
            var c3 = new Main.Card('D', '5');
            var c4 = new Main.Card('H', '6');
            var c5 = new Main.Card('D', 'J');
            var c6 = new Main.Card('H', 'Q');
           Assert.Throws<ArgumentException>(() => new PokerHand(new List<Main.Card>() { c1, c2, c3, c4, c5, c6 }));

        }
    }
}