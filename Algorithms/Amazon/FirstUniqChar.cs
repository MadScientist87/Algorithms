using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Amazon
{
    public class FirstUniqCharClass
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> cache =
           new Dictionary<char, int>();
            Dictionary<char, int> repeatedcache =
           new Dictionary<char, int>();

            for (int x = 0; x < s.Length; x++)
            {
            
                if (cache.ContainsKey(s[x]))
                {
                    if (repeatedcache.ContainsKey(s[x]))
                    {
                        repeatedcache[s[x]] = x;
                    }
                    else
                    {
                        repeatedcache.Add(s[x], x);

                    }
                    cache.Remove(s[x]);
                }
                else if(!repeatedcache.ContainsKey(s[x]))
                    cache.Add(s[x], x);
            }

            if (cache.Count > 0)
            {
                return cache.OrderBy(kvp => kvp.Value).First().Value;
            }

            return -1;
        }
    }
}
