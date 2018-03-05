using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            String prefix = strs[0];

            // Example input: "earthly", "earth", "ear"
            /* This will loop through the array of strings and narrow down the prefix as it loops.
               When it gets to the next entry in the for loop the while loop will remove chars from the prefix 
               until it returns 0 which means the prefix exists in the string from index 0. for example
               if the prefix is earth it will exist in earthly but not in ear. two chars will be removed until ear
               can exist in ear and that will get returned. 
             */

            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            return prefix;
        }
    }
}
