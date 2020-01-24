using NUnit.Framework;
using PokerFace.Console;
using PokerFace.Core.Matchers.PatternMatcher;

namespace PokerFace.Core.Tests.PatternMatcherFixtures
{
    public class RoyalFlushMatcherTestFixture
    {

        [Test]
        public void GivenRoyalFlushMatch_WhenValueIsRoyalFlush_ThenARoyalFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithRoyalFlush()
                .Build();
            
            var royalFlushMatcher = new RoyalFlushMatcher();
            royalFlushMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.RoyalFlush));
        }

        [Test]
        public void GivenRoyalFlushMatch_WhenValueIsStraightFlush_ThenAStraightFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithStraightFlush()
                .Build();

            var royalFlushMatcher = new RoyalFlushMatcher();
            royalFlushMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.StraightFlush));
        }


    }
}