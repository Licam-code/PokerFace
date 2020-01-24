using NUnit.Framework;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Matchers.MultipleMatcher;
using PokerFace.Core.Tests.BuilderFixtures;

namespace PokerFace.Core.Tests.MatcherFixtures.MultipleMatcherFixtures
{
    public class MultipleMatcherTestFixture
    {
        [Test]
        public void GivenAMultiple_WhenValueIsTwo_ThenPairIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithPair()
                .Build();

            var multipleMatcher = new MultipleMatcher();
            multipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.Pair));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsThree_Then3OfAKindIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .With3OfAKind()
                .Build();

            var multipleMatcher = new MultipleMatcher();
            multipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.ThreeKind));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsFour_Then4OfAKindIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .With4OfAKind()
                .Build();

            var multipleMatcher = new MultipleMatcher();
            multipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.FourKind));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsTwoTwo_Then2PairIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .With2Pair()
                .Build();

            var multipleMatcher = new MultipleMatcher();
            multipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.TwoPair));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsTHreTwo_ThenFullHouseIsReturned()
        {
            var hand = new PokerHandTestBuilder()
                .WithFullHouse()
                .Build();

            var multipleMatcher = new MultipleMatcher();
            multipleMatcher.Evaluate(hand);

            Assert.That(hand.Rank, Is.EqualTo(HandRank.FullHouse));

        }




    }
}