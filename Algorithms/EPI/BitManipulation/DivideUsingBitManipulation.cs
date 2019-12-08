using System;
namespace Algorithms.EPI.BitManipulation
{
    public static class DivideUsingBitManipulation
    {
        public static int Divide(int dividend, int divisor)
        {
            if (int.MinValue == dividend && divisor == -1) return int.MaxValue;

            bool quotientIsNegative = dividend < 0 || divisor < 0;

            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            int result = 0;
            while (dividend - divisor >= 0)
            {
                int x = 0;
                while ((dividend - (divisor << 1 << x)) >= 0)
                {
                    x++;
                }
                result += 1 << x;
                dividend -= divisor << x;
            }

            return quotientIsNegative ? (~(result) + 1) : result;
        }

        public static int DivideOnlyPositive(int dividend, int divisor)
        {
            int result = 0;

            int power = 32;
            long divisorPower = (long)divisor << power;
            while(dividend >= divisor)
            {
                while(divisorPower > dividend)
                {
                   divisorPower = (long)((ulong)divisorPower >> 1);
                    --power;
                }

                result += 1 << power;
                dividend = (int)(dividend- divisorPower);
            }
            return result;
        }
    }
}
