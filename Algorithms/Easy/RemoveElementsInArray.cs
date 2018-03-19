using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class RemoveElementsInArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        public int RemoveElement(ref int[] nums, int val)
        {

            // This moves everything down one in a single for loop
            // Loops through the num array and looks for anything that is not the target value and places it at the front of the array
            // i only keeps track of the front of the array
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
    }
}
