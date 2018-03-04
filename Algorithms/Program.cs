using System;
using Algorithms.Easy;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // TwoSumClass test = new TwoSumClass();
            // int[] nums = new int []{ 800, 4, 800, 21 };
            // int target = 821;
            //var answer= test.TwoSum(nums, target);
            //Console.WriteLine(answer[0]+" "+ answer[1]);

            //ReverseInteger test = new ReverseInteger();
            //int num = 123;
            //Console.WriteLine(test.Reverse(num)); 

            //IsPalindromeInteger test = new IsPalindromeInteger();
            //test.IsPalindrome(303);

            RomanToInteger test = new RomanToInteger();
            Console.WriteLine(test.RomanToInt("MDCCLXXVI"));
        }
    }
}
