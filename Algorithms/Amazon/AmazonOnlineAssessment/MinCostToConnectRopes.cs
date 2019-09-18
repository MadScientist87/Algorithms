using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class MinCostToConnectRopesClass
    {
        public double MinCostToConnectRopes(int[] files)
        {
            List<int> newFiles = new List<int>();

            foreach (var file in files)
            {
                newFiles.Add(file);
            }

            int sum = 0;
            int cost = 0;
            while (newFiles.Count > 1)
            {
                newFiles = newFiles.OrderBy(a => a).ToList();
                int length1 = newFiles.FirstOrDefault();
                newFiles.RemoveAt(0);
                int length2 = newFiles.FirstOrDefault();
                newFiles.RemoveAt(0);

                cost = length1 + length2;
                newFiles.Add(cost);
                sum += cost;

            }

            return sum;
        }
    }
}
