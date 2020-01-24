using System;

namespace PokerFace.Core
{

    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }
        
        public Card(char rank, char suit)
        {
            Rank = (Rank)Enum.ToObject(typeof(Rank), rank);
            Suit = (Suit)Enum.ToObject(typeof(Suit), suit);
        }

        public bool IsAce()
        {
            return Rank == Rank.Ace;
        }

        public int Index()
        {
            return Array.IndexOf(Enum.GetValues(typeof(Rank)), Rank);
            
        }

        public string Print()
        {
            return ((char) Rank + "" + (char) Suit).ToString();
        }


    }

    public enum HandRank
    {      
        Unmatched,
        HighCard,
        TwoKind,
        TwoPair,
        ThreeKind,
        Straight,
        Flush,
        FullHouse,
        FourKind,
        StraightFlush,
        RoyalFlush
    }

    public enum Rank
    {
        
        Two = '2',
        Three = '3',
        Four = '4',
        Five = '5',
        Six = '6',
        Seven = '7',
        Eight = '8',
        Nine = '9',
        Ten = 'T',
        Jack = 'J',
        Queen ='Q',
        King = 'K',
        Ace = 'A',
    }

    public enum Suit
    {
        Hearts = (int)'H',
        Diamonds = (int)'D',
        Spades = (int)'S',
        Clubs = (int)'C'
    }
}