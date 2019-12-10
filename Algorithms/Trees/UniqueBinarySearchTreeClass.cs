using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Easy;

namespace Algorithms.Trees
{
    public static class UniqueBinarySearchTreeClass
    {
        // This is a dynamic programming problem where we can break the solution down into serveral subproblems
        // For example for a tree with 3 nodes we can have 1,2,3 where if 1 is the root we have two node on the right.
        // to solve the subproblem of 2,3 on the right we break it down into an even smaller subproblem of either 2 or 3
        // having a root of just 1 or zero will yeild only one unique combination of tree nodes. So as we bubble up the
        //recursion stack we can say 1 * 1 = 1 for one or zero nodes. For two nodes it is the combo of [1*1 + 1*1] = 2
        // Now that we know what 2 and 1 equal as we loop through 1 to 3 we can solve for whats on the left and right of
        // the ith integer when that ith is the root. If 2 is the root there is 1 on each side
        // [1 * 1] = 1. if 1 or 3 is the root there are 2 nodes on either the right or the left
        // We solved that subproblem for 2 earlier as [1*1 + 1*1] = 2. So our answer is 2 + 1 + 2 = 5 where iterating through
        // 123 when the ith is the root. [_1_ 2 3], [1 _2_ 3], [1 2 _3_].

        private static Dictionary<int, int> dictOfT = new Dictionary<int, int>();
        private static int result = 0;
        public static int NumTrees(int n)
        {
            if (n <= 1) return 1;
            if (dictOfT.ContainsKey(n)) return dictOfT[n];

            for (int i = 1; i <= n; i++)
            {
                result += (NumTrees(i - 1) * NumTrees(n - i));
            }

            dictOfT.Add(n, result);

            return result;
        }
    }
}
