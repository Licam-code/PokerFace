using System.Linq;
using PokerFace.Core.Abstract;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Interfaces;

namespace PokerFace.Core.Matchers.PatternMatcher
{
    public class FlushMatcher : AbstractHandMatcherComponent, IMatchedHand
    {
        private bool _matched = false;
        public override void Evaluate(PokerHand hand)
        {
            if (hand.Cards.Select(h => h.Suit).Distinct().Count() != 1) return;
            _matched = true;
            hand.Rank = HandRank.Flush;
        }
        public bool Matched()
        {
            return _matched;
        }
    }
}