using System;
namespace Algorithms.Amazon
{
    public class PrisonAfterNDaysClass
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            int state = 0;
            for (int i = 0; i < 8; ++i)
            {
                if (cells[i] > 0)
                    state ^= 1 << i;
            }

            int[] ans = new int[8];

            return ans;
        }
    }
}
