using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Amazon;
using Algorithms.Easy;


namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestAmazon
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var AddTwoNumbersClass = new AddTwoNumbersClass();
            AddTwoNumbersClass.AddTwoNumbers(l1, l2);

        }


        [TestMethod]
        public void LengthOfLongestSubstring()
        {
            LengthOfLongestSubstringClass LengthOfLongestSubstringClass = new LengthOfLongestSubstringClass();
            LengthOfLongestSubstringClass.LengthOfLongestSubstring("abcabcbb");
        }

        [TestMethod]
        public void MedianOfTwoSortedArrays()
        {
            MedianOfTwoSortedArrays MedianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
            MedianOfTwoSortedArrays.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
        }

        [TestMethod]
        public void ReorderLogFiles()
        {
            ReorderLogFilesClass ReorderLogFilesClass = new ReorderLogFilesClass();
            ReorderLogFilesClass.ReorderLogFiles(new string[]
                {"a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"});
        }


        [TestMethod]
        public void KclosetToOrigin()
        {
            int[] p = { 1, 3 };
            int[] q = { -2, 2 };
            int[][] array = new int[][] { p, q };

            KClosestPointsToOrigin KClosetPointsToOrigin = new KClosestPointsToOrigin();
            KClosetPointsToOrigin.KClosest(array, 1);
        }

        [TestMethod]
        public void KclosetToOrigin2()
        {
            int[] p = { 3, 3 };
            int[] q = { 5, -1 };
            int[] z = { -2, 4 };
            int[][] array = new int[][] { p, q, z };

            KClosestPointsToOriginDivideAndConquer KClosetPointsToOrigin = new KClosestPointsToOriginDivideAndConquer();
            KClosetPointsToOrigin.kClosest(array, 2);
        }

        [TestMethod]
        public void LRUCache()
        {
            LRUCache LRUCache = new LRUCache(2);
            LRUCache.Put(1, 1);
        }

        [TestMethod]
        public void LongestPalindromeSubString()
        {
            LongestPalindromeOnOwn LongestPalindromeSubString = new LongestPalindromeOnOwn();
            var answer = LongestPalindromeSubString.LongestPalindrome("babbad");
        }

        [TestMethod]
        public void MostCommonWord()
        {
            MostCommonWordClass MostCommonWord = new MostCommonWordClass();
            string answer = MostCommonWord.MostCommonWord("bob",
                new string[] {""});
        }

        [TestMethod]
        public void NumberOfIslands()
        {
            NumberOfIslands NumberOfIslands = new NumberOfIslands();

            char[][] grid = new char[4][];
            grid[0] = new char[]{ '1', '1', '1', '1', '0' };
            grid[1] = new char[] { '1', '1', '0', '1', '0' };
            grid[2] = new char[] { '1', '1', '0', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '0', '1' };
         

            int answer = NumberOfIslands.NumIslands(grid);

        }

    }
}
