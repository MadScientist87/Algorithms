using Algorithms.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    }
}
