using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class AddBinaryClass
    {

        // Sum Works printing back out the answer is causing a problem
        // Works for short numbers but will overflow my int variable with large ones
        public string AddBinary(string a, string b)
        {
            int sum = GetSum(a) + GetSum(b);
            Int64 tempsum = 0;
            int length = sum > 1 ? (int) Math.Round( Math.Pow(sum, .5) + 1 ): 1;
            string answer = "";
            Int64 multipler = (int)Math.Pow(2, length - 1);

            for (int x = 0; x < length; x++)
            {
                if (tempsum + multipler <= sum)
                {
                    answer += '1';
                    tempsum += multipler;
                }
                else if (answer == "")
                    answer += string.Empty;
                else
                    answer += '0';
                multipler = multipler / 2;
            }

            if (answer == string.Empty)
                return "0";
            return answer;
        }

        private int GetSum(string a)
        {
            int multipler = (int)Math.Pow(2, a.Length - 1);
            int sum = 0;
            for (int x = 0; x < a.Length; x++)
            {
                if (a[x] == '1')
                    sum += multipler;
                multipler = multipler / 2;
            }

            return sum;
        }

        // Simplier solution
        // Lines up string on top of each other if a bit is turned on in each string
        //It is carried over to the next place.
        public String addBinary(String a, String b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1, j = b.Length - 1, carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (j >= 0) sum += b[j--] - '0';
                if (i >= 0) sum += a[i--] - '0';
                sb.Append(sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) sb.Append(carry);
            return ReverseString(sb.ToString());
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
