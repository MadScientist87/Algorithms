using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Easy;

namespace Algorithms.Amazon
{
    public class PartitionLabelsClass
    {
        /*
         * 
         */
        public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            // The first loop is to gather where the last occurence of a letter is found in the string and store the index of that
            // last occurence in an array that represents the alphabet 
            for (int i = 0; i < S.Length; ++i)
                last[S[i] - 'a'] = i;

            int j = 0, anchor = 0;
            List<int> ans = new List<int>();
            for (int i = 0; i < S.Length; ++i)
            {
                // As we loop through the string again we attempt to find the end of the parition which is J represents the index 
                // when the last occurence of current letter in string.
                j = Math.Max(j, last[S[i] - 'a']);
                // if we find the current loop matches the last max occurence of a letter we use the anchor variable to keep track of the length 
                // of the partitions
                if (i == j)
                {
                    ans.Add(i - anchor + 1);
                    anchor = i + 1;
                }
            }

            return ans;
        }











        public IList<int> PartitionLabels2(string S)
        {
            var answer = new List<int>();
            int[] last = new int[26];
            for (var i = 0; i < S.Length; i++)
            {
                last[S[i] - 'a'] = i;
            }

            int j = 0;
            int anchor = 0;

            for (var i = 0; i < S.Length; i++)
            {
                j = Math.Max(j, last[S[i] - 'a']);
                if (i == j)
                {
                    answer.Add(i - anchor + 1);
                    anchor = i + 1;
                }
            }

            return answer;
        }
    }
}
