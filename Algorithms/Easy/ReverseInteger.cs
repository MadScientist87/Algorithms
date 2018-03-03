using System;
namespace Algorithms.Easy
{
    public class ReverseInteger
    {
        public ReverseInteger()
        {
        }

        public int Reverse(int x)
        {
            int result = 0;
            bool isNegative = x < 0;
            int prev_result = 0;

            // If negative number change to positive for reversal
            if (isNegative)
                x = x * -1;

            while(x !=0)
            {
               
                int currentplaceofinteger = x % 10;
               
                /* In the example of 123 for the first iteration of this function result would be 3.
                    0 * 10 + 3. Place of integer would also be 3. 123 % 10 is 3. The prev_result is 0 so result-placeofinteger
                    3-3 is = to 0.

                    the second iteration is result =32 and placeofinteger is 2. (32-2) / 10 = 3. Since the previous result now contains 3. The 
                    overflow check still passes.
                */

                result = result * 10 + (currentplaceofinteger);

                if ((result - currentplaceofinteger) / 10 != prev_result)
                {
                    // Return zero in case of reversed integer overflow. (number was two large to be stored in an integer)
                    return 0;
                }

                prev_result = result;

                // remove a place value of x so the loop can process the next digit using the modulus operator
                x = x / 10;

            }

            if (isNegative)
                result = result * -1;


            return result;
        }
    }
}
