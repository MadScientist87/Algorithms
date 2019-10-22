using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms.Medium
{
    public class Codec
    {
        Dictionary<string, string> urls = new Dictionary<string, string>();
        Random random = new Random();

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var newurl = "http://tinyurl.com/" + random.Next(1, 1000).ToString();
            if (!urls.ContainsKey(longUrl))
                urls.Add(longUrl, newurl);
            return newurl;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            if (urls.ContainsValue(shortUrl))
                return urls.SingleOrDefault(a=>a.Value == shortUrl).Key;
            return string.Empty;
        }
    }
}
