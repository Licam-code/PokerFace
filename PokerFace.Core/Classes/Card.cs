using System;
using PokerFace.Core.Enums;

namespace PokerFace.Core.Classes
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

   
}