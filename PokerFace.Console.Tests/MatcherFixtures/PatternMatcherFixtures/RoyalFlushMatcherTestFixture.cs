using NUnit.Framework;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.PatternMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.PatternMatcherFixtures
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