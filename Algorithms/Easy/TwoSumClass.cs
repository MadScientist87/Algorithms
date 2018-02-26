using System;
using System.Collections;
namespace Algorithms.Easy
{

    /*  Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].

    */

    public class TwoSumClass
    {
        public TwoSumClass()
        {
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable hashtable = new Hashtable();

            for (var x = 0; x < nums.Length; x++)
            {
                if (hashtable.ContainsKey((target - nums[x])) )
                {
                    return new int[] { (int)hashtable[target - nums[x]], x};
                }

                if (!hashtable.ContainsKey((nums[x]))) hashtable.Add(nums[x], x);

            }

            throw new ApplicationException("No two sum solution with the provided input");
        }
    }
}
