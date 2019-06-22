using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Amazon
{
    public class MostCommonWordClass
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var bannedTable = new HashSet<string>();
            var wordAndCount = new Dictionary<string, int>();
            var answer = string.Empty;
            var answerFrequency = 0;

            for (var x = 0; x < banned.Length; x++)
            {
                bannedTable.Add(banned[x]);
            }

            var charArray = paragraph.ToLower().ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                    sb.Append(charArray[i]);
                if ((!char.IsLetter(charArray[i]) || i == charArray.Length -1) && sb.Length != 0)
                {
                    var word = sb.ToString();
                    if (bannedTable.Contains(word))
                    {
                        sb.Clear();
                        continue;
                    }

                    if (wordAndCount.ContainsKey(word))
                        wordAndCount[word] = wordAndCount[word] + 1;
                    else
                        wordAndCount.Add(word, 1);

                    if (wordAndCount[word] > answerFrequency)
                    {
                        answer = word;
                        answerFrequency = wordAndCount[word];
                    }
                    sb.Clear();
                }
            }

            return answer;

        }
    }
}
