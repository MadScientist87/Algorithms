using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class SearchInsertClass
    {
        public int SearchInsert(int[] nums, int target)
        {
            // Loop through array. if the target Is less than or equal to current int in array
            // return the index. If target is outside the array return the array length which is the same as the last index + 1
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i]) return i;
            }
            return nums.Length;
        }
    }
}
