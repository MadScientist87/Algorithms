using System;
namespace Algorithms.Amazon
{
    public class MergeStonesOnOwnClass
    {
        public int MergeStones(int[] stones, int K)
        {
            int len = stones.Length;
            //Base case
            if ((len - 1) % (K - 1) > 0)
                return -1;

            int[] preSum = new int[len + 1];

            for (int i = 1; i < len + 1; i++)
            {
                preSum[i] = stones[i - 1] + preSum[i - 1];
            }

            int[,] dp = new int[len, len];

            for (int span = K; span <= len; span++)
            {

                for (int left = 0; left + span <= len; left++)
                {
                    int right = left + span - 1;

                    dp[left, right] = int.MaxValue;

                    for (int split = left; split < right; split += (K - 1))
                    { // since K is 1 based and we can merge only K piles. 
                        // This splits inbetween the left and right i.e. for left =1 and right =3 we will add 
                        // dp[left, split] (1,1) + dp[split + 1, right] (2,3) and compare to the minimum of index 1 and 3 in our 2d array
                        dp[left, right] = Math.Min(dp[left, right], dp[left, split] + dp[split + 1, right]);
                    }

                    if ((left - right) % (K - 1) == 0)
                    {
                        dp[left, right] += (preSum[right + 1] - preSum[left]);
                    }
                }

            }

            return dp[0,len-1];
        }
    }
}
