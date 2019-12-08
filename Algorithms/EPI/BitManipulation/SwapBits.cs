using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.EPI.BitManipulation
{
    public static class SwapBits
    {
        public static int TestREmoveLastBit(int num)
        {
            var answer = num & ~(num - 1);
            return answer;
        }

        public static int DigitalRoot(long n)
        {
            long sum = 0;
            while (n > 0)
            {

                sum += n % (long)10;
                n = n / 10;

            }

            if (sum > 9)
                sum = DigitalRoot(sum);

            return (int)sum;
        }

        public static List<string> topNCompetitors(int numCompetitors,
                                        int topNCompetitors,
                                        List<string> competitors,
                                        int numReviews, List<string> reviews)
        {
            // WRITE YOUR CODE HERE
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            HashSet<string> competitorSet = new HashSet<string>();
            foreach (var competitor in competitors)
            {
                competitorSet.Add(competitor);
            }


            foreach (var review in reviews)
            {
                var reviewWord = "";
                for (int i = 0; i < review.Length; i++)
                {
                    if (char.IsLetter(review[i]))
                        reviewWord += review[i];
                    if ((!char.IsLetter(review[i]) && reviewWord.Length > 0) || i == review.Length - 1)
                    {
                        if (competitorSet.Contains(reviewWord))
                        {
                            if (!wordDict.ContainsKey(reviewWord))
                                wordDict.Add(reviewWord, 1);
                            else
                            {
                                wordDict[reviewWord] = wordDict[reviewWord] + 1;
                            }
                        }
                        reviewWord = "";
                    }

                }
            }

            var max = wordDict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            return wordDict.OrderByDescending(a => a.Value).ThenBy(a => String.Compare(a.Key, max) < 0).ThenBy(a => a.Key).Take(topNCompetitors > numCompetitors ? numCompetitors : topNCompetitors).Select(a => a.Key).ToList();
        }

        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            Dictionary<string, int> stack = new Dictionary<string, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    return nums[i];
                if (nums[i] == nums[i + 1])
                    i += 1;
                else
                    return nums[i];
            }

            return 0;
        }


        public static long SwapBitsByPosition(long x, int i, int j)
        {
            if((( (uint)x >> i) & 1) != (((uint)x >> j) & 1))
            {
                long bitmask = (1L << i) | (1L << j);
                x ^= bitmask;
            }

            return x;
        }
    }
}
