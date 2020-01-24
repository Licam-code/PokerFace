using System.Linq;
using PokerFace.Core.Abstract;

namespace PokerFace.Core.Matchers.MultipleMatcher
{
    public class MultipleMatcher : AbstractHandMatcherComponent
    {
        public override void Evaluate(PokerHand hand)
        {
            var distinctMultipleRanks = hand.Cards.GroupBy(card => card.Rank)
                .Where(card => card.Count() > 1)
                .ToDictionary(d => d.Key, y => y.Count());

            if (distinctMultipleRanks.Count == 1)
            {
                var ofAKindMatcher = new OfAKindMatcher(distinctMultipleRanks.First());
                ofAKindMatcher.Evaluate(hand);
            }

            if (distinctMultipleRanks.Count == 2)
            {
                var doubleMultipleMatcher = new DoubleMultipleMatcher(distinctMultipleRanks);
                doubleMultipleMatcher.Evaluate(hand);
            }

        }
    }
}