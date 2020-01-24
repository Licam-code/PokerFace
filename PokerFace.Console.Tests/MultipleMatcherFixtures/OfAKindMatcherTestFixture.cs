using System.Collections.Generic;
using NUnit.Framework;

namespace PokerFace.Console.Tests.MultipleMatcherFixtures
{
    public class OfAKindMatcherTestFixture
    {

        [Test]
        public void GivenAnOfAKindMatch_WhenValueIsTwo_ThenAPairIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .WithPair()
                .Build();

            var testMultiple = new KeyValuePair<Rank,int>(Rank.Ace, 2);
            var ofAKindMatcher = new OfAKindMatcher(testMultiple);
            ofAKindMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.TwoKind));


        }

        [Test]
        public void GivenAnOfAKindMatch_WhenValueIsThree_Then3OfAKindIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With3OfAKind()
                .Build();

            var testMultiple = new KeyValuePair<Rank, int>(Rank.Ace, 3);
            var ofAKindMatcher = new OfAKindMatcher(testMultiple);
            ofAKindMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.ThreeKind));


        }

        [Test]
        public void GivenAnOfAKindMatch_WhenValueIs4_Then4OfAKindIsReturned()
        {
            var _hand = new PokerHandTestBuilder()
                .With4OfAKind()
                .Build();

            var testMultiple = new KeyValuePair<Rank, int>(Rank.Ace, 4);
            var ofAKindMatcher = new OfAKindMatcher(testMultiple);
            ofAKindMatcher.Evaluate(_hand);

            Assert.That(_hand.Rank, Is.EqualTo(HandRank.FourKind));


        }
    }
}