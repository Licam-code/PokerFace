
using PokerFace.Core.Abstract;

namespace PokerFace.Core.Matchers.PatternMatcher
{
    public class PatternMatcher : AbstractHandMatcherComponent
    {
        public override void Evaluate(PokerHand hand)
        {
            var flushMatcher = new FlushMatcher();
            flushMatcher.Evaluate(hand);

            var straightMatcher = new StraightMatcher();
            straightMatcher.Evaluate(hand);

            if (!flushMatcher.Matched() && !straightMatcher.Matched() )
                return;
            

            if (flushMatcher.Matched() && straightMatcher.Matched())
            {
                var royalFlushMatcher = new RoyalFlushMatcher();
                royalFlushMatcher.Evaluate(hand);
            }

        }
    }
}