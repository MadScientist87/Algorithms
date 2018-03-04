using System;
using System.Collections;

namespace Algorithms.Easy
{
    public class RomanToInteger
    {
        public RomanToInteger()
        {
        }

        public int RomanToInt(string s)
        {
            s = s.ToUpper();
            Hashtable hashtable = new Hashtable() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, {'M',1000}};
            var romanNumeralArray = s.ToCharArray();
            int result = 0;
            for (var x = 0; x < romanNumeralArray.Length;x++)
            {
                int current = (int)hashtable[romanNumeralArray[x]];

                int stepAhead = 0;
                if(x<s.Length -1)
                    stepAhead = (int)hashtable[romanNumeralArray[x + 1]];
                if (stepAhead > current && stepAhead != 0)
                {
                    result += stepAhead - current;
                    x++;
                }
                else
                    result += current;
            }
            return result;

        }

    }
}
