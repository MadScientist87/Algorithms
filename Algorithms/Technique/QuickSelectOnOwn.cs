using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Technique
{
    public class QuickSelectOnOwn
    {

        //http://www.geekviewpoint.com/java/search/quickselect
        // Java implementation much easier to understand

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int Partition(int[] arr, int left, int right)
        {
            int x = arr[right], i = left;
            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] <= x)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[right]);
            return i;
        }

        public int KthSmallest(int[] arr, int left, int right, int k)
        {

            if (left <= right)
            {
                int index = Partition(arr, left, right);

                if (index == k)
                    return arr[k];

                // If position is more, recur  
                // for left subarray 
                if (index > k)
                    return KthSmallest(arr, left, index - 1, k);

                // Else recur for right subarray 
                return KthSmallest(arr, index + 1, right,
                    k);
            }

            return Int32.MinValue;
        }
    }
}
