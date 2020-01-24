using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Console;
using PokerFace.Core.Matchers.MultipleMatcher;

namespace PokerFace.Core.Tests.MultipleMatcherFixtures
{
    public class DoubleMultipleMatcherTestFixture
    {

        [Test]
        public void GivenADoubleMultiple_WhenValueIsTwoTwo_Then2PairIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With2Pair()
                .Build();

            var testMultiple = new Dictionary<Rank,int>(){ {Rank.Ace, 2}, {Rank.Eight, 2} };
            var doubleMultiplMatcher = new DoubleMultipleMatcher(testMultiple);
            doubleMultiplMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.TwoPair));


        }

        [Test]
        public void GivenADoubleMultiple_WhenValueIsThreeTwo_ThenHouseIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With3OfAKind()
                .Build();

            var testMultiple = new Dictionary<Rank, int>() { { Rank.Ace, 3 }, { Rank.Eight, 2 } };
            var doubleMultiplMatcher = new DoubleMultipleMatcher(testMultiple);
            doubleMultiplMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.FullHouse));


        }

        
    }
}