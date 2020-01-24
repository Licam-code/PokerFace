using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using PokerFace.Console;
using PokerFace.Core;
using PokerFace.Core.Builders;

namespace PokerFace.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! Please confirm that the poker Hands file is available.");
            System.Console.WriteLine("Reading PokerFace hands...");

            var evaluator = new PokerHandEvaluator();
            var pokerHands = new List<PokerHand>();
            var fileReader = new FileReaderHelper();
            var loc = AppDomain.CurrentDomain.BaseDirectory + "\\PokerHands\\PokerHands.txt";
            var hands = fileReader.ReadFromFile(loc);
            System.Console.WriteLine("Building Poker hands...");
            foreach (var hand in hands)
            {
                var pokerHand = new PokerHandBuilder().AddHand(hand).Build();
                pokerHands.Add(pokerHand);
            }
            System.Console.WriteLine("Results");
            foreach (var hand in pokerHands)
            {
                evaluator.Evaluate(hand);
                System.Console.WriteLine(hand.Print());
            }


            //Initialisation
            //--read in cards from file
            //--build structures to hold the static data
            //-- need array to hold the order of cards
            //-- Dictionary to hold the dealtSuits + dealtCards?
            //use logic to determine hands
            //= Flush loop all cards to check suit (hashtable)?
            //- Straight - order cards + check high and low if they are within5 of each other, then check the other thre are consequitive
            //- StraightFlush + Royal FLush - check flush and staight procs
            //- Multiple Checks
            // - Use hastable to check for multiples, start with fours, threes, pairs,house etc
            //display results to user
            //-- loop records and print


            // examples of dictionary
            // --Dealt Suits = dictionarychar,char>(s, count)
            // -- -- if len = 1 --> flush
            // -- dealt cards = dict<char, char>(c,count)
            // -- -- if len = 5 no mulitples
            // -- -- -- flush, straight check only
            // -- -- if len < 5 no straight    
            // -- -- -- check multiples only

        }
    }

}
