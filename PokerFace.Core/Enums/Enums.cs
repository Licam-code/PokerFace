namespace PokerFace.Core.Enums
{
    public enum HandRank
    {      
        HighCard,
        Pair,
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
        Queen = 'Q',
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