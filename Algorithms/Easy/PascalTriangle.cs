using System;
using System.Collections.Generic;

namespace Algorithms.Easy
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> subList = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    int val = 0;
                    if (j == 0 || j == i)
                    {
                        val = 1;

                    }
                    else
                    {
                        val = result[i - 1][j - 1] + result[i - 1][j];
                    }

                    subList.Add(val);
                }

                result.Add(subList);
            }

            return result;
        }
    }
}
