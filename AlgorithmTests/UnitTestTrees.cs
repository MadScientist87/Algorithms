using System;
using Algorithms.Easy;
using Algorithms.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestTrees
    {
        [TestMethod]
        public void InOrderTraversal()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.InOrderTravesal(tree);

            List<int> result = new List<int>() { 4, 2, 5, 1, 3 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void PreOrderTraversal()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.PreOrderTravesal(tree);

            List<int> result = new List<int>() { 1, 2, 4, 5, 3 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }


        [TestMethod]
        public void PostOrderTraversal()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.PostOrderTravesal(tree);

            List<int> result = new List<int>() { 4, 5, 2, 3, 1 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void PreOrderTraversalIterative()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.PreOrderTravesalIterative(tree);

            List<int> result = new List<int>() { 1, 2, 4, 5, 3 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void InOrderTraversalIterative()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.InOrderTravesalIterative(tree);

            List<int> result = new List<int>() { 4, 2, 5, 1, 3 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void PostOrderTraversalIterative()
        {
            DFSTreeSearchClass DFSTreeSearch = new DFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.PostOrderTravesalIterative(tree);

            List<int> result = new List<int>() { 4, 5, 2, 3, 1 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void BFSLevelOrderTraversalIterative()
        {
            BFSTreeSearchClass DFSTreeSearch = new BFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            DFSTreeSearch.LevelOrderTravesal(tree);

            List<int> result = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> answer = DFSTreeSearch.result;


            CollectionAssert.AreEqual(result, answer);
        }

        [TestMethod]
        public void BFSReverseLevelOrderTraversalIterative()
        {
            BFSTreeSearchClass DFSTreeSearch = new BFSTreeSearchClass();

            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            var test= DFSTreeSearch.ZigzagLevelOrder(tree);

            List<int> result = new List<int>() { 5, 4, 3, 2, 1 };
            List<int> answer = DFSTreeSearch.result;


            //CollectionAssert.AreEqual(result, answer);
        }
    }
}
