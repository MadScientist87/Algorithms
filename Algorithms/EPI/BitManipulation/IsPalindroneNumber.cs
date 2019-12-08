using System;
namespace Algorithms.EPI.BitManipulation
{
    public static class IsPalindroneNumberClass
    {
        public static bool IsPalindroneNumber(int x)
        {
            if (x <= 0)
                return false;

            int numOfDigits = (int)(Math.Floor(Math.Log10(x))) + 1;
            int msdMask = (int)Math.Pow(10, numOfDigits - 1);

            for(int i= 0; i<(numOfDigits / 2); i++)
            {
                if(x/msdMask != x%10)
                {
                    return false;
                }

                // Remove the front number
                x %= msdMask;

                // Remove the tail number
                x /= 10;

                //Shorten the mask so we can remove the front on the next pass
                msdMask /= 100;
            }

            return true;
        }
    }
}
