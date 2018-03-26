using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class PlusOneClass
    {
        public int[] PlusOne(int[] digits)
        {
            int carryover = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + carryover == 10)
                {
                    carryover = 1;
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + carryover;
                    carryover = 0;
                }
            }
            if (carryover == 0)
                return digits;
            else
            {
                int[] newDigits = new int[digits.Length + carryover];
                newDigits[0] = carryover;
                for (int i = 0; i < digits.Length; i++)
                {
                    newDigits[i + 1] = digits[i];
                }
                return newDigits;
            }
        }


        // Shorter code but same runtime as above
        public int[] PlusOneShorter(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] newNumber = new int[digits.Length + 1];
            newNumber[0] = 1;
            return newNumber;
        }
    }
}
