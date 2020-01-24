using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Console.PatternMatcher;

namespace PokerFace.Console.Tests.PatternMatcherFixtures
{
    public class RoyalFlushMatcherTestFixture
    {

        [Test]
        public void GivenRoyalFlushMatch_WhenValueIsRoyalFlush_ThenARoyalFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithRoyalFlush()
                .Build();
            
            var royalFlushMatcher = new RoyalFlushMatcher();
            royalFlushMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.RoyalFlush));
        }

        [Test]
        public void GivenRoyalFlushMatch_WhenValueIsStraightFlush_ThenAStraightFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithStraightFlush()
                .Build();

            var royalFlushMatcher = new RoyalFlushMatcher();
            royalFlushMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.StraightFlush));
        }


    }
}