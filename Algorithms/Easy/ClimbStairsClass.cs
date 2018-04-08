using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class ClimbStairsClass
    {

        // Solution to the problem using a fibonoci solution
        public int ClimbStairs(int n)
        {
            
            // base cases
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int one_step_before = 2;
            int two_steps_before = 1;
            int all_ways = 0;

            for (int i = 2; i < n; i++)
            {
                all_ways = one_step_before + two_steps_before;
                two_steps_before = one_step_before;
                one_step_before = all_ways;
            }
            return all_ways;
        }

        // More concise version b builds up as the iterations
        // increase giving a fibonanci pattern but coming from the tail end

        public int ClimbStairsConcise(int n)
        {
            int a = 1, b = 1;
            while (n-- > 0)
                a = (b += a) - a;
            return a;
        }
    }
}
