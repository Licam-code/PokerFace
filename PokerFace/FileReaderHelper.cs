﻿using System;

namespace PokerFace.Console
{
    public class FileReaderHelper
    {

        public string[] ReadFromFile(string location)
        {
            try
            {
                return System.IO.File.ReadAllLines(location);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw new ArgumentException("Cannot find the Poker Hands File!", e);
            }
            
            
        }
    }
}
