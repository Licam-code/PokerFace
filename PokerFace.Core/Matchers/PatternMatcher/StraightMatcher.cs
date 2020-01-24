using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PokerFace.Core.Abstract;
using PokerFace.Core.Classes;
using PokerFace.Core.Enums;
using PokerFace.Core.Interfaces;

namespace PokerFace.Core.Matchers.PatternMatcher
{
    public class StraightMatcher : AbstractHandMatcherComponent, IMatchedHand
    {
        private bool _matched = false;
        private Rank[] _rankOrder;

        

        public override void Evaluate(PokerHand hand)
        {
            _rankOrder = BuildRankOrder();
            var orderedRankIndexes = hand.Cards.Select(c => Array.FindIndex(_rankOrder,row => row == c.Rank)).OrderBy(r => r).ToList();
            var matchesStraight = isConsecutive(orderedRankIndexes);
            if(!matchesStraight) 
            {
                var aceLowRankedIndexes = AceLowRankedIndexes(orderedRankIndexes);
                matchesStraight = isConsecutive(aceLowRankedIndexes);
            }
                
            if (matchesStraight)
            {
                _matched = true;
                hand.Rank = HandRank.Straight;
            }
               
        }

        private List<int> AceLowRankedIndexes(List<int> orderedRankIndexes)
        {
            var aceLowRankedIndexes = orderedRankIndexes.Select(r =>
            {
                if ( r == 12) r = -1;
                return r;
            }).OrderBy(r => r).ToList();
            return aceLowRankedIndexes;
        }

        public bool Matched()
        {
            return _matched;
        }

        private bool isConsecutive(List<int> ranks)
        {
            return !ranks.Select((cardIndex, loopIndex) => cardIndex - loopIndex).Distinct().Skip(1).Any();
        }
        private Rank[] BuildRankOrder()
        {
            return new[]
            {
                Rank.Two,
                Rank.Three,
                Rank.Four,
                Rank.Five,
                Rank.Six,
                Rank.Seven,
                Rank.Eight,
                Rank.Nine,
                Rank.Ten,
                Rank.Jack,
                Rank.Queen,
                Rank.King,
                Rank.Ace
            };

        }

    }
}