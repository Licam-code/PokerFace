using System.Collections.Generic;
using System.Linq;
using PokerFace.Core.Abstract;

namespace PokerFace.Core.Matchers.MultipleMatcher
{
    public class DoubleMultipleMatcher : AbstractHandMatcherComponent
    {
        private Dictionary<Rank, int> _distinctMultiples;

        public DoubleMultipleMatcher(Dictionary<Rank, int> multiples)
        {
            _distinctMultiples = multiples;
        }

        public override void Evaluate(PokerHand hand)
        {
            if (_distinctMultiples.Any(r => r.Value == 3))
            {
                hand.Rank = HandRank.FullHouse;
            } ;
            if (_distinctMultiples.All(r => r.Value == 2))
                hand.Rank = HandRank.TwoPair;
        }
    }
}