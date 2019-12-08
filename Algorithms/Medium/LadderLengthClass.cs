using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Medium
{
    public static class LadderLengthClass
    {
        
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            // Since both beginning and endword are the same length we can set the length here
            int L = beginWord.Length;

            // Dictionary to hold all combos of word with a placeholder
            // I.E *ot-> hot,dot,lot
            Dictionary<string, List<string>> allCombosDict = new Dictionary<string, List<string>>();


            // Loop through all the words in the wordlist and generate the key to be used in dictionary
            // Any word in the wordlist that has a simliar generated key will be added to a list stored
            // in the dictionary's value
            foreach (var word in wordList)
            {
                for (int i = 0; i < L; i++)
                {
                    var newWord = word.Substring(0, i) + "*" + word.Substring(i + 1, L - (i + 1));
                    if (!allCombosDict.ContainsKey(newWord))
                        allCombosDict.Add(newWord, new List<string>());

                    var transformations = allCombosDict.GetValueOrDefault(newWord, new List<string>());
                    transformations.Add(word);
                }
            }

            Queue<KeyValuePair<string, int>> queue = new Queue<KeyValuePair<string, int>>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            // Enqeue our starting word "hit" and initialize level to 1
            queue.Enqueue(new KeyValuePair<string, int>(beginWord, 1));

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                var currentWord = node.Key; 
                var level = node.Value;

                // From the queue reconstruct the key for our dictionary created above
                // If the key exists in the dictionary loop through all adjacent words and add them to the
                // queue if they have not already been visited. We will keep track of the visited from a
                // boolean dictionary
                for (int i = 0; i < L; i++)
                {
                    var newWord = currentWord.Substring(0, i) + "*" + currentWord.Substring(i + 1, L - (i + 1));

                    foreach (var adjacentWord in allCombosDict.GetValueOrDefault(newWord, new List<string>()))
                    {
                        if (adjacentWord == endWord)
                            return level + 1;
                        if (!visited.ContainsKey(adjacentWord))
                        {
                            queue.Enqueue(new KeyValuePair<string, int>(adjacentWord, level + 1));
                            visited.Add(adjacentWord, true);
                        }
                    }
                }

            }

            return 0;
        }

    }
}
