using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Technique
{
    public class QuickSelect
    {

        int partition(int[] arr, int l, int r)
        {
            int x = arr[r], i = l;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[r]);
            return i;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int KthSmallest(int[] arr, int l, int r, int k)
        {
            // If k is smaller than number of  
            // elements in array 
            if (k > 0 && k <= r - l + 1)
            {

                // Partition the array around last  
                // element and get position of pivot  
                // element in sorted array 
                int index = partition(arr, l, r);

                // If position is same as k 
                if (index - l == k - 1)
                    return arr[index];

                // If position is more, recur  
                // for left subarray 
                if (index - l > k - 1)
                    return KthSmallest(arr, l, index - 1, k);

                // Else recur for right subarray 
                return KthSmallest(arr, index + 1, r,
                    k - index + l - 1);
            }

            // If k is more than number of  
            // elements in array 
            return Int32.MaxValue;
        }
    }
}
