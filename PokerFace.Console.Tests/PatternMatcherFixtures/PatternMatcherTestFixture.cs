using NUnit.Framework;
using PokerFace.Console;
using PokerFace.Core.Matchers.PatternMatcher;

namespace PokerFace.Core.Tests.PatternMatcherFixtures
{
    public class PatternMatcherTestFixture
    {

        [Test]
        public void GivenPatternMatch_WhenValueIsFlush_ThenAFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithFlush()
                .Build();
            
            var patternMatcher = new PatternMatcher();
            patternMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Flush));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsStraight_ThenAStraightIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();

            var patternMatcher = new PatternMatcher();
            patternMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Straight));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsStraightFlush_ThenAStraightFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithStraightFlush()
                .Build();

            var patternMatcher = new PatternMatcher();
            patternMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.StraightFlush));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsRoyalFlush_ThenARoyalFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithRoyalFlush()
                .Build();

            var patternMatcher = new PatternMatcher();
            patternMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.RoyalFlush));
        }


    }
}