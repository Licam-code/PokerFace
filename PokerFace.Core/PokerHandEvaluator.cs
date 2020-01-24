using PokerFace.Core.Abstract;
using PokerFace.Core.Matchers.MultipleMatcher;
using PokerFace.Core.Matchers.PatternMatcher;

namespace PokerFace.Core
{
    public class PokerHandEvaluator : AbstractHandMatcherComponent
    {
 
        public override void Evaluate(PokerHand hand)
        {
            var patternMatcher = new PatternMatcher();
            var multipleMatcher = new MultipleMatcher();

            multipleMatcher.Evaluate(hand);
            patternMatcher.Evaluate(hand);
            
        }
    }
}