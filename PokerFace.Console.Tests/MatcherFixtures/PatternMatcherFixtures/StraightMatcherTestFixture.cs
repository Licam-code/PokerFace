using NUnit.Framework;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.PatternMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.PatternMatcherFixtures
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
                .WithStraightWheel()
                .Build();

            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Straight));
        }


    }
}