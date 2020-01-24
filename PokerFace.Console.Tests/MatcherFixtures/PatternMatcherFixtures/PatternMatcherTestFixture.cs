using NUnit.Framework;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.PatternMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.PatternMatcherFixtures
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