using System;
namespace Algorithms.BitManipulation
{
    public static class IntExtensions
    {
        public static string ToBinaryString(this int num)
        {
            return Convert.ToString(num, 2).PadLeft(32, '0');
        }
    }
}
