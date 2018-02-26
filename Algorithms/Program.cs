using System;
using Algorithms.Easy;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumClass test = new TwoSumClass();
            int[] nums = new int []{ 2, 7, 11, 15 };
            int target = 9;
           var answer= test.TwoSum(nums, target);
            Console.WriteLine(answer[0]+" "+answer[1]);
        }
    }
}
