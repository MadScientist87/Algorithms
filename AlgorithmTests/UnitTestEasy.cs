using Algorithms.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestEasy
    {
        [TestMethod]
        public void RomanToInteger()
        {
            RomanToInteger romanToInteger = new RomanToInteger();
            Assert.AreEqual(romanToInteger.RomanToInt("MDCCLXXVI"), 1776);
        }

        [TestMethod]
        public void TwoSum()
        {
            TwoSumClass twoSumClass = new TwoSumClass();
            int[] nums = new int[] { 800, 4, 800, 21 };
            int target = 821;
            var result = twoSumClass.TwoSum(nums, target);
            CollectionAssert.AreEqual(result, new int[] { 0, 3 });
        }

        [TestMethod]
        public void ReverseInteger()
        {
            ReverseInteger reverseInteger = new ReverseInteger();
            int num = 123;
            Assert.AreEqual(reverseInteger.Reverse(num), 321);
        }

        [TestMethod]
        public void IsValidParentheses()
        {
            ValidParentheses isValidParentheses = new ValidParentheses();
            string sample = "((";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
            sample = "(())";
            Assert.AreEqual(isValidParentheses.IsValid(sample), true);
            sample = "((])";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
            sample = "([)]";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
        }

        [TestMethod]
        public void IsPalindromeInteger()
        {
            IsPalindromeInteger isPalindromeInteger = new IsPalindromeInteger();
            Assert.IsTrue(isPalindromeInteger.IsPalindrome(303));
        }

        [TestMethod]
        public void LongestCommonPrefix()
        {
            LongestCommonPrefixClass longestCommonPrefixClass = new LongestCommonPrefixClass();
            var result = longestCommonPrefixClass.LongestCommonPrefix(new[] { "earthly", "earth", "ear" });
            Assert.AreEqual(result, "ear");
        }

        [TestMethod]
        public void SortedLinkedList()
        {
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            var l1 = new ListNode(1);
            var second = l1.next = new ListNode(2);
            second.next = new ListNode(4);

            var l2 = new ListNode(1);
            var secondl2 = l2.next = new ListNode(3);
            secondl2.next = new ListNode(4);

            var answer = sortedLinkedList.MergeTwoLists(l1, l2);

            while (answer != null)
            {
                var test = answer.val;

                answer = answer.next;
            }
        }

        [TestMethod]
        public void RemoveElement()
        {
            RemoveElementsInArray RemoveElementsInArray = new RemoveElementsInArray();
            int[] theArray = new int[] { 3, 2, 2, 3 };
            int length = RemoveElementsInArray.RemoveElement(ref theArray, 3);
            CollectionAssert.AreEqual(theArray.SubArray(0, length), new int[] { 2, 2 });
        }

        [TestMethod]
        public void StrStrTest()
        {
            StrStrImplentation StrStrImplentation = new StrStrImplentation();
            var index = StrStrImplentation.StrStr("hello", "ll");
            Assert.AreEqual(index, 2);
        }

        [TestMethod]
        public void BitWise()
        {
            var answer = 8 << 4;
            Assert.AreEqual(answer, 128);
        }

        [TestMethod]
        public void SearchInsert()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 2;
            SearchInsertClass SearchInsertClass = new SearchInsertClass();
            var answer = SearchInsertClass.SearchInsert(nums, target);
            Assert.AreEqual(answer, 1);
        }

        [TestMethod]
        public void CountAndSay()
        {
            CountAndSayClass CountAndSayClass = new CountAndSayClass();
            var answer = CountAndSayClass.CountAndSay(5);
        }

        [TestMethod]
        public void MaximumSubarray()
        {
            MaximumSubarray MaximumSubarray = new MaximumSubarray();
            int[] array = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var answer = MaximumSubarray.MaxSubArray(array);
            Assert.AreEqual(answer, 6);
        }

        [TestMethod]
        public void LengthofLastWord()
        {
            LengthofLastWordClass LengthofLastWordClass = new LengthofLastWordClass();
            var answer = LengthofLastWordClass.LengthOfLastWord("a  ");
            Assert.AreEqual(answer, 1);
        }
    }

}
