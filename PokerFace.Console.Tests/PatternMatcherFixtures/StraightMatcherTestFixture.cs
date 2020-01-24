using NUnit.Framework;
using PokerFace.Console;
using PokerFace.Core.Matchers.PatternMatcher;

namespace PokerFace.Core.Tests.PatternMatcherFixtures
{
    public class StraightMatcherTestFixture
    {

        [Test]
        public void GivenStraightMatch_WhenValueIsStraight_ThenAStraightIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();
            
            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Straight));
        }

        [Test]
        public void GivenStraightMatch_WhenValueIsAceLowStraight_ThenAStraightIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithStraight()
                .Build();

            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Straight));
        }


    }
}