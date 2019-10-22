using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms.Tries
{
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public bool IsEndOfWord;

        public TrieNode NextNode;
        public TrieNode()
        {
            IsEndOfWord = false;
            for (int i = 0; i < 26; i++)
                children[i] = null;
        }
    }


    public class TrieExercise
    {
        public void Insert(TrieNode root, string key)
        {
            var previousCrawl = root;

            for (int i = 0; i < key.Length; i++)
            {
                var index = key[i] - 'a';
                if (previousCrawl.children[index] == null)
                    previousCrawl.children[index] = new TrieNode();
                previousCrawl = previousCrawl.children[index];
            }
            previousCrawl.IsEndOfWord = true;
        }

        public bool Search(string key, TrieNode root)
        {
            var previousCrawl = root;
            for (int i = 0; i < key.Length; i++)
            {
                if (previousCrawl.children[key[i] - 'a'] != null)
                    previousCrawl = previousCrawl.children[key[i] - 'a'];
                else return false;
            }
            return previousCrawl != null && previousCrawl.IsEndOfWord;
        }

        bool isEmpty(TrieNode root)
        {
            for (int i = 0; i < 26; i++)
                if (root.children[i] != null)
                    return false;
            return true;
        }

        public TrieNode remove(TrieNode root, string key, int depth = 0)
        {
            // If tree is empty 
            if (root == null)
                return null;

            // If last character of key is being processed 
            if (depth == key.Length)
            {

                // This node is no more end of word after 
                // removal of given key 
                if (root.IsEndOfWord)
                    root.IsEndOfWord = false;

                // If given is not prefix of any other word 
                if (isEmpty(root))
                {
                    root = null;
                }

                return root;
            }

            // If not last character, recur for the child 
            // obtained using ASCII value 
            int index = key[depth] - 'a';
            root.children[index] =
                  remove(root.children[index], key, depth + 1);

            // If root does not have any child (its only child got  
            // deleted), and it is not end of another word. 
            if (isEmpty(root) && root.IsEndOfWord == false)
            {
                root = null;
            }

            return root;
        }

    }
}
