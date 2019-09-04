using System;
namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class AmazonsSortCenterClass
    {
        public int[] AmazonsSortCenter(int truckSpace, int[] packagesSpace)
        {
            int[] answer = new int[2];
            int i = 0;
            int j = packagesSpace.Length -1;
            Array.Sort(packagesSpace);
            int maxi = -1;
            int maxj = -1;
            while (i < j)
            {
                int leftSpace = truckSpace - (packagesSpace[i] + packagesSpace[j]);

                if (leftSpace == 30)
                {
                    if((maxi < packagesSpace[i] || maxi <packagesSpace[j]) && (maxj < packagesSpace[i] || maxj < packagesSpace[j]))
                    {
                        maxi = packagesSpace[i];
                        maxj = packagesSpace[j];
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
                if (leftSpace < 30)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return answer;
        }
    }
}
