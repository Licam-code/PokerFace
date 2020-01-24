using NUnit.Framework;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.PatternMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.PatternMatcherFixtures
{
    public class FlushMatcherTestFixture
    {

        [Test]
        public void GivenFlushMatch_WhenValueIsFlush_ThenAFlushIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithFlush()
                .Build();
            
            var flushMatcher = new FlushMatcher();
            flushMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Flush));
        }


    }
}