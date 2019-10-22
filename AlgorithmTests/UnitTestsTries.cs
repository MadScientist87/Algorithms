using Algorithms.Easy;
using Algorithms.Tries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestsTries
    {

        [TestMethod]
        public void TestInsertOfTrie()
        {
            string[] keys = {"base","bat" };

            string[] output = { "Not present in trie", "Present in trie" };

            var trieBuilder = new TrieExercise();

            var root = new TrieNode();

            // Construct trie 
            int i;
            for (i = 0; i < keys.Length; i++)
                trieBuilder.Insert(root,keys[i]);

            var found = trieBuilder.Search("base", root);
             trieBuilder.remove(root, "bat");
            var found2 = trieBuilder.Search("base", root);
            var found3 = trieBuilder.Search("bat", root);
        }

    }
}
