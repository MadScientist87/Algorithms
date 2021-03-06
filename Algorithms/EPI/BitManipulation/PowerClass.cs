﻿using System;
namespace Algorithms.EPI.BitManipulation
{
    public static class PowerClass
    {
        public static double Power(double x, int y)
        {
            double result = 1.0;

            long power = y;
            if (y < 0)
            {
                power = -power;
                x = 1.0 / x;
            }
            while (power != 0)
            {
                if ((power & 1) != 0)
                {
                    result *= x;
                }
                x *= x;
                power = (long)((ulong)power >> 1);
            }

            return result;
        }
    }
}
