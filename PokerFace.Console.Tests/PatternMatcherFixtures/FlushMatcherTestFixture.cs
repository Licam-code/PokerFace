using NUnit.Framework;
using PokerFace.Console;
using PokerFace.Core.Matchers.PatternMatcher;

namespace PokerFace.Core.Tests.PatternMatcherFixtures
{
    public class FlushMatcherTestFixture
    {

        [Test]
        public void GivenFlushMatch_WhenValueIsFlush_ThenAFlushIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithFlush()
                .Build();
            
            var flushMatcher = new FlushMatcher();
            flushMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.Flush));
        }


    }
}