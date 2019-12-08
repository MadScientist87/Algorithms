using System;
namespace Algorithms.EPI.BitManipulation
{
    public static class MultiplyUsingBits
    {
        public static long Multiply(long x, long y)
        {
            long sum = 0;

            while (x != 0)
            {
                if ((x & 1) != 0)
                    sum = add(sum, y);
                x = (uint)x >> 1;
                y = y << 1;
            }

            return sum;
        }

        private static long add(long a, long b)
        {
            while (b != 0)
            {
                long carry = a & b;
                a = a ^ b;

                b = carry << 1;
            }

            return a;
        }
    }
}
