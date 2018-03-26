using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class LengthofLastWordClass
    {
        public int LengthOfLastWord(string s)
        {
            char previous = ' ';
            int counter = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i] != ' ')
                {
                    if (previous == ' ')
                        counter = 0;
                    counter++;
                }
                previous = s[i];
            }
          
            return counter;
        }
    }
}
