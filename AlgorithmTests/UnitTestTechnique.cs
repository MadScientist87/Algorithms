using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Algorithms.Technique;
namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestTechnique
    {

        [TestMethod]
        public void MaxSum()
        {
            int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k = 4;
            int n = arr.Length;
            SlidingWindow SlidingWindow = new SlidingWindow();
            SlidingWindow.maxSum(arr, n, k);
        }

        [TestMethod]
        public void MergeSort()
        {

            int[] arr = { 12, 11, 13, 5, 6, 7 };
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);

        }

        [TestMethod]
        public void KthSmallest()
        {

            int[] arr = {12, 11, 13, 4, 3, 7};
            int n = arr.Length;
            int k = 2;
            QuickSelect qs = new QuickSelect();
          var answer=  qs.KthSmallest(arr, 0, n - 1, k);
        }
    }
}
