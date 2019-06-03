using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Amazon
{
   public  class KClosestPointsToOriginDivideAndConquer
    {
        int[][] points;

        public int[][] kClosest(int[][] points, int K)
        {
            this.points = points;
            KthSmallest(0, points.Length - 1, K);
            var answer = new int[K][];
                Array.Copy(points, answer, K);
                return answer;
        }
        public void Swap( int i,  int j)
        {
            int t0 = points[i][0], t1 = points[i][1];
            points[i][0] = points[j][0];
            points[i][1] = points[j][1];
            points[j][0] = t0;
            points[j][1] = t1;
        }

        public int Partition( int left, int right)
        {
            int x = EuclideanDistanceFromOrigin(points[right][0], points[right][1]), i = left;
            for (int j = left; j <= right - 1; j++)
            {
                if (EuclideanDistanceFromOrigin(points[j][0], points[j][1]) <= x)
                {
                    Swap(i,j);
                    i++;
                }
            }
            Swap(i, right);
            return i;
        }

        public void KthSmallest( int left, int right, int k)
        {

            if (left <= right)
            {
                int index = Partition(left, right);

                if (index == k)
                    return;

                // If position is more, recur  
                // for left subarray 
                if (index > k)
                     KthSmallest( left, index - 1, k);

                // Else recur for right subarray 
                 KthSmallest(index + 1, right, k);
            }

            return;
        }

        private int EuclideanDistanceFromOrigin(int p1, int p2)
        {
            return ((p1 * p1) + (p2 * p2));
            // actual formula for euclidean distance is below but we do not need to take sqrt in our case.
            // Math.Sqrt((p1*p1)+(p2*p2));
        }
    }
}
