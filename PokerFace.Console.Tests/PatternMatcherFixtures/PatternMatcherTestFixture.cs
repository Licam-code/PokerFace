using System.Collections.Generic;
using NUnit.Framework;
using PokerFace.Console.PatternMatcher;

namespace PokerFace.Console.Tests.PatternMatcherFixtures
{
    public class PatternMatcherTestFixture
    {

        [Test]
        public void GivenPatternMatch_WhenValueIsFlush_ThenAFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithFlush()
                .Build();
            
            var patternMatcher = new PatternMatcher.PatternMatcher();
            patternMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.Flush));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsStraight_ThenAStraightIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();

            var patternMatcher = new PatternMatcher.PatternMatcher();
            patternMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.Straight));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsStraightFlush_ThenAStraightFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithStraightFlush()
                .Build();

            var patternMatcher = new PatternMatcher.PatternMatcher();
            patternMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.StraightFlush));
        }

        [Test]
        public void GivenPatternMatch_WhenValueIsRoyalFlush_ThenARoyalFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithRoyalFlush()
                .Build();

            var patternMatcher = new PatternMatcher.PatternMatcher();
            patternMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.RoyalFlush));
        }


    }
}