using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Algorithms.Easy;

namespace Algorithms.StringManipulation
{
    public class WordBreakClass
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            HashSet<String> wordDictSet = new HashSet<string>(wordDict);
            Queue<int> queue = new Queue<int>();
            int[] visited = new int[s.Length];
            queue.Enqueue(0);
            while (queue.Count != 0)
            {
                int start = queue.Dequeue();
                if (visited[start] == 0)
                {
                    for (int end = start + 1; end <= s.Length; end++)
                    {
                        int length = end - start;
                        if (wordDictSet.Contains(s.Substring(start, length)))
                        {
                            queue.Enqueue(end);
                            if (end == s.Length)
                            {
                                return true;
                            }
                        }
                    }
                    visited[start] = 1;
                }
            }
            return false;

        }


        public string RemoveVowels(string S)
        {
            var dictionary = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var answer = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (!dictionary.Contains(S[i]))
                    answer += S[i];
            }

            return answer;

        }


        public int CalculateTime(string keyboard, string word)
        {
            var count = 0;
            var start = 0;
            for (var j = 0; j < word.Length; j++)
            {
                char letter = word[j];
                int index = keyboard.IndexOf(letter);
                count += Math.Abs(start - index);
                start = index;
            }

            return count;
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public string DefangIPaddr2(string address)
        {
            var newString = "";

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                    newString += "[.]";
                else
                    newString += address[i];

            }

            return newString;
        }

        public int NumJewelsInStones(string J, string S)
        {

            var count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (J.IndexOf(S[i]) != -1)
                    count += 1;
            }
            return count;
        }

        public int[] AnagramMappings(int[] A, int[] B)
        {
            var result = new int[A.Length];
            List<int> b = B.ToList();

            for (int j = 0; j < A.Length; j++)
            {
                result[j] = b.IndexOf(A[j]);
            }

            return result;
        }


        public int CountLetters(string S)
        {
            char[] arr = S.ToArray();
            int len = arr.Length;
            int result = 0;
            int count = 0;
            char last = ' ';
            for (int i = 0; i < len; i++)
            {
                if (last == arr[i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                result += count;
                last = arr[i];
            }
            return result;
        }

        public int RangeSumBST(TreeNode root, int L, int R)
        {
            var sum = dfs(root, L, R);
            return sum;

        }

        private int dfs(TreeNode node, int L, int R)
        {
            int sum = 0;
            if (node != null)
            {
                if (L <= node.val && node.val <= R)
                    sum += node.val;
                if (L < node.val)
                    sum += dfs(node.left, L, R);
                if (node.val < R)
                    sum += dfs(node.right, L, R);
            }

            return sum;
        }


        public int RangeSumBSTIterative(TreeNode root, int L, int R)
        {
            int sum = 0;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                var current = stack.Pop();


                if (current.val >= L && current.val <= R)
                    sum += current.val;

                if (current.val > L && current.left != null)
                    stack.Push(current.left);

                if (current.val < R && current.right != null)
                    stack.Push(current.right);
            }

            return sum;
        }

        public bool IsArmstrong(int N)
        {
            int numberOfPlaces = (int)Math.Floor(Math.Log10(Math.Abs(N))) + 1;

            int sum = 0;
            int temp = N;
            for (int i = 0; i < numberOfPlaces; i++)
            {
                sum += (int)Math.Pow(temp % 10, numberOfPlaces);
                temp = (temp / 10);
            }

            return sum == N;
        }

        public bool IsArmstrong2(int N)
        {
            int sum = 0;
            string places = N.ToString();
            int length = places.Length;
            foreach (var place in places)
            {
                sum += (int)Math.Pow(Char.GetNumericValue( place), length);

            }

            return sum == N;
        }
    }
}
