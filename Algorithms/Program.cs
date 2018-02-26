using System;
using Algorithms.Easy;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumClass test = new TwoSumClass();
            int[] nums = new int []{ 800, 4, 800, 21 };
            int target = 821;
           var answer= test.TwoSum(nums, target);
            Console.WriteLine(answer[0]+" "+ answer[1]);
        }
    }
}
