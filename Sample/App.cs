﻿using System.Globalization;

namespace Sample
{
    class App
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            
            ContosoPets.Start();
            // StringModifications.FindSubstringsComplex();
            // StringModifications.FindAnySubstring();
            //  ArraysAndStrings.SplitJoin();
            // StringModifications.ChallengeManipulateString();
        }
    }    
}