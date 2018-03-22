using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int high = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > high)
                    {
                        high = sum;
                    }
                }
            }
            return high;
        }

        // Dynamic programming solution
        public int MaxSubArrayDP(int[] nums)
        {
            int max = 0, sum = 0;
            sum = nums[0];
            max = sum;
            for (int i = 1; i < nums.Length; i++)
            {
                sum = nums[i] + (sum < 0 ? 0 : sum);
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
