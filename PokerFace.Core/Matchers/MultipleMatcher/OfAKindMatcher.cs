using System;
using System.Collections.Generic;
using PokerFace.Core.Abstract;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;

namespace PokerFace.Core.Matchers.MultipleMatcher
{
    public class OfAKindMatcher : AbstractHandMatcherComponent
    {
        private KeyValuePair<Rank, int> _rankOfAKind;

        public OfAKindMatcher(KeyValuePair<Rank, int> rankOfAKind)
        {
            _rankOfAKind = rankOfAKind;
        }

        public override void Evaluate(PokerHand hand)
        {
            switch (_rankOfAKind.Value)
            {
                case 2:
                    hand.Rank = HandRank.Pair;
                    break;
                case 3:
                    hand.Rank = HandRank.ThreeKind;
                    break;
                case 4:
                    hand.Rank = HandRank.FourKind;
                    break;
                default:
                    throw new ArgumentException($"Issue determining multiples value {_rankOfAKind.Value} not matched");
            }
        }
    }
}