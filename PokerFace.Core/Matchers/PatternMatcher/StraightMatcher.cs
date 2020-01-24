using System.Linq;
using PokerFace.Core.Abstract;
using PokerFace.Core.Interfaces;

namespace PokerFace.Core.Matchers.PatternMatcher
{
    public class StraightMatcher : AbstractHandMatcherComponent, IMatchedHand
    {
        private bool _matched = false;
        public override void Evaluate(PokerHand hand)
        {
            var isConsecutive = false;
            var orderedRankIndexes = hand.Cards.Select(c => c.Index()).OrderBy(r => r);
            isConsecutive = !orderedRankIndexes.Select((cardindex, loopIndex) => cardindex - loopIndex).Distinct().Skip(1).Any();
            if (!isConsecutive )
            {
                var aceLowRankedIndexes = orderedRankIndexes.Select(r =>
                {
                    if ((Rank) r == Rank.Ace) r = -1;
                    return r;
                }).ToList();
                isConsecutive = !aceLowRankedIndexes.Select((cardindex, loopIndex) => cardindex - loopIndex).Distinct().Skip(1).Any();
            }
                
            if (isConsecutive)
            {
                _matched = true;
                hand.Rank = HandRank.Straight;
            }
               
        }

        public bool Matched()
        {
            return _matched;
        }


    }
}