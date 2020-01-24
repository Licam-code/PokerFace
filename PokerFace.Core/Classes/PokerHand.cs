using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace PokerFace.Core
{
    public class PokerHand
    {
        public List<Card> Cards { get; }
        private int _maxCards = 5;
        private HandRank _rank;

        public PokerHand(List<Card> cards)
        {
            if (cards.Count != _maxCards)
                throw new ArgumentException("Too many Cards! 5 only for this game!");
            Cards = cards;
            _rank = HandRank.HighCard;
        }


        public Card HighCard => Cards.OrderByDescending(c => c.Index()).First();

        public HandRank Rank
        {
            get => _rank;
            set { if((int)value > (int)_rank)_rank = value; }
        }

        public string Print()
        {
            var sb = new StringBuilder();
            foreach (var card in Cards)
            {
                sb.Append((char)((int)card.Rank) + "" + (char)((int)card.Suit) + " ");
            }

            sb.Append("... " + _rank.ToString());
            return sb.ToString();
        }
    }


}