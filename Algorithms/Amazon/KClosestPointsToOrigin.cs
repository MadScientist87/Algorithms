using System;
using Algorithms.Technique;
using System.Collections.Generic;
namespace Algorithms.Amazon
{
    public class KClosestPointsToOrigin
    {
       

        public int[][] KClosest(int[][] points, int K)
        {
            
            int[] distanceArray = new int[points.Length];
            for(var x=0;x< points.Length;x++)
            {
                distanceArray[x] = EuclideanDistanceFromOrigin(points[x][0], points[x][1]);
            }

            QuickSelectOnOwn QuickSelectOnOwn = new QuickSelectOnOwn();
           var ksmallest= QuickSelectOnOwn.KthSmallest(distanceArray, 0, points.Length - 1, K - 1);
            int[][] answer = new int[K][];
            var kcount = K;
            for (var x = 0; x < points.Length; x++)
            {
                var distance = EuclideanDistanceFromOrigin(points[x][0], points[x][1]);
                if (distance <= ksmallest)
                {
                    answer[kcount-1] = new int [] { points[x][0], points[x][1]};
                    kcount--;
                }
                   
            }

            return answer;
        }

        private int EuclideanDistanceFromOrigin(int p1, int p2)
        {
            return ((p1 * p1) + (p2 * p2));
            // actual formula for euclidean distance is below but we do not need to take sqrt in our case.
            // Math.Sqrt((p1*p1)+(p2*p2));
        }
    }
}
