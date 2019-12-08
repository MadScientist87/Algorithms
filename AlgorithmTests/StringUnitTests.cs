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

            //int[][] grid = new int[4][];

            //grid[0] = new int [] { 3, 0, 8, 4 };
            //grid[1] = new int[] { 2, 4, 5, 7 };
            //grid[2] = new int[] { 9, 2, 6, 3 };
            //grid[3] = new int[] { 0, 3, 1, 0 };
            //var answer = wordBreak.MaxIncreaseKeepingSkyline(grid);

            //TreeNode tree = new TreeNode(4);
            //tree.left = new TreeNode(1);
            //tree.right = new TreeNode(6);
            //tree.left.left = new TreeNode(0);
            //tree.left.right = new TreeNode(2);
            //tree.left.right.right = new TreeNode(3);
            //tree.right.left = new TreeNode(5);
            //tree.right.right = new TreeNode(7);
            //tree.right.right.right = new TreeNode(8);
            List<IList<int>> rooms = new List<IList<int>>();

            rooms.Add(new List<int> { 2});
            rooms.Add(new List<int> { });
            rooms.Add(new List<int> { 1});
            //rooms.Add(new List<int> {  0});

            int[][] grid = new int[4][];

            grid[0] = new int[] { 1, 2, 3, 4,5 };
            grid[1] = new int[] { 2, 4, 5, 8, 10 };
            grid[2] = new int[] { 3, 5, 7, 9, 11 };
            grid[3] = new int[] { 1, 3, 5, 7, 9 };

            TreeNode tree = new TreeNode(8);
            tree.left = new TreeNode(5);
            tree.right = new TreeNode(10);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(7);
            tree.right.left = null;
            tree.right.right = new TreeNode(12);


           //int[,] matrix = new int[5, 5] { { 1, 4, 7, 11, 15 } ,{ 2, 5, 8, 12, 19 },{ 3, 6, 9, 16, 22 },{ 10, 13, 14, 17, 24 } ,{ 18, 21, 23, 26, 30 } };

            // int[,] matrix = new int[1, 1] { { -5 } };
            int[,] matrix = new int[1, 2] { { 1,1} };
        


            var answer = wordBreak.FindNumber(100398,100999 );

        }



    }
}
