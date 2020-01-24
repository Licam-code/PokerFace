using System.Collections.Generic;
using System.Linq;
using PokerFace.Core.Abstract;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;

namespace PokerFace.Core.Matchers.PatternMatcher
{
    public class RoyalFlushMatcher : AbstractHandMatcherComponent
    {
        public override void Evaluate(PokerHand hand)
        {
            //know its a flush and straight now
            hand.Rank = HandRank.StraightFlush;

            var rankHashSet = hand.Cards.Select(c => c.Rank).ToHashSet<Rank>();

            if (rankHashSet.SetEquals(GetRoyalFlush()))
                hand.Rank = HandRank.RoyalFlush;
        }

        private HashSet<Rank> GetRoyalFlush()
        {
            return new HashSet<Rank>(){Rank.Ten, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace};
        }
    }
}