using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.MultipleMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.MultipleMatcherFixtures
{
    public class DoubleMultipleMatcherTestFixture
    {

        [Test]
        public void GivenADoubleMultiple_WhenValueIsTwoTwo_Then2PairIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .With2Pair()
                .Build();

            var testMultiple = new Dictionary<Rank,int>(){ {Rank.Ace, 2}, {Rank.Eight, 2} };
            var doubleMultipleMatcher = new DoubleMultipleMatcher(testMultiple);
            doubleMultipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.TwoPair));


        }

        [Test]
        public void GivenADoubleMultiple_WhenValueIsThreeTwo_ThenHouseIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .With3OfAKind()
                .Build();

            var testMultiple = new Dictionary<Rank, int>() { { Rank.Ace, 3 }, { Rank.Eight, 2 } };
            var doubleMultipleMatcher = new DoubleMultipleMatcher(testMultiple);
            doubleMultipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.FullHouse));


        }

        
    }
}