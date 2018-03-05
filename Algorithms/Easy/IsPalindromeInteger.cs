using System;
namespace Algorithms.Easy
{
    public class IsPalindromeInteger
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;

            /* Example 302
                as we reverse the number 2 is the reverted number on the second iteration. x = 30. x is still greater than reverted number so it continues.
                this will cause the function to return false. If 303 was used as an example since the while loop compares the first half of the 
                int to the second. A palindrome is will have the same digits backward and forward. 
                
            */
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            //  x== revertedNumber / 10 takes care of odd integers such as 303 
            // Where x=3 and reverted numer =30. Removing the ones place by dividing by 10 (the odd number (3[0]3)) will allow for comparision
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
