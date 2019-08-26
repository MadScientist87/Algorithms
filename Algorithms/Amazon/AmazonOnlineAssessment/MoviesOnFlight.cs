using System;
namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MoviesOnFlightClass
    {
        public int[] MoviesOnFlight(int[] A, int K)
        {
            K-=30;
            int i = 0;
            int j = A.Length - 1;
            int max = -1;
            int[] answer = new int[2];

            Array.Sort(A);
            while (i < j)
            {
                int sum = A[i] + A[j];
                if (sum < K)
                {
                    max = Math.Max(max, sum);
                    answer[0] = A[i];
                    answer[1] = A[j];

                    i++;
                }
                else
                {
                    j--;
                }
            }
            return answer;
        }
    }
}
