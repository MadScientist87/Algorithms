using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class StrStrImplentation
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
                return -1;
            for (int x = 0; ; x++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length) return x;
                    if (x + j == haystack.Length) return -1;
                    if (haystack[j + x] != needle[j]) break;
                }
            }
        }
    }
}
