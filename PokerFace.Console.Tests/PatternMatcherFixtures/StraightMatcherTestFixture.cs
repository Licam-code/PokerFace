using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Console.PatternMatcher;

namespace PokerFace.Console.Tests.PatternMatcherFixtures
{
    public class StraightMatcherTestFixture
    {

        [Test]
        public void GivenStraightMatch_WhenValueIsStraight_ThenAStraightIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();
            
            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.Straight));
        }

        [Test]
        public void GivenStraightMatch_WhenValueIsAceLowStraight_ThenAStraightIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();

            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.Straight));
        }


    }
}