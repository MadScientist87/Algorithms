using Algorithms.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestEasy
    {
        [TestMethod]
        public void RomanToInteger()
        {
            RomanToInteger romanToInteger = new RomanToInteger();
            Assert.AreEqual(romanToInteger.RomanToInt("MDCCLXXVI"), 1776);
        }

        [TestMethod]
        public void TwoSum()
        {
            TwoSumClass twoSumClass = new TwoSumClass();
            int[] nums = new int[] { 800, 4, 800, 21 };
            int target = 821;
            var result = twoSumClass.TwoSum(nums, target);
            CollectionAssert.AreEqual(result, new int[] { 0, 3 });
        }

        [TestMethod]
        public void ReverseInteger()
        {
            ReverseInteger reverseInteger = new ReverseInteger();
            int num = 123;
            Assert.AreEqual(reverseInteger.Reverse(num), 321);
        }

        [TestMethod]
        public void IsValidParentheses()
        {
            ValidParentheses isValidParentheses = new ValidParentheses();
            string sample = "((";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
            sample = "(())";
            Assert.AreEqual(isValidParentheses.IsValid(sample), true);
            sample = "((])";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
            sample = "([)]";
            Assert.AreEqual(isValidParentheses.IsValid(sample), false);
        }

        [TestMethod]
        public void IsPalindromeInteger()
        {
            IsPalindromeInteger isPalindromeInteger = new IsPalindromeInteger();
            Assert.IsTrue(isPalindromeInteger.IsPalindrome(303));
        }

        [TestMethod]
        public void LongestCommonPrefix()
        {
            LongestCommonPrefixClass longestCommonPrefixClass = new LongestCommonPrefixClass();
            var result = longestCommonPrefixClass.LongestCommonPrefix(new[] { "earthly", "earth", "ear" });
            Assert.AreEqual(result, "ear");
        }

        [TestMethod]
        public void SortedLinkedList()
        {
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            var l1 = new ListNode(1);
            var second = l1.next = new ListNode(2);
            second.next = new ListNode(4);

            var l2 = new ListNode(1);
            var secondl2 = l2.next = new ListNode(3);
            secondl2.next = new ListNode(4);

            var answer = sortedLinkedList.MergeTwoLists(l1, l2);

            while (answer != null)
            {
                var test = answer.val;

                answer = answer.next;
            }
        }

        [TestMethod]
        public void RemoveElement()
        {
            RemoveElementsInArray RemoveElementsInArray = new RemoveElementsInArray();
            int[] theArray = new int[] { 3, 2, 2, 3 };
            int length = RemoveElementsInArray.RemoveElement(ref theArray, 3);
            CollectionAssert.AreEqual(theArray.SubArray(0, length), new int[] { 2, 2 });
        }

        [TestMethod]
        public void StrStrTest()
        {
            StrStrImplentation StrStrImplentation = new StrStrImplentation();
            var index = StrStrImplentation.StrStr("hello", "ll");
            Assert.AreEqual(index, 2);
        }

        [TestMethod]
        public void BitWise()
        {
            var answer = 8 << 4;
            Assert.AreEqual(answer, 128);
        }

        [TestMethod]
        public void SearchInsert()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 2;
            SearchInsertClass SearchInsertClass = new SearchInsertClass();
            var answer = SearchInsertClass.SearchInsert(nums, target);
            Assert.AreEqual(answer, 1);
        }

        [TestMethod]
        public void CountAndSay()
        {
            CountAndSayClass CountAndSayClass = new CountAndSayClass();
            var answer = CountAndSayClass.CountAndSay(5);
        }

        [TestMethod]
        public void MaximumSubarray()
        {
            MaximumSubarray MaximumSubarray = new MaximumSubarray();
            int[] array = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var answer = MaximumSubarray.MaxSubArray(array);
            Assert.AreEqual(answer, 6);
        }

        [TestMethod]
        public void LengthofLastWord()
        {
            LengthofLastWordClass LengthofLastWordClass = new LengthofLastWordClass();
            var answer = LengthofLastWordClass.LengthOfLastWord("a  ");
            Assert.AreEqual(answer, 1);
        }

        [TestMethod]
        public void PlusOne()
        {
            PlusOneClass PlusOneClass = new PlusOneClass();
            var answer = PlusOneClass.PlusOne(new[] { 9, 8, 9 });

        }

        [TestMethod]
        public void AddBinary()
        {
            AddBinaryClass AddBinaryClass = new AddBinaryClass();
            var answer = AddBinaryClass.addBinary("1110110101", "1110111011");

        }
        [TestMethod]
        public void SqrtX()
        {
            SqrtX SqrtX = new SqrtX();
            var answer = SqrtX.FloorSqrt(8);
        }

        [TestMethod]
        public void ClimbStairs()
        {
            ClimbStairsClass ClimbStairsClass = new ClimbStairsClass();
            var answer = ClimbStairsClass.ClimbStairsConcise(4);
        }


        [TestMethod]
        public void DeleteDuplicatesList()
        {
            DeleteDuplicatesNodes DeleteDuplicatesNodes = new DeleteDuplicatesNodes();
            var l1 = new ListNode(2);
            var second = l1.next = new ListNode(2);
            second.next = new ListNode(4);



            var answer = DeleteDuplicatesNodes.DeleteDuplicates(l1);

            while (answer != null)
            {
                var test = answer.val;

                answer = answer.next;
            }
        }
        [TestMethod]
        public void MergeSortedArray()
        {
            MergeSortedArrayClass MergeSortedArrayClass = new MergeSortedArrayClass();
            int[] num1 = new int[1];
            //num1[0] = 0;
            //num1[1] = 2;
            //num1[2] = 3;
            //num1[3] = 4;
            //num1[4] = 5;

            int[] num2 = new int[1];
            num2[0] = 1;
            //num2[1] = 4;




            MergeSortedArrayClass.Merge(ref num1, 0, ref num2, 1);
        }

        [TestMethod]
        public void SameTree()
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            // tree.left.left = new TreeNode(4);
            // tree.left.right = new TreeNode(5);

            TreeNode tree2 = new TreeNode(1);
            tree2.left = new TreeNode(2);
            tree2.right = new TreeNode(3);
            //tree2.left.left = new TreeNode(4);
            // tree2.left.right = new TreeNode(5);

            SameTree SameTree = new SameTree();
            var answer = SameTree.IsSameTree(tree, tree2);
        }

        [TestMethod]
        public void IsSymmetric()
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(2);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(4);
            tree.right.left = new TreeNode(4);
            tree.right.right = new TreeNode(3);

            SymmetricalTree SymmetricalTree = new SymmetricalTree();
            //  var answer = SymmetricalTree.IsSymmetric(tree);

            var answer = SymmetricalTree.IsSymmetricIterative(tree);
        }

        [TestMethod]
        public void MaxDepth()
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(4);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            MaxDepthOfTree MaxDepthOfTree = new MaxDepthOfTree();
            //  var answer = SymmetricalTree.IsSymmetric(tree);

            var answer = MaxDepthOfTree.MaxDepth(tree);
        }

        [TestMethod]
        public void Normalizefile()
        {
            int counter = 0;
            string line;
            var idlist = new List<string>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\3TP\Source.txt");
            while ((line = file.ReadLine()) != null)
            {
                var ids = line.Split(',');
                foreach (var id in ids)
                {
                    idlist.Add("\'" + id.Trim() + "\',");
                }

                counter++;
            }

            file.Close();

            System.IO.File.WriteAllLines(@"D:\3TP\destination.txt", idlist);

        }


        [TestMethod]
        public void BinaryTreeOrderTraversal()
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(4);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            BinaryTreeOrderTraversal BinaryTreeOrderTraversal = new BinaryTreeOrderTraversal();
            //  var answer = SymmetricalTree.IsSymmetric(tree);

            var answer = BinaryTreeOrderTraversal.LevelOrderBottom(tree);
        }

        [TestMethod]
        public void IsBalanced()
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            IsBalancedClass IsBalancedTree = new IsBalancedClass();
            var answer = IsBalancedTree.IsBalanced(tree);

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void BinaryClassSum()
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            BinaryClassSum BinaryClassSum = new BinaryClassSum();
            var answer = BinaryClassSum.HasPathSum(tree,12);

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void PascalsTriangle()
        {

            PascalTriangle PascalTriangle = new PascalTriangle();
            var answer = PascalTriangle.Generate(5);

           // Assert.IsTrue(answer);
        }

        [TestMethod]
        public void PascalsTriangle2()
        {

            Pascaltriangle2 PascalTriangle = new Pascaltriangle2();
            var answer = PascalTriangle.GetRow(5);

            // Assert.IsTrue(answer);
        }

        [TestMethod]
        public void MaxStockProfit()
        {

            MaxStockProfit MaxStockProfit = new MaxStockProfit();

            var array = new int[] {7, 1, 5, 3, 6, 4};
            var answer = MaxStockProfit.MaxProfit2(array);

            // Assert.IsTrue(answer);
        }
    }

}
