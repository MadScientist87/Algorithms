using System;
using System.Collections.Generic;
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
            MedianOfTwoSortedArrays.FindMedianSortedArrays(new int[]{1,3}, new int[]{2});
        }
    }
}
