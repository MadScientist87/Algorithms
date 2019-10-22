using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Algorithms.Easy;
using System.Text;

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
                sum += (int)Math.Pow(Char.GetNumericValue(place), length);

            }

            return sum == N;
        }

        public string ToLowerCase(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] > 65 && str[i] < 97))
                    newString += (char)(str[i] + 32);
                else
                    newString += (char)(str[i]);
            }

            return newString;
        }

        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var sum = 0;
            Dictionary<int, int> RowMax = new Dictionary<int, int>();
            Dictionary<int, int> ColMax = new Dictionary<int, int>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (!RowMax.ContainsKey(i))
                        RowMax.Add(i, grid[i][j]);
                    else
                        RowMax[i] = Math.Max(RowMax[i], grid[i][j]);


                    if (!ColMax.ContainsKey(i))
                        ColMax.Add(i, grid[j][i]);
                    else
                        ColMax[i] = Math.Max(ColMax[i], grid[j][i]);

                }
            }


            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {
                    var buildingRaisedTo = Math.Min(RowMax[i], ColMax[j]);

                    var difference = buildingRaisedTo - grid[i][j];
                    sum += difference;
                }
            }
            return sum;
        }

        private int getColumnMax(int[][] arr, int col_idx)
        {
            int m = 0;
            for (int i = 0; i < arr[0].Length; ++i)
            {
                m = Math.Max(m, arr[i][col_idx]);
            }
            return m;
        }

        public TreeNode BstToGst(TreeNode root)
        {
            var tree = root;
            SumBranches(root, 0);
            return tree;
        }

        public int SumBranches(TreeNode root, int count)
        {

            if (root == null) return count;

            root.val += SumBranches(root.right, count);
            return SumBranches(root.left, root.val);



        }

        public TreeNode BstToGstiteravtive(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            int previousCount = 0;
            var curr = root;

            while (stack.Count != 0 || curr != null)
            {
                // Keep pushing right as long as the current node is not null
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.right;
                }
                // Once we have a null value go back up the tree and add the value of the node to the previous count and set the previous count to that
                //of the current node. Now we can push left
                else
                {
                    TreeNode node = stack.Pop();
                    node.val += previousCount;
                    previousCount = node.val;
                    curr = node.left;
                }
            }

            return root;
        }

        public TreeNode BstToGstiteravtiveOnOwn(TreeNode root)
        {
            int previousCount = 0;
            var curr = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (stack.Count != 0 || curr != null)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.right;
                }
                else
                {
                    TreeNode node = stack.Pop();
                    node.val += previousCount;
                    previousCount = node.val;
                    curr = node.left;
                }
            }

            return root;
        }

        public TreeNode InsertIntoBST(TreeNode root, int val)
        {

            if (root == null) return new TreeNode(val);
            if (val < root.val)
            {


                root.left = InsertIntoBST(root.left, val);
            }

            if (val > root.val)
            {


                root.right = InsertIntoBST(root.right, val);
            }


            return root;


        }

        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {

            return BuildNodes(0, nums.Length, nums);

        }

        private TreeNode BuildNodes(int left, int right, int[] nums)
        {
            if (left == right) return null;
            var maxValueIndex = GetMaxIndexOfArray(nums, left, right);
            TreeNode root = new TreeNode(nums[maxValueIndex]);
            root.left = BuildNodes(left, maxValueIndex, nums);
            root.right = BuildNodes(maxValueIndex + 1, right, nums);

            return root;
        }


        private int GetMaxIndexOfArray(int[] nums, int left, int right)
        {
            int maxValueIndex = left;
            for (int i = left + 1; i < right; i++)
            {
                if (nums[i - 1] > nums[i])
                    maxValueIndex = i - 1;
            }

            return maxValueIndex;
        }


        public int NumTilePossibilities(string tiles)
        {
            HashSet<string> Result = new HashSet<string>();
            NumTilePossibilitiesHelper("", tiles, Result);
            return Result.Count;
        }
        private void NumTilePossibilitiesHelper(string soFar, string remaining, HashSet<string> result)
        {
            if (!string.IsNullOrEmpty(soFar))
            {
                result.Add(soFar);
            }
            if (remaining == "")
            {
                return;
            }
            else
            {

                for (int i = 0; i < remaining.Length; i++)
                {
                    char candidate = remaining[i];
                    string nextSoFar = soFar + candidate.ToString();
                    string nextRemaining = remaining.Substring(0, i) + remaining.Substring(i + 1);
                    NumTilePossibilitiesHelper(nextSoFar, nextRemaining, result);

                }
            }
        }


        public int NumTilePossibilitiesOnOwn(string tiles)
        {
            HashSet<string> Result = new HashSet<string>();

            NumTilePossibilitiesOnOwnHelper("", tiles, Result);

            return Result.Count();
        }


        private void NumTilePossibilitiesOnOwnHelper(string sofar, string remaining, HashSet<string> Result)
        {
            if (!string.IsNullOrEmpty(sofar))
                Result.Add(sofar);
            if (remaining == "")
                return;


            for (int i = 0; i < remaining.Length; i++)
            {
                char candidate = remaining[i];
                string nextSoFar = sofar + candidate;
                string nextRemaining = remaining.Substring(0, i) + remaining.Substring(1 + i);
                NumTilePossibilitiesOnOwnHelper(nextSoFar, nextRemaining, Result);

            }

            return;
        }

        //1079. Letter Tile Possibilities
        public int numTilePossibilities(String tiles)
        {
            int[] characterCount = new int[26];
            for (int i = 0; i < tiles.Length; i++)
            {
                characterCount[tiles[i] - 'A']++;
            }
            return countPossibleSequences(characterCount);
        }

        private int countPossibleSequences(int[] count)
        {
            int result = 0;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] > 0)
                {
                    count[i]--;
                    result += 1 + countPossibleSequences(count);
                    count[i]++;
                }
            }
            return result;
        }



        public int NumTilePossibilitiesLoop(string tiles)
        {
            HashSet<string> Result = new HashSet<string>();

            for (int i = 0; i < tiles.Length; i++)
            {
                Result.Add(tiles[i].ToString());

                for (int j = i; j < tiles.Length - i; j++)
                {
                    int length = j - i + 1;
                    Result.Add(tiles.Substring(i));
                    Result.Add(Swap(tiles.Substring(i), i, j));
                }
            }


            return Result.Count;
        }

        private string Swap(string original, int startIndex, int endIndex)
        {
            var firstChar = original[startIndex];
            var secondChar = original[endIndex];

            StringBuilder sb = new StringBuilder(original);

            sb[startIndex] = secondChar;
            sb[endIndex] = firstChar;
            return sb.ToString();
        }

        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += Math.Min(nums[i], nums[i + 1]);
            }

            return sum;
        }

        public List<int> findDuplicates(int[] nums)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                    res.Add(Math.Abs(index + 1));
                nums[index] = -nums[index];
            }
            return res;
        }


        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int[] roomAcessed = new int[rooms.Count];

            Stack<int> roomStack = new Stack<int>();
            roomAcessed[0] = 1;
            roomStack.Push(0);

            while (roomStack.Count != 0)
            {
                var room = roomStack.Pop();


                foreach (var key in rooms[room])
                {

                    if (roomAcessed[key] != 1)
                    {
                        roomAcessed[key] = 1;
                        roomStack.Push(key);
                    }

                }

            }

            return roomAcessed.All(a => a == 1);
        }

        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var MasternumericalPattern = GetNumericalPattern(pattern);
            var answer = new List<string>();

            foreach (var word in words)
            {
                if (GetNumericalPattern(word) == MasternumericalPattern)
                    answer.Add(word);
            }

            return answer;
        }

        public string GetNumericalPattern(string word)
        {
            Dictionary<char, int> patternKeeper = new Dictionary<char, int>();
            int uniqueCounter = 0;
            string wordPattern = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (!patternKeeper.ContainsKey(word[i]))
                {
                    uniqueCounter += 1;
                    patternKeeper.Add(word[i], uniqueCounter);
                }

                wordPattern += patternKeeper[word[i]];

            }

            return wordPattern;
        }

        public int[] CountBits(int num)
        {

            int[] answer = new int[num + 1];
            for (int i = num; i >= 0; i--)
            {
                answer[i] = CountBitsHelper(i);
            }
            return answer;
        }

        private int CountBitsHelper(int num)
        {
            int count = 0;

            while (num > 0)
            {
                count += num & 1;

                num = num >> 1;
            }
            return count;

        }

        public int SmallestCommonElement(int[][] mat)
        {
            var minMasterList = GetSmallestElementFromColumns(mat);

            for (int i = 0; i < mat.Length; i++)
            {
                minMasterList = mat[i].Intersect(minMasterList).ToArray();
            }
            return minMasterList.Any() ? minMasterList.Min() : -1;
        }

        private int[] GetSmallestElementFromColumns(int[][] mat)
        {
            List<int> MinArray = new List<int>();
            int min = Int32.MaxValue;
            for (int i = 0; i < mat[0].Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    min = Math.Min(min, mat[j][i]);
                }
                MinArray.Add(min);


                min = Int32.MaxValue;
            }

            return MinArray.ToArray();
        }

        public short Parity(long x)
        {
            short result = 0;

            while (x != 0)
            {
                result ^= 1;
                x &= (x - 1);
            }
            return result;
        }

        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);

            LinkedList<int> queue = new LinkedList<int>();

            queue.AddLast(deck[deck.Length - 1]);

            for (int i = deck.Length - 2; i >= 0; i--)
            {
                int val = queue.FirstOrDefault(); //at first, only contains largest value in array
                queue.RemoveFirst();
                queue.AddLast(val);
                queue.AddLast(deck[i]);
            }

            for (int i = deck.Length - 1; i >= 0; i--)
            {
                deck[i] = queue.FirstOrDefault(); //insert the values in descending order
                queue.RemoveFirst();
            }


            return deck;
        }

        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null) return null;

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.val == 0 && root.left == null && root.right == null) root = null;

            return root;
        }
        int preorderIndex = 0;
        int[] preorderParent;
        public TreeNode BstFromPreorder(int[] preorder)
        {
            preorderParent = preorder;
            return BstFromPreorderHelper(int.MinValue, int.MaxValue);
        }

        private TreeNode BstFromPreorderHelper(int lower, int upper)
        {

            if (preorderIndex == preorderParent.Length) return null;

            int val = preorderParent[preorderIndex];

            if (val < lower || val > upper) return null;

            preorderIndex++;

            TreeNode root = new TreeNode(val);
            root.left = BstFromPreorderHelper(lower, val);
            root.right = BstFromPreorderHelper(val, upper);

            return root;
        }

        public TreeNode bstFromPreorderstack(int[] preorder)
        {
            int n = preorder.Length;
            if (n == 0) return null;

            TreeNode root = new TreeNode(preorder[0]);
            Stack<TreeNode> deque = new Stack<TreeNode>();
            deque.Push(root);

            for (int i = 1; i < n; i++)
            {
                // take the last element of the deque as a parent
                // and create a child from the next preorder element
                TreeNode node = deque.Peek();
                TreeNode child = new TreeNode(preorder[i]);
                // adjust the parent 
                while (deque.Count != 0 && deque.Peek().val < child.val)
                    node = deque.Pop();

                // follow BST logic to create a parent-child link
                if (node.val < child.val) node.right = child;
                else node.left = child;
                // add the child into deque
                deque.Push(child);
            }
            return root;
        }

        public int MinCost(int[][] costs)
        {
            if (costs == null || costs.Length == 0) return 0;

            for (int i = 1; i < costs.Length; i++)
            {
                costs[i][0] += Math.Min(costs[i - 1][1], costs[i - 1][2]);
                costs[i][1] += Math.Min(costs[i - 1][0], costs[i - 1][2]);
                costs[i][2] += Math.Min(costs[i - 1][0], costs[i - 1][1]);
            }

            return Math.Min(costs[costs.Length - 1][0], Math.Min(costs[costs.Length - 1][1], costs[costs.Length - 1][2]));
        }

        int preOrderIndx = 0;

        int[] preOrderArray;

        public TreeNode BstFromPreorderOnOwn(int[] preorder)
        {
            preOrderArray = preorder;

            return BstFromPreorderOnOwnHelper(int.MinValue, int.MaxValue);
        }

        public TreeNode BstFromPreorderOnOwnHelper(int lower, int upper)
        {
            if (preOrderIndx == preOrderArray.Length - 1) return null;

            int val = preOrderArray[preOrderIndx];


            if (val < lower || val > upper) return null;
            preOrderIndx++;
            TreeNode node = new TreeNode(val);

            node.left = BstFromPreorderOnOwnHelper(lower, node.val);
            node.right = BstFromPreorderOnOwnHelper(node.val, upper);

            return node;
        }

        public int[] SortArrayByParity(int[] A)
        {
            return A.OrderBy(a => a % 2).ToArray();
        }

        private short GetParityOfInt(int num)
        {
            short result = 0;
            while (num > 0)
            {
                result ^= 1;

                num &= (num - 1); // Remove Leftmostbit
            }

            return result;
        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;

            if (root.val == val) return root;

            if (val < root.val)
                root = SearchBST(root.left, val);
            else
                root = SearchBST(root.right, val);

            return root;
        }


        private double max = 0;
        public double MaximumAverageSubtree(TreeNode root)
        {
            int[] arr = BFS(root);
            return max;
        }

        private int[] BFS(TreeNode root)
        {
            if (root == null) return new int[] { 0, 0 };

            var left = BFS(root.left);
            var right = BFS(root.left);

            var sum = left[0] + right[0];
            var count = left[1] + right[1];

            max = Math.Max(max, sum / count);

            return new int[] { sum, count };

        }

        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            foreach (char move in moves)
            {
                if (move == 'U') y--;
                else if (move == 'D') y++;
                else if (move == 'L') x--;
                else if (move == 'R') x++;
            }
            return x == 0 && y == 0;
        }

        public int HeightChecker2(int[] heights)
        {
            var orginalArray = new int[heights.Length];
            Array.Copy(heights, orginalArray, heights.Length);
            Array.Sort(heights);
            var countDifference = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != orginalArray[i])
                    countDifference++;
            }

            return countDifference;
        }
        public int HeightChecker(int[] heights)
        {
            int[] count = new int[101];
            for (int i = 0; i < heights.Length; ++i) ++count[heights[i]];
            int ret = 0; int idx = 0;
            for (int i = 0; i < 101; ++i)
            {
                while (count[i]-- > 0)
                {
                    if (heights[idx++] != i)
                        ++ret;
                }
            }
            return ret;
        }

        public IList<int> FindDuplicates2(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                    result.Add(Math.Abs(nums[i]));
                nums[index] = Math.Abs(nums[index]) * -1;
            }
            return result;
        }

        public int BalancedStringSplit(string s)
        {
            var Lcount = 0;
            var Rcount = 0;
            var answer = 0;


            for (int i = 0; i < s.Length; i++)
            {


                if (s[i] == 'R')
                    Rcount++;
                if (s[i] == 'L')
                    Lcount++;
                if (Rcount == Lcount)
                {
                    answer++;
                }
            }

            return answer;
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; int j = n - 1; int k = (m + n) - 1;

            while (i >= 0 || j >= 0)
            {
                nums1[k--] = nums1[i] > nums2[j] ? nums2[j--] : nums1[i--];
            }
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }



        public int[] PairWithSum(int[] nums, int target)
        {
            Dictionary<int, int> PairwithSumOriginalIndex = new Dictionary<int, int>();

            for(int x=0;x<nums.Length;x++)
            {
                PairwithSumOriginalIndex.Add(nums[x], x);
            }

            target -= 30;
            var answer = new int[2];
            Array.Sort(nums);
            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] + nums[j] == target)
                {
                    answer[0] = PairwithSumOriginalIndex[nums[i]];
                    answer[1] = PairwithSumOriginalIndex[nums[j]];

                    if(answer[0] > answer[1])
                    {
                        var temp = answer[1];
                        answer[1] = answer[0];
                        answer[0] = temp;
                    }
                    break;
                }
                if (nums[i] + nums[j] > target)
                    j--;

                else 
                    i++;
            }
            return answer;
        }

        public bool SearchMatrix(int[,] matrix, int target)
        {


            for(int i = 0;i< matrix.GetLength(1);i++)
            {
                for(int j = matrix.GetLength(0) -1; j >=0 ; j--)
                {

                    if ((target >= matrix[0, i] && target <= matrix[j, i]) || matrix[j, i] == target)

                    {
                        var colValue = matrix[j, i];

                        if (colValue == target) return true;

                    }
                    else
                        break;
                    
                }
            }
            return false;
        }
    }
}
