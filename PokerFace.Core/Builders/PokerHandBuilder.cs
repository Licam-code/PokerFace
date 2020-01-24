using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerFace.Core.Builders
{
    public class PokerHandBuilder
    {
        private PokerHand _hand;
        private List<Card> _cards = new List<Card>(5);

        public PokerHandBuilder()
        {
            _cards = new List<Card>(5);
        }

        public PokerHandBuilder AddCard(string card)
        {
            var splitCard = card.ToCharArray();
            if (splitCard.Length == 2)
            {
                _cards.Add(new Card(splitCard[0],splitCard[1]));
            }
            else
            {
                throw new ArgumentException("Poker hands are malformed, ");
            }

            return this;
        }
        public PokerHandBuilder AddHand(string hand)
        {
            
            var cards = hand.Split(" ");
            foreach (var card in cards)
            {
                AddCard(card);
            }   
           
            return this;
        }

        public PokerHand Build()
        {
            if (_cards.Count != 5)
            {
                throw new ArgumentOutOfRangeException("5 Cards are needed to make a poker hand");
            }
            _hand = new PokerHand(_cards);
            return _hand;
        }
    }
}
