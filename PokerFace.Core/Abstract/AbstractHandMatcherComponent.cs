using System.Collections.Generic;
using PokerFace.Core.Classes;

namespace PokerFace.Core.Abstract
{
    public abstract class AbstractHandMatcherComponent
    {
        public List<Card> Cards { get; }
        
        public abstract void Evaluate(PokerHand hand);

    }
}