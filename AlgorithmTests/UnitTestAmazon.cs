using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Amazon;
using Algorithms.Easy;
using Algorithms.Amazon.AmazonOnlineAssessment;

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
                new string[] { "" });
        }

        [TestMethod]
        public void NumberOfIslands()
        {
            NumberOfIslands NumberOfIslands = new NumberOfIslands();

            char[][] grid = new char[4][];
            grid[0] = new char[] { '1', '1', '1', '1', '0' };
            grid[1] = new char[] { '1', '1', '0', '1', '0' };
            grid[2] = new char[] { '1', '1', '0', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '0', '1' };


            int answer = NumberOfIslands.NumIslands(grid);

        }

        [TestMethod]
        public void PrisonAfterNDays()
        {
            PrisonAfterNDaysClass PrisonAfterNDays = new PrisonAfterNDaysClass();
            int[] cells = new int[] { 1, 0, 0, 1, 0, 0, 1, 0 };

            var answer = PrisonAfterNDays.PrisonAfterNDays(cells, 4);
        }

        [TestMethod]
        public void FirstUniqChar()
        {
            FirstUniqCharClass firstUniqCharvar = new FirstUniqCharClass();
            string s = "aadadaad";

            var answer = firstUniqCharvar.FirstUniqChar(s);
        }

        [TestMethod]
        public void MoviesOnFlight()
        {
            MoviesOnFlightClass MoviesOnFlight = new MoviesOnFlightClass();
            int[] durations = new int[] { 90, 85, 75, 60, 120, 150, 125 };
            var answer = MoviesOnFlight.MoviesOnFlight(durations, 250);
        }

        [TestMethod]
        public void TreasureIsland()
        {
            TreasureIslandClass TreasureIsland = new TreasureIslandClass();

            char[][] island = new char[][]{
            new char[]{'O', 'O', 'O', 'O'},
            new char[]{'D', 'O', 'D', 'O'},
            new char[]{'O', 'O', 'O', 'O'},
            new char[]{'X', 'D', 'D', 'O'}
            };
            var answer = TreasureIsland.TreasureIsland(island);
        }

        [TestMethod]
        public void AmazonsSortCenterClass()
        {
            AmazonsSortCenterClass AmazonsSortCenter = new AmazonsSortCenterClass();

            int[] packagesSpace = new[] { 1, 10, 20, 25, 35, 40, 60 };
            var answer = AmazonsSortCenter.AmazonsSortCenter(90, packagesSpace);
        }

        [TestMethod]
        public void RollDice()
        {
            RollDiceClass rollDice = new RollDiceClass();

            int[] dice = new[] { 1, 2, 3 };
            var answer = rollDice.RollDice(dice);
        }


        [TestMethod]
        public void PartitionLabels()
        {
            PartitionLabelsClass PartitionLabels = new PartitionLabelsClass();
            IList<int> answer = PartitionLabels.PartitionLabels2("ababcbacadefegdehijhklij");
        }


        public void MinCosttoConnectAllNodes()
        {
            MinCosttoConnectAllNodesClassOnOwn minCosttoConnectAllNodes = new MinCosttoConnectAllNodesClassOnOwn();

            int nodes = 6;
            int[][] edges = { new int[] { 1, 4 }, new int[] { 4, 5 }, new int[] { 2, 3 } };
            int[][] newEdges = { new int[] { 1, 2, 5 }, new int[] { 1, 3, 10 }, new int[] { 1, 6, 2 }, new int[] { 5, 6, 5 } };
            var answer = minCosttoConnectAllNodes.MinCosttoConnectAllNodes(nodes, edges, newEdges);
        }

        [TestMethod]
        public void MinCosttoConnectToRepairEdges()
        {

            MinCosttoRepairEdgesClass minCosttoConnectAllNodes = new MinCosttoRepairEdgesClass();
            int nodes = 5;
            int[][] edges = { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 1, 5 } };
            int[][] edgesToRepair = { new int[] { 1, 2, 12 }, new int[] { 3, 4, 30 }, new int[] { 1, 5, 8 } };
            var answer = minCosttoConnectAllNodes.MinCosttoConnectAllNodes(nodes, edges, edgesToRepair);


            int nodes2 = 6;
            int[][] edges2 = { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 4, 5 }, new int[] { 3, 5 }, new int[] { 1, 6 }, new int[] { 2, 4 } };
            int[][] edgesToRepair2 = { new int[] { 1, 6, 410 }, new int[] { 2, 4, 800 } };
            var answer2 = minCosttoConnectAllNodes.MinCosttoConnectAllNodes(nodes2, edges2, edgesToRepair2);
        }

        [TestMethod]
        public void MinCostToConnectRopes()
        {
            MinCostToConnectRopesClass MinCostToConnectRopes = new MinCostToConnectRopesClass();
            int[] files = new[] { 8, 4, 6, 12 };
            var answer = MinCostToConnectRopes.MinCostToConnectRopes(files);
        }

        [TestMethod]
        public void MergeStones()
        {
            MergeStonesOnOwnClass MergeStones = new MergeStonesOnOwnClass();
            int[] stones = new[] { 3, 5,1,2,6 };
            var answer = MergeStones.MergeStones(stones, 3);
        }
    }
}
