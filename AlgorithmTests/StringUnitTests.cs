using System;
using Algorithms.Easy;
using Algorithms.StringManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace AlgorithmTests
{
    [TestClass]
    public class StringUnitTests
    {
        [TestMethod]
        public void WordBreak()
        {
            WordBreakClass wordBreak = new WordBreakClass();


            //var answer= wordBreak.WordBreak("aaaaaaa", new List<string> { "aaaa", "aaa" });
            // wordBreak.CalculateTime("abcdefghijklmnopqrstuvwxyz", "cba");
            var answer = wordBreak.IsArmstrong2(153);
        }

    }
}
