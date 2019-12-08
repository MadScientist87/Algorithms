using System;
namespace Algorithms.EPI.BitManipulation
{
    public static class ClosestIntSameBitCountClass
    {
        public static long ClosestIntSameBitCount(long x)
        {
            const int NUM_UNSIGNED_BITS = 63;

            // If x was equal to 5 the binary representation would be 0101
            // After one loop iteration we would shift x by 0 which would not change the binary representation 0101
            // We would shift x by 1 which would change the binary representation to 0010. We would compare on the 1 place bit to see if they are equal
            // Since 0101 and  0010 the 1 and 0 in the respective 1s place do not match we then attempt to build a bit mask
            // we shift a long of 1 0 places which yields 0001 and shift a long 1, 1 place which yields 0010
            // We then use the bitwise or of 0001 and 0010 to get a mask of 0011 which in an int is 3
            // Finally we exclusive or this value against our original x
            // (x)     0101 = 5
            // (mask)  0011 = 3
            //  =      0110 which yields 6


            for (int i = 0; i < NUM_UNSIGNED_BITS;i ++)
            {
                if ((((uint)x >> i) & 1) != (((uint)x >> i +1) & 1))
                {
                    x ^= (1L << i) | (1L << i + 1);
                    return x;
                }
            }

            throw new ArgumentException("All Bits are either 0 or 1");
        }

        private static uint lowestBitSet(uint x)
        {
            return (x & ~(x - 1));
        }

        private static uint lowestBitNotSet(uint x)
        {
            return ~x & (x + 1);
        }


        public static uint                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        closestInt(uint x)
        {
            uint ns = lowestBitNotSet(x);
            uint s = lowestBitSet(x);                                 
            if (ns > s)
            {
                x |= ns;
                x ^= ns >> 1;                                                                          
            }
            else
            {
                x ^= s;
                x |= s >> 1;
            }
            return x;
        }
    }

   
}
