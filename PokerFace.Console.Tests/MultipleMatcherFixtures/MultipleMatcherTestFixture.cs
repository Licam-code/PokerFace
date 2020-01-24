using NUnit.Framework;

namespace PokerFace.Console.Tests.MultipleMatcherFixtures
{
    public class MultipleMatcherTestFixture
    {
        [Test]
        public void GivenAMultiple_WhenValueIsTwo_ThenPairIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithPair()
                .Build();

            var multipleMatcher = new MultipleMatcher.MultipleMatcher();
            multipleMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.TwoKind));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsThree_Then3OfAKindIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With3OfAKind()
                .Build();

            var multipleMatcher = new MultipleMatcher.MultipleMatcher();
            multipleMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.ThreeKind));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsFour_Then4OfAKindIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With4OfAKind()
                .Build();

            var multipleMatcher = new MultipleMatcher.MultipleMatcher();
            multipleMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.FourKind));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsTwoTwo_Then2PairIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With2Pair()
                .Build();

            var multipleMatcher = new MultipleMatcher.MultipleMatcher();
            multipleMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.TwoPair));

        }

        [Test]
        public void GivenAMultiple_WhenValueIsTHreTwo_ThenFullHouseIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithFullHouse()
                .Build();

            var multipleMatcher = new MultipleMatcher.MultipleMatcher();
            multipleMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.FullHouse));

        }




    }
}