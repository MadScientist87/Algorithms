using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BitManipulation;
using Algorithms.EPI.BitManipulation;
using System.Collections.Generic;
using Algorithms.Easy;
using Algorithms.Medium;

namespace AlgorithmTests
{
    [TestClass]
    public class LinkedListUnitTests
    {
        [TestMethod]
        public void TestAddLinkedList()
        {
            ListNode x = new ListNode(2);
            x.next = new ListNode(4);
            x.next.next = new ListNode(3);

            ListNode y = new ListNode(5);
            y.next = new ListNode(6);
            y.next.next = new ListNode(4);

            var answer = AddTwoNumbersLinkedList.AddTwoNumbers(x, y);


        }
    }
}
