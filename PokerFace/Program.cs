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
            System.Console.WriteLine("Hello! Please confirm that the poker Hands file is available [\\PokerHands\\PokerHands.txt");
            System.Console.WriteLine("Would you like to continue? [y|n]");
            if (System.Console.ReadLine() == "y")
            {

                System.Console.WriteLine("Reading PokerFace hands...");

                var evaluator = new PokerHandEvaluator();
                var fileReader = new FileReaderHelper();
                var loc = AppDomain.CurrentDomain.BaseDirectory + "\\PokerHands\\PokerHands.txt";
                var hands = fileReader.ReadFromFile(loc);
                System.Console.WriteLine("Building Poker hands...");
                var pokerHands = hands.Select(hand => new PokerHandBuilder().AddHand(hand).Build()).ToList();
                System.Console.WriteLine("Results");
                foreach (var hand in pokerHands)
                {
                    evaluator.Evaluate(hand);
                    System.Console.WriteLine(hand.Print());
                }
            }

            System.Console.ReadLine();
        }
    }

}
