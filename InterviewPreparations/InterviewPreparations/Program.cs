using InterviewPreparations.LeetCode;
using InterviewQuestions.LeetCode;
using InterviewQuestions.LinkedListClass;
using InterviewQuestions.Tree;
using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region QuickSort
            //int[] nums = { 10, 2, 5, 7, 18, 14 };
            //int startIndex = 0;
            //int endIndex = nums.Length - 1;
            //QuickSorting.QuickSort(nums, startIndex, endIndex);
            //UtilityHelper.PrintArray(nums);
            #endregion

            #region LeetCode Two Sum Program
            //int[] nums = { 2, 2, 4, 5, 5, 9, 14 };
            //TwoSum.CalculateTwoSumHashmap(nums, 542);
            #endregion

            #region LeetCode Add Two Numbers LL
            ////7->5->9->4->6
            //LinkedList list1 = new LinkedList();
            //list1.AddNode(7);
            //list1.AddNode(5);
            //list1.AddNode(9);
            //list1.AddNode(4);
            //list1.AddNode(6);

            ////8->4
            //LinkedList list2 = new LinkedList();
            //list2.AddNode(8);
            //list2.AddNode(4);

            //LinkedList resultedList = Add_Two_Numbers_Linked_List.AddTwoNumersLinkedList(list1.head, list2.head);

            //// Print the final list
            //resultedList.PrintLinkedListNodes();


            #endregion

            #region Length of the longest substring without repeating characters

            ////string str = "au";
            //string str = "ABDEFGBAEF";
            ////Console.WriteLine("Input String - " + str);
            //Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LongestSubstring(str));
            ////Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LogenstSubstringUniqueCharWithTemplate(str));
            ////Console.Read();

            #endregion

            #region Median of two sorted arrays of different sizes
            //int[] A = {1,2};
            //int[] B = { 3,4 };

            ////Console.WriteLine(MedianofTwoSortedArrays.FindMedianSortedArrays(A, B));
            //Console.WriteLine(MedianofTwoSortedArrays.FindMedianSortedArraysSameSize(A, B));
            //Console.Read();
            #endregion

            #region Longest Palindromic Sub String
            //string str = "babad";
            //Console.WriteLine(LongestPalindromicSubString.LongestPalindrome(str));
            //Console.Read();
            #endregion

            #region Zig Zag String Conversion
            //string str = "AB";
            //Console.WriteLine(ZigZagStringConversion.Convert(str, 2));
            //Console.Read();
            #endregion

            #region Reverse Integer
            //int x = 323;
            //Console.WriteLine(ReverseInteger.Reverse(x));
            //Console.Read();
            #endregion

            #region String to Integer (atoi)
            //string x = "+-1";
            //Console.WriteLine(StringToIntegerAtoi.MyAtoi(x));
            //Console.Read();
            #endregion

            #region Palindrome Number
            //int x2 = 323;
            //Console.WriteLine(PalindromeNumber.IsPalindrome(x2));
            //Console.Read();
            #endregion

            #region Container With Most Water
            //int[] arr = { 1, 1 };
            //Console.WriteLine(ContainerWithMostWater.MaxArea2(arr));
            //Console.Read();
            #endregion

            #region Longest Common Prefix String
            //string[] arrayOfStrings = {"geeksforgeeks", "geeks","geek", "geezer"};
            //var list = LongestCommonPrefix.LongestCommonPrefixString(arrayOfStrings);
            //Console.Read();
            #endregion

            #region 3 Sum 
            //int[] nums = { -1, 0, 1, 2, -1, -4 };
            //var result =_3Sum.ThreeSum(nums);
            ////_3Sum.ThreeSumWithSort(nums);
            //Console.Read();
            #endregion

            #region LeetCode Remove Nth Node From End of List
            ////7->5->9->4->6
            //LinkedList list1 = new LinkedList();
            //list1.AddNode(1);
            //list1.AddNode(2);

            ////list1.PrintLinkedListNodes();

            //LinkedList resultedList = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list1.head, 1);

            ////// Print the final list
            //resultedList.PrintLinkedListNodes();
            //Console.Read();

            #endregion

            #region Valid Parentheses
            //string str = "([)";
            //Console.WriteLine(ValidParentheses.IsValid(str));
            //Console.Read();
            #endregion

            #region Merge Two Sorted Lists 10/11/2017
            ////7->5->9->4->6
            //LinkedList list1 = new LinkedList();
            //list1.AddNode(1);
            //list1.AddNode(3);
            //list1.AddNode(4);

            //////8->4
            //LinkedList list2 = new LinkedList();
            //list2.AddNode(2);
            //list2.AddNode(7);

            //LinkedList resultedList = new LinkedList();
            //ListNode result = MergeTwoSortedLists.MergeTwoSortedLinkedLists(list1.head, list2.head);

            //resultedList.head = result;

            ////// Print the final list
            //resultedList.PrintLinkedListNodes();


            #endregion

            #region Remove Duplicates from Sorted Array
            //int[] nums = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            //Console.WriteLine(RemoveDuplicatesfromSortedArray.RemoveDuplicates(nums));
            //Console.Read();
            #endregion

            #region Remove Element
            //int[] nums = { 1, 2,4, 2, 3, 4, 4, 5, 4 };
            //int x = 4;
            //Console.WriteLine(RemoveElement.RemoveElementFromArray(nums, x));
            //Console.Read();
            #endregion

            #region Remove Linked List Elements

            //LinkedList list1 = new LinkedList();
            //list1.AddNode(1);
            //list1.AddNode(2);
            //list1.AddNode(6);
            //list1.AddNode(3);
            //list1.AddNode(4);
            //list1.AddNode(5);
            //list1.AddNode(6);

            //int x = 6;
            //Node result = RemoveLinkedListElements.RemoveNode(list1.head, x);
            //LinkedList resultedList = new LinkedList();

            //// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Implement strStr
            //string stayHack = "hello";
            //string needle = "ll";

            //Console.WriteLine(ImplementstrStr.strStr(stayHack, needle));
            //Console.Read();
            #endregion

            #region Binary Search 
            //int[] nums = { 3, 5, 7, 9, 10, 90, 100, 130, 140, 160, 170 };
            //int target = 140;
            //Console.WriteLine(BinarySearchClass.BinarySearch(nums, 0, nums.Length, target));
            //Console.Read();
            #endregion

            #region Search Insert Position
            //int[] nums = { 3, 5, 7, 9, 10, 90, 100, 130, 140, 160, 170 };
            //int target = 8;
            //Console.WriteLine(SearchInsertPositionArray.SearchInsert(nums, target));
            //Console.Read();
            #endregion

            #region Maximum Subarray
            //int[] nums = { 1, 2 };
            //Console.WriteLine(MaximumSubarray.MaxSubarray(nums));
            //Console.Read();
            #endregion

            #region Length of Last Word
            //string str = "G";
            //Console.WriteLine(LengthOfLastWord.LengthOfLastWordInString(str));
            //Console.Read();
            #endregion

            #region Plus One
            //int[] nums = { 9, 9, 9, 9 };
            //PlusOne.PlusOneToArray(nums);
            //UtilityHelper.PrintArray(nums);
            //Console.Read();
            #endregion

            #region Sqrt(x)
            //int x = 25;
            //Console.WriteLine(Sqrt_x_.Sqrt(x));
            //Console.Read();
            #endregion

            #region Climb Stairs
            //int x = 5;
            //Console.WriteLine(ClimbingStairs.ClimbStairs(x));
            //Console.Read();
            #endregion

            #region Remove Duplicates from Sorted List
            ////////7->5->9->4->6
            //LinkedList list1 = new LinkedList();
            //list1.AddNode(7);
            //list1.AddNode(5);
            //list1.AddNode(5);
            //list1.AddNode(4);
            //list1.AddNode(4);
            //list1.AddNode(10);
            //list1.AddNode(12);

            //LinkedList resultedList = new LinkedList();
            //Node result = RemoveDuplicatesfromSortedList.RemoveDuplicates(list1.head);

            //resultedList.head = result;

            //////// Print the final list
            //resultedList.PrintLinkedListNodes();

            #endregion

            #region Merge Sort Need to Debug
            //int[] nums = { 12, 11, 13, 5, 6, 7, 9 };
            //nums = MergeSortClass.MergeSort(nums, 0, nums.Length);
            //UtilityHelper.PrintArray(nums);
            //Console.Read();
            #endregion

            #region Merge Sorted Two Array
            //int[] nums1 = { 1, 2, 4, 5, 6, 0 };
            //int[] nums2 = { 3 };

            //nums1 = MergeSortTwoArray.MergeSort(nums1, 5, nums2, 1);
            ////UtilityHelper.PrintArray(nums1);
            //Console.Read();
            #endregion

            #region Convert Sorted Array to Binary Search Tree
            //int[] nums = { -99, -92, -73, -47, -2, 7, 12, 24, 25, 36, 75, 89 };
            //TreeNode result = ConvertSortedArraytoBinarySearchTree.ConvertArrayBST(nums);

            #endregion

            #region Path Sum
            //[1,-2,-3,1,3,-2,null,-1]
            //  Given the below binary tree and sum = 22,
            //              5
            //             / \
            //            4   8
            //           /   / \
            //          11  13  4
            //         /  \      \
            //        7    2      1

            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(8);

            //root.left.left = new TreeNode(11);
            //root.left.left.left = new TreeNode(7);
            //root.left.left.right = new TreeNode(2);

            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(4);
            //root.right.right.right = new TreeNode(1);

            //var result = PathSum.HasPathSumIterative(root, 22);
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion

            #region Pascals Triangle
            //var list = Pascal_TriangleII.GetPascalTraiangleRow(4);
            //Console.Read();
            #endregion

            #region Pascals Triangle II
            //var list = Pascal_TriangleII.GetPascalTraiangleRow(4);
            //Console.Read();
            #endregion

            #region Best Time to Buy and Sell Stock
            //int[] arr = { 100, 180, 260, 310, 40, 535, 695 };
            //Console.WriteLine(BestTimeToBuyAndSellStock.MaxProfit(arr));
            //Console.Read();
            #endregion

            #region Valid Palindrome
            //string str = "0P";
            //var IsResult = ValidPalindrome.CheckValidPalindromeString(str);
            //Console.WriteLine(IsResult);
            //Console.Read();
            #endregion

            #region Single Number
            //int[] nums = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };
            //int result = SingleNumber.FindSingleNumberInArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Two Sum II
            //int[] nums = { 2, 3, 4 };
            //UtilityHelper.PrintArray(TwoSumIIInputArraySorted.TwoSum(nums, 6));
            #endregion

            #region Excel Sheet Column Title
            //int n = 26;
            //Console.WriteLine(ExcelSheetColumnTitle.GetExcelColumnTitle(n));
            //Console.Read();
            #endregion

            #region Majority Element
            //int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            //int result = MajorityElement.GetMajorityElementArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Majority ElementII
            //int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            //int[] nums = { 1, 2 };
            //var result = MajorityElementII.GetMajorityElementArrayII(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Excel Sheet Column Number
            //string s = "AA";
            //int answer = ExcelSheetColumnNumber.TitleOfColumnNumber(s);
            //Console.WriteLine(answer);
            //Console.Read();
            #endregion

            #region Factorial Trailing Zeroes
            //int factorial = 10;
            //int result = FactorialTrailingZeroesClass.CountFactorialTrailingZero(factorial);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Rotate Array
            //int[] nums = { 1,2 };
            //int k = 3;
            //int[] result = RotateArray.ArrayRotationReverseLogic(nums, k);
            ////UtilityHelper.PrintArray(RotateArray.ArrayRotationReverseLogic(nums, k));
            ////Console.Read();
            #endregion

            #region Valid Phone Numbers In File
            //var result = ValidPhoneNumbersProgram.ValidPhoneNumbersInFile("file.txt");
            #endregion

            #region Happy Number
            //int n = 19;
            //bool result = HappyNumber.IsHappy(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Count Primes
            //int n = 25;
            //int result = CountPrimes.ConuntPrimeII(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Isomorphic Strings
            //string s1 = "aab";
            //string s2 = "xxy";
            //var IsResult = IsomorphicStrings.IsIsomorphic(s1,s2);
            //Console.WriteLine(IsResult);
            //Console.Read();
            #endregion

            #region Reverse Linked List Program

            //LinkedList list = new LinkedList();
            //list.AddNode(1);
            //list.AddNode(2);
            //list.AddNode(3);
            //list.AddNode(4);
            //list.AddNode(5);
            //list.AddNode(6);
            //list.AddNode(7);

            //ListNode result = ReverseLinkedListClass.ReverseList(list.head);
            //LinkedList resultedList = new LinkedList();

            ////// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Contains Duplicate
            //int[] nums = { 1, 0, 1, 1 };
            //bool result = ContainsDuplicateII.IsContainsDuplicateII(nums, 1);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Implement Stack using Queues
            //ImplementStackUsingQueues obj = new ImplementStackUsingQueues();
            //obj.Push(1);
            //obj.Push(2);
            //obj.Push(3);
            //int param_3 = obj.Top();
            //int param_4 = obj.Pop();
            #endregion

            #region Power of Two
            //Console.WriteLine(PoweOfTwoClass.IsPowerOfTwo(16));
            //Console.ReadKey();
            #endregion

            #region Implement Queue using Stacks
            //ImplementQueueUsingStacks obj = new ImplementQueueUsingStacks();
            //obj.Push(1);
            //int myValue = obj.Peek();
            #endregion

            #region Palindrome Linked List

            //LinkedList list1 = new LinkedList();
            //list1.AddNode(1);
            //list1.AddNode(2);
            //list1.AddNode(6);
            //list1.AddNode(5);
            //list1.AddNode(6);
            //list1.AddNode(2);
            //list1.AddNode(4);

            //Console.WriteLine(PalindromeLinkedListClass.IsPalindrome(list1.head));
            //Console.Read();
            #endregion

            #region Add Digits
            //int n = 11181983;
            //int result = AddDigits.AddDigit(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Ugly Number
            //int n = 18;
            //bool result = UglyNumber.IsUglyNumber(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Ugly Number II
            //int n = 10;
            //var result = UglyNumberII.FindNthPrimeFactor(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Word Pattern
            //string words = "cat cat cat dog";
            //string pattern = "abab";
            //Console.WriteLine(WordPattern.IsMatchingPattern(words, pattern));
            //Console.Read();
            #endregion

            #region Integer to English Words
            //Console.WriteLine(IntegerToEnglishWords.ConvertIntegerToEnglishWords(123));
            //Console.ReadKey();
            #endregion

            #region Product of Array Except Self
            //int[] nums = { 1, 2, 3, 4 };
            //nums = ProductOfArrayExceptSelf.ProductArray(nums);
            //Console.WriteLine(nums);
            //Console.Read();
            #endregion

            #region Pow(x, n)
            //double x = 34.00515;
            //int n = -3;
            //double result = PowOfXToN.PowerofX(x, n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region IComparer Example on objects
            //MergeAndSortIComparer.MergeandSortIComparer();
            //Console.Read();
            #endregion

            #region Arrange Array - I. Positive Number at end II. Negative numbers at end.
            //int[] nums = { 7, 4, -5, -7, 8, -5, 15, -2, -10, 14 };
            //int[] result = ArrayArrangment.PositiveElementsAtEndsInArray(nums);
            //int[] resultII = ArrayArrangment.NegativeElementsAtEndsInArray(nums);
            ////UtilityHelper.PrintArray(result);
            //Console.WriteLine();
            //UtilityHelper.PrintArray(resultII);
            //Console.Read();
            #endregion

            #region Swap Nodes in Pairs

            //LinkedList list = new LinkedList();
            //list.AddNode(1);
            //list.AddNode(2);
            //list.AddNode(3);
            //list.AddNode(4);
            //list.AddNode(5);
            //list.AddNode(6);
            //ListNode result = SwapNodesInPairs.SwapNodesPairWise(list.head);
            //LinkedList resultedList = new LinkedList();
            ////// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Search in Rotated Sorted Array
            //int[] nums = { 3,1 };
            //int target = 1;
            //int result = SearchInRotatedSortedArray.IsRotatedSortedArraySearch(nums, target);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Combination Sum
            //int[] nums = { 2, 4, 6, 8 };
            //int target = 8;
            //var result = CombinationSum.GetCombinationSumArray(nums, target);
            ////var result1 = CombinationSum.CombinationSumOfArray(nums, target);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Subsets
            //int[] nums = { 2, 4, 6, 8 };
            //var result = Subsets.GetSubsets(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Permutations
            //int[] nums = { 1, 2, 3 };
            //var result = Permutations.ListPermutations(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Permutations II
            //int[] nums = { 1, 1, 0};
            //var result = PermutationsIIWithDuplicates.GetPermutationsWithDuplicates(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Palindrome Partitioning
            //string s = "aab";
            //var result = PalindromePartitioning.GetListPalindromePartitioning(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Find All Anagram String
            //string s = "cbaebabacd";
            //string p = "abc";
            //var result = FindAllAnagramsString.FindAllAnagramString(s, p);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Minimum Window Substring
            //string s = "a";
            //string t = "a";
            //var result = MinimumWindowSubstringClass.MinimumWindowSubString(s, t);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Reverse Vowels of a String
            //string s = "hello";
            //s = ReverseVowelsOfString.ReverseVowel(s);
            //Console.WriteLine(s);
            //Console.Read();

            #endregion

            #region Interleaving String
            //string s1 = "aabc";
            //string s2 = "abad";
            //string s3 = "aabcabad";
            //bool result = InterleavingString.IsInterleaving(s1, s2, s3);
            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region Longest Valid Parentheses
            //string s1 = ")()())";
            //int result = LongestValidParenthesesClass.LongestValidParenthesisLength(s1);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Contains Most Water in Two Piller left and right
            //int[] nums = { 3, 0, 0, 2, 0, 4 };
            //int result = ContainerWithMostWater.MaxWater(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Trapping Total Rain Water 
            //int[] nums = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            //int result = TrappingRainWaterClass.TrappingWater(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Group Anagrams
            //string[] s = { "tea", "ate", "abc", "bca", "xxy" };
            //var result = GroupAnagrams.GroupValidAnagramsStrings(s);
            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region Best Time to Buy and Sell Stock 
            //int[] nums = { 7, 1, 5, 3, 6, 4 };
            //int result = BestTimeToBuyAndSellStockII.MaxProfits(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Rotate List

            //LinkedList list1 = new LinkedList();
            //list1.AddNode(1);
            //list1.AddNode(2);
            ////list1.AddNode(3);
            ////list1.AddNode(4);
            ////list1.AddNode(5);

            //int x = 0;
            //ListNode result = RotateList.RotateRight(list1.head, x);
            //LinkedList resultedList = new LinkedList();

            //// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Count and Say
            //int n = 4;
            //string result = CountAndSayClass.CountAndSayNumber(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Range Sum Query - Immutable
            //int[] nums = { 4, 2, -1, 0, -5, 5, 7, 2 };
            //RangeSumQueryImmutable objRangeSum = new RangeSumQueryImmutable(nums);

            //Console.WriteLine(objRangeSum.RangeSum(0, 1));
            //Console.WriteLine(objRangeSum.RangeSum(1, 5));
            //Console.WriteLine(objRangeSum.RangeSum(1, 7));
            //Console.WriteLine(objRangeSum.RangeSum(3, 6));

            //Console.Read();
            #endregion

            #region First Missing Positive
            //int[] nums = { 3, 4, 5, 1, -1 };
            //int result = FirstMissingPositiveClass.FindFirstMissingPositive(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Rotate Image
            //int[,] nums = new int[4, 4]
            //{
            //    { 5, 1, 9, 11 },
            //    {  2, 4, 8,10 },
            //    {13, 3, 6, 7 },
            //    { 15,14,12,16 }
            //};

            ////int[,] nums = new int[3, 3]
            ////{
            ////    { 1,2,3},
            ////    {  4,5,6 },
            ////    {7,8,9}
            ////};

            //RotateImage.Rotate(nums);
            //Console.WriteLine(/*result*/);
            //Console.Read();
            #endregion

            #region Intersection of Two Linked List
            //////7->5->9->4->6
            //LinkedList list1 = new LinkedList();
            //list1.AddNode(3);
            //list1.AddNode(6);
            //list1.AddNode(9);
            //list1.AddNode(15);
            //list1.AddNode(30);

            ////////8->4
            //LinkedList list2 = new LinkedList();
            //list2.AddNode(10);
            //list2.AddNode(15);
            //list2.AddNode(30);

            //LinkedList resultedList = new LinkedList();
            //ListNode result = IntersectionOfTwoLinkedLists.GetIntersectionTwoList(list1.head, list2.head);

            //resultedList.head = result;

            ////// Print the final list
            //resultedList.PrintLinkedListNodes();


            #endregion

            #region Integer to Roman
            //int num = 1;
            //string result = IntegerToRomanClass.IntegerToRomanNumber(num);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Roman to Integer
            //string s = "IV";
            //int result = RomanToIntegerClass.RomanToInteger(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Merge Intervals

            //{ 6,8}, { 1,9}, { 2,4}, { 4,7}

            //List<Interval> listInterval = new List<Interval>();

            //Interval interval = new Interval();
            //interval.start = 1;
            //interval.end = 3;

            //Interval interval1 = new Interval();
            //interval1.start = 2;
            //interval1.end = 6;

            //Interval interval2 = new Interval();
            //interval2.start = 8;
            //interval2.end = 10;

            //Interval interval3 = new Interval();
            //interval3.start = 15;
            //interval3.end = 18;

            //listInterval.Add(interval);
            //listInterval.Add(interval1);
            //listInterval.Add(interval2);
            //listInterval.Add(interval3);

            //MergeIntervals objMergeInterval = new MergeIntervals();
            //var result = objMergeInterval.MergeInterval(listInterval);

            //Console.Read();
            #endregion

            #region Reverse String II
            //string s = "abcdefg";
            //int k = 2;
            //var result = ReverseStringII.ReverseStringKChar(s, k);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Reverse Words in a String
            //string s = "the sky is blue";
            //var result = ReverseWordsInStringI.ReverseWords(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Reverse Linked List Program

            //LinkedList list = new LinkedList();
            //list.AddNode(1);
            //list.AddNode(2);
            //list.AddNode(3);
            //list.AddNode(4);
            //list.AddNode(5);
            //list.AddNode(6);
            //list.AddNode(7);

            //ListNode result = ReverseLinkedListII.ReverseList(list.head, 2, 4);
            //LinkedList resultedList = new LinkedList();

            ////// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Maximum Sub Array with Window Size K
            //int[] nums = { 1, 2147483646 };
            //int k = 1;
            //int result = MaximumSubarrayWithWindowK.MaximumSubarrayWithSlidingWindow(nums, k);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Sliding Window Maximum
            //int[] nums = { 1, -1 };
            //int k = 1;
            //var result = SlidingWindowMaximumArray.SlidingWindowMaxiuminArray(nums, k);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Maximum Product Subarray
            //int[] nums = { 6, -3, -10, 0, 2 };
            //var result = MaximumProductSubarrayClass.MaxProductSubArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Minimum Size Subarray Sum
            //int[] nums = { 1, 4, 45, 6, 0, 19 };
            //int targetSum = 51;
            //var result = MinimumSizeSubarraySum.MinSizeSubarraySum(nums, targetSum);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Minimum Size Subarray Sum
            //int[] nums = { 1, -1, 5, -2, 3 };
            //int targetSum = 3;
            //var result = MaximumSizeSubarraySum.MaxSizeSubarraySum(nums, targetSum);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Continuous Subarray Sum
            //int[] nums = { 23, 2, 4, 6, 7 };
            //int targetsum = 4;
            //var result = ContinuousSubArraySum.ContinuousSubArraySumWithK(nums, targetsum);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region LRU Cache
            //LRUCache objLRUCache = new LRUCache(2);
            //objLRUCache.Put(1, 1);
            //objLRUCache.Put(2, 2);
            //int cacheItem = objLRUCache.Get(1);
            //objLRUCache.Put(3, 3);
            //cacheItem = objLRUCache.Get(2);
            //objLRUCache.Put(3, 3);
            //cacheItem = objLRUCache.Get(1);
            //cacheItem = objLRUCache.Get(3);
            //cacheItem = objLRUCache.Get(4);
            #endregion

            #region Same Tree
            //TreeNode left = new TreeNode(1);
            //left.left = new TreeNode(2);
            //left.right = new TreeNode(3);

            //TreeNode right = new TreeNode(1);
            //right.left = new TreeNode(2);
            //right.right = new TreeNode(3);

            //Console.WriteLine(SameTree.IsIdenticalBinaryTreeIterative(left,right));
            //Console.ReadKey();
            #endregion

            #region Symmetric Tree
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(4);
            //root.right.right = new TreeNode(3);
            //Console.WriteLine(SymmetricTree.IsSymmetricBinaryTree(root));
            //Console.ReadKey();
            #endregion

            #region Sum Of Left Leaves
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(4);
            //root.right.right = new TreeNode(3);

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.left.left.left = new TreeNode(2);

            //root.right = new TreeNode(3);
            //root.right.right = new TreeNode(8);

            //root.right.right.left = new TreeNode(6);
            //root.right.right.right = new TreeNode(7);
            //Console.WriteLine(SumOfLeftLeaves.LeftLeavesTotalSumIterative(root));
            //Console.ReadKey();
            #endregion

            #region Partition List

            //LinkedList list = new LinkedList(2);
            //list.AddNode(2);
            //list.AddNode(4);
            //list.AddNode(5);
            //list.AddNode(1);
            //list.AddNode(2);
            //list.AddNode(3);
            //list.AddNode(6);

            //ListNode result1 = PartitionList.Partition(list.head, 4);
            //LinkedList resultedList = new LinkedList();

            ////// Print the final list
            //resultedList.head = result;
            //resultedList.PrintLinkedListNodes();
            #endregion

            #region Find Minimum in Rotated Sorted Array
            //int[] nums = { 7, 0, 1, 2 };
            //int result = FindMinimumRotatedSortedArray.FindMinRotatedArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Repeated String Match
            //string A = "abcd";
            //string B = "cdabcdab";
            //var result = RepeatedStringMatchClass.CountOfRepeatedString(A, B);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region LeetCode Add Two Numbers LL
            //    //7->5->9->4->6
            ////[7,2,4,3]
            ////[5,6,4]

            //    //3,4,2,7
            //    //4,6,5


            //ListNode head1 = new ListNode(7);
            //head1.next = new ListNode(2);
            //head1.next.next = new ListNode(4);
            //head1.next.next.next = new ListNode(3);

            ////8->4
            //ListNode head2 = new ListNode(5);
            //head2.next = new ListNode(6);
            //head2.next.next = new ListNode(4);

            //ListNode temp = AddTwoNumbersClassII.AddTwoNumbersII(head1, head2);

            //    // Print the final list
            //    //resultedList.PrintLinkedListNodes();


            #endregion

            #region Odd Even Linked List
            //ListNode head1 = new ListNode(1);
            //head1.next = new ListNode(2);
            //head1.next.next = new ListNode(3);
            //head1.next.next.next = new ListNode(4);
            //head1.next.next.next.next = new ListNode(5);
            //ListNode temp = OddEvenLinkedList.MakeOddEvenLinkedList(head1);
            #endregion

            #region Valid Palindrome II
            //string s = "bcd";
            //bool result = ValidPalindromeII.ValidPalindrome(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Validate IP Address
            //string s = "256.256.256.256";
            //string result = ValidateIPAddress.ValidIPAddress(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Repeated Substring Pattern
            //string s = "ababab";
            //bool result = RepeatedSubstringPatternClass.IsRepeatedStringPattern(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Valid Number
            //string s = "..2";
            //bool result = ValidNumber.IsNumber(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Jump Game
            //int[] nums = { 3, 2, 1, 0, 4 };
            //bool result = JumpGame.canJump(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region  Jump Game II
            //int[] nums = { 2, 3, 1, 1, 4 };
            //int result = JumpGameII.GetMinStepsJump(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Maximum Product of Three Numbers
            //int[] nums = { -4, -3, -2, -1, 60 };
            //int result = MaximumProductThreeNumbers.MaxProductThreeNum(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Set Matrix Zeroes
            //int[,] nums = new int[3, 4]
            //{
            //    {0,0,0,5},
            //    {4,3,1,4},
            //    {0,1,1,4},
            //    //{1,2,1,3},
            //    //{0,0,1,1}
            //};

            ////int[,] nums = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 0, 5, 2 }, { 8, 9, 2, 0 }, { 5, 7, 2, 1 } };



            ////////int[,] nums = new int[3, 3]
            ////////{
            ////////    { 1,2,3},
            ////////    {  4,5,6 },
            ////////    {7,8,9}
            ////////};

            //SetMatrixZeroesClass.SetMatrix(nums);
            //Console.WriteLine(/*result*/);
            //Console.Read();
            #endregion

            #region Spiral Matrix
            //int[,] nums = new int[3, 3]
            //{
            //    { 1,2,3},
            //    { 4,5,6},
            //    { 7,8,9}
            //};

            //SpiralMatrixcs.SpiralMatrix(nums);
            //Console.WriteLine(/*result*/);
            //Console.Read();
            #endregion

            #region Max Consecutive Ones
            //int[] nums = { 1, 0, 1, 1, 4 };
            //int result = MaxConsecutiveOnes.MaxCountConsecutiveOnes(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region String Compression
            //char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //int result = StringCompression.Compression(chars);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Remove Comments
            ////string[] source = { "a/*comment", "line", "more_comment*/b" };
            //string[] source = { "/*Test program */", "int main()", "{ ", "  // variable declaration ", "int a, b, c;", "/* This is a test", "   multiline  ", "   comment for ", "   testing */", "a = b + c;", "}" };

            //var result = RemoveComments.RemoveComment(source);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region First Unique Character in a String
            //string s = "loveleeto";
            //int result = FirstUniqueCharacterInString.FirstUniqueCharString(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region ReverseDoublyLinkedList
            //ReverseDoublyLinkedList.AddNodeDLL(1);
            //ReverseDoublyLinkedList.AddNodeDLL(2);
            //ReverseDoublyLinkedList.AddNodeDLL(3);
            //ReverseDoublyLinkedList.AddNodeDLL(4);
            //ReverseDoublyLinkedList.AddNodeDLL(5);

            //ReverseDoublyLinkedList.Print(ReverseDoublyLinkedList.head);

            //DoublyNode node = ReverseDoublyLinkedList.ReverseDLL(ReverseDoublyLinkedList.head);

            //ReverseDoublyLinkedList.Print(node);

            //Console.ReadKey();
            #endregion

            #region Move Zero Remove Duplicate
            //int[] nums = { 0, 1, 1, 0, 3, 3, 0, 3, 4, 5, 0, 5, 5, 12 };
            //var result = MoveZeroRemoveDuplicates.MoveZero(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Non-decreasing Array
            //int[] nums = { 5, 6, 4, 2, 7 };
            //var result = NonDecreasingArrayClass.NonDecreasing(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Max Area of Island
            ////int[,] nums = new int[8, 13]
            ////{{0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            //// {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            //// {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
            //// {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}};

            //int[,] nums = new int[4, 5]
            //{
            //    { 1, 1, 0, 0, 0 }, 
            //    { 1, 1, 0, 0, 0 }, 
            //    { 0, 0, 0, 1, 1 }, 
            //    { 0, 0, 0, 1, 1 }
            //};

            //int result = MaxAreaOfIsland.MaxAreaConnectedIsland(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Next Greater Element
            //int[] nums = { 4, 5, 2, 25 };
            //NextGreaterElementI.NextGreater(nums);
            #endregion

            #region Find the Duplicate Number
            //int[] nums = { 1, 0, 7, 1, 4 };
            //int result = FindTheDuplicateNumber.FindDuplicate(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Number of Segments in a String
            //string s1 = "Hello, I work for Microsoft as FT";
            //int result11 = NumberOfSegmentsString.CountSegmentInString(s1);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Valid Parenthesis String
            //string s = "*()(())*()(()()((()(()()*)(*(())((((((((()*)(()(*)";
            //bool result = ValidParenthesisStringClass.ValidParaenthesis(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Sort Colors
            //int[] nums = { 1, 1, 1, 1, 1 };
            //SortColors012.Sort012(nums);
            ////Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Shortest Word Distance In Words
            //string[] nums = { "hello", "hi", "cat", "dog", "Seattle" };
            //var result = ShortestWordDistanceClass.ShortedWordDistanceStrings(nums, "hello", "dog");
            ////Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Find Pivot Index
            //int[] nums = { 1, 7, 3, 6, 5, 6 };
            //int result = FindPivotIndexClass.FindPivot(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Find the Difference
            //string s = "ymbgaraibkfmvocpizdydugvalagaivdbfsfbepeyccqfepzvtpyxtbadkhmwmoswrcxnargtlswqemafandgkmydtimuzvjwxvlfwlhvkrgcsithaqlcvrihrwqkpjdhgfgreqoxzfvhjzojhghfwbvpfzectwwhexthbsndovxejsntmjihchaotbgcysfdaojkjldprwyrnischrgmtvjcorypvopfmegizfkvudubnejzfqffvgdoxohuinkyygbdzmshvyqyhsozwvlhevfepdvafgkqpkmcsikfyxczcovrmwqxxbnhfzcjjcpgzjjfateajnnvlbwhyppdleahgaypxidkpwmfqwqyofwdqgxhjaxvyrzupfwesmxbjszolgwqvfiozofncbohduqgiswuiyddmwlwubetyaummenkdfptjczxemryuotrrymrfdxtrebpbjtpnuhsbnovhectpjhfhahbqrfbyxggobsweefcwxpqsspyssrmdhuelkkvyjxswjwofngpwfxvknkjviiavorwyfzlnktmfwxkvwkrwdcxjfzikdyswsuxegmhtnxjraqrdchaauazfhtklxsksbhwgjphgbasfnlwqwukprgvihntsyymdrfovaszjywuqygpvjtvlsvvqbvzsmgweiayhlubnbsitvfxawhfmfiatxvqrcwjshvovxknnxnyyfexqycrlyksderlqarqhkxyaqwlwoqcribumrqjtelhwdvaiysgjlvksrfvjlcaiwrirtkkxbwgicyhvakxgdjwnwmubkiazdjkfmotglclqndqjxethoutvjchjbkoasnnfbgrnycucfpeovruguzumgmgddqwjgdvaujhyqsqtoexmnfuluaqbxoofvotvfoiexbnprrxptchmlctzgqtkivsilwgwgvpidpvasurraqfkcmxhdapjrlrnkbklwkrvoaziznlpor";
            //string s1 = "qhxepbshlrhoecdaodgpousbzfcqjxulatciapuftffahhlmxbufgjuxstfjvljybfxnenlacmjqoymvamphpxnolwijwcecgwbcjhgdybfffwoygikvoecdggplfohemfypxfsvdrseyhmvkoovxhdvoavsqqbrsqrkqhbtmgwaurgisloqjixfwfvwtszcxwktkwesaxsmhsvlitegrlzkvfqoiiwxbzskzoewbkxtphapavbyvhzvgrrfriddnsrftfowhdanvhjvurhljmpxvpddxmzfgwwpkjrfgqptrmumoemhfpojnxzwlrxkcafvbhlwrapubhveattfifsmiounhqusvhywnxhwrgamgnesxmzliyzisqrwvkiyderyotxhwspqrrkeczjysfujvovsfcfouykcqyjoobfdgnlswfzjmyucaxuaslzwfnetekymrwbvponiaojdqnbmboldvvitamntwnyaeppjaohwkrisrlrgwcjqqgxeqerjrbapfzurcwxhcwzugcgnirkkrxdthtbmdqgvqxilllrsbwjhwqszrjtzyetwubdrlyakzxcveufvhqugyawvkivwonvmrgnchkzdysngqdibhkyboyftxcvvjoggecjsajbuqkjjxfvynrjsnvtfvgpgveycxidhhfauvjovmnbqgoxsafknluyimkczykwdgvqwlvvgdmufxdypwnajkncoynqticfetcdafvtqszuwfmrdggifokwmkgzuxnhncmnsstffqpqbplypapctctfhqpihavligbrutxmmygiyaklqtakdidvnvrjfteazeqmbgklrgrorudayokxptswwkcircwuhcavhdparjfkjypkyxhbgwxbkvpvrtzjaetahmxevmkhdfyidhrdeejapfbafwmdqjqszwnwzgclitdhlnkaiyldwkwwzvhyorgbysyjbxsspnjdewjxbhpsvj";
            //int result = FindPivotIndexClass.FindPivot(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Simplify Path
            //string s = "/abc/...";
            //var result = SimplifyPath.SimplyfyPathII(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Decode Ways
            //string s = "1234";
            //var result = DecodeWays.NoOfDecodeWays(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Validate Binary Search Tree
            //[3,1,5,0,2,4,6]
            //TreeNode root = new TreeNode(10);
            //root.left = new TreeNode(-10);
            //root.right = new TreeNode(19);

            //root.left.left = new TreeNode(-20);
            //root.left.right = new TreeNode(0);

            //root.right.left = new TreeNode(17);
            ////root.right.left.left = new TreeNode(6);

            //Console.WriteLine(ValidateBinarySearchTree.ValidBST(root));
            //Console.ReadKey();
            #endregion

            #region Delete Node Binary Search Tree
            //[3,1,5,0,2,4,6]
            //TreeNode root = new TreeNode(50);
            //root.left = new TreeNode(30);
            //root.right = new TreeNode(70);

            //root.left.left = new TreeNode(20);
            //root.left.right = new TreeNode(40);

            //root.right.left = new TreeNode(60);
            //root.right.left.left = new TreeNode(80);

            //Console.WriteLine(DeleteNodeBinarySearchTree.DeleteNodeBST(root, 20));
            //Console.ReadKey();
            #endregion

            #region Binary Tree Level Order Traversal
            ////[3,9,20,null,null,15,7]
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);

            //root.left.left = new TreeNode(15);
            //root.left.right = new TreeNode(7);

            ////root.right.left = new TreeNode(4);
            ////root.right.left.left = new TreeNode(6);

            //Console.WriteLine(BinaryTreeLevelOrderTraversalII.LevelOrderBottomUp(root));
            //Console.ReadKey();
            #endregion

            #region Flatten Binary Tree to Linked List
            ////[1,2,3,4,5,6,7]
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(5);

            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);

            //root.right.right = new TreeNode(6);

            //FlattenBinarySearchTree.FlattenTree(root);
            //Console.ReadKey();
            #endregion

            #region Minimum Path Sum Matrix
            //int[,] nums = new int[3, 3]
            //{
            //    { 1,3,1 },
            //    { 1,5,1 },
            //    { 4,2,1 }
            //};

            //Console.WriteLine(MinimumPathSumMatrix.MinPathSumMatrix(nums));
            //Console.Read();
            #endregion

            #region Calculate Area of Overlap Rectangle
            //Console.WriteLine(RectangleArea.CalculateArea(2, 1, 5, 5, 3, 2, 5, 7));
            //Console.Read();
            #endregion

            #region LCA of Two Nodes in the tree
            ////[1,-2,-3,1,3,-2,null,-1]

            //TreeNode root = new TreeNode(6);
            //root.left = new TreeNode(-2);
            //root.right = new TreeNode(-3);

            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);

            //root.right.left = new TreeNode(-2);
            //root.right.left.left = new TreeNode(-1);

            //Console.WriteLine(PathSum.PathSumBinaryTree(root, 2));
            //Console.ReadKey();
            #endregion

            #region Next Greater Element in Array
            //int[] nums = { 1, 2, 1 };
            //NextGreaterElement.NextGreaterII(nums);
            #endregion

            #region Maximum Average Subarray I
            //int[] nums = { 0, 1, 1, 3, 3 };
            //var result = MaximumAverageSubArrayClass.MaxAverageSubArray(nums, 4);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Subarray Sum Equals K 
            //int[] nums = { 1, 4, 5, 2, 9 };
            //var result = SubArraySumEqualK.TotalSubArraySumEqualsKhashMap(nums, 9);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Subarray Product Less Than K
            //int[] nums = { 10, 5, 2, 6 };
            //var result = SubArrayProductLessThanKClass.numOfSubArrayProduct(nums, 100);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Contiguous Array
            //int[] nums = { 0, 1, 0, 1 };
            //var result = ContigousSubArrayClass.ContiguousArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Add Binary
            //string s1 = "0";
            //string s2 = "0";
            //var result = AddBinary.SumBinary(s1, s2);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Valid Perfect Square
            //int num = 808201;
            //var result = ValidPerfectSquareClass.IsValidPerfectSquare(num);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Multiply Strings
            //string s1 = "124";
            //string s2 = "25";
            //var result = MultiplyStrings.Multiply(s1, s2);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region LeftView
            //[3,9,20,null,null,15,7]

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);

            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);

            //root.left.right.left = new TreeNode(8);
            //root.left.right.right = new TreeNode(9);

            //root.right.left = new TreeNode(6);
            //root.right.right = new TreeNode(7);
            //root.right.right.left = new TreeNode(10);
            //root.right.right.left.left = new TreeNode(11);

            //var result =BinaryTreeLeftSideView.BinaryTreeLeftView(root);

            //foreach (var item in result)
            //{
            //    Console.Write(item + "->");
            //}

            //Console.ReadKey();
            #endregion

            #region Word Ladder
            //string s1 = "wawaglknagagwunagkwkwagl";
            //int k = 4;

            ////string[] listWords = { "slit", "bunk", "wars", "ping", "viva", "wynn", "wows", "irks", "gang", "pool", "mock", "fort", "heel", "send", "ship", "cols", "alec", "foal", "nabs", "gaze", "giza", "mays", "dogs", "karo", "cums", "jedi", "webb", "lend", "mire", "jose", "catt", "grow", "toss", "magi", "leis", "bead", "kara", "hoof", "than", "ires", "baas", "vein", "kari", "riga", "oars", "gags", "thug", "yawn", "wive", "view", "germ", "flab", "july", "tuck", "rory", "bean", "feed", "rhee", "jeez", "gobs", "lath", "desk", "yoko", "cute", "zeus", "thus", "dims", "link", "dirt", "mara", "disc", "limy", "lewd", "maud", "duly", "elsa", "hart", "rays", "rues", "camp", "lack", "okra", "tome", "math", "plug", "monk", "orly", "friz", "hogs", "yoda", "poop", "tick", "plod", "cloy", "pees", "imps", "lead", "pope", "mall", "frey", "been", "plea", "poll", "male", "teak", "soho", "glob", "bell", "mary", "hail", "scan", "yips", "like", "mull", "kory", "odor", "byte", "kaye", "word", "honk", "asks", "slid", "hopi", "toke", "gore", "flew", "tins", "mown", "oise", "hall", "vega", "sing", "fool", "boat", "bobs", "lain", "soft", "hard", "rots", "sees", "apex", "chan", "told", "woos", "unit", "scow", "gilt", "beef", "jars", "tyre", "imus", "neon", "soap", "dabs", "rein", "ovid", "hose", "husk", "loll", "asia", "cope", "tail", "hazy", "clad", "lash", "sags", "moll", "eddy", "fuel", "lift", "flog", "land", "sigh", "saks", "sail", "hook", "visa", "tier", "maws", "roeg", "gila", "eyes", "noah", "hypo", "tore", "eggs", "rove", "chap", "room", "wait", "lurk", "race", "host", "dada", "lola", "gabs", "sobs", "joel", "keck", "axed", "mead", "gust", "laid", "ends", "oort", "nose", "peer", "kept", "abet", "iran", "mick", "dead", "hags", "tens", "gown", "sick", "odis", "miro", "bill", "fawn", "sumo", "kilt", "huge", "ores", "oran", "flag", "tost", "seth", "sift", "poet", "reds", "pips", "cape", "togo", "wale", "limn", "toll", "ploy", "inns", "snag", "hoes", "jerk", "flux", "fido", "zane", "arab", "gamy", "raze", "lank", "hurt", "rail", "hind", "hoot", "dogy", "away", "pest", "hoed", "pose", "lose", "pole", "alva", "dino", "kind", "clan", "dips", "soup", "veto", "edna", "damp", "gush", "amen", "wits", "pubs", "fuzz", "cash", "pine", "trod", "gunk", "nude", "lost", "rite", "cory", "walt", "mica", "cart", "avow", "wind", "book", "leon", "life", "bang", "draw", "leek", "skis", "dram", "ripe", "mine", "urea", "tiff", "over", "gale", "weir", "defy", "norm", "tull", "whiz", "gill", "ward", "crag", "when", "mill", "firs", "sans", "flue", "reid", "ekes", "jain", "mutt", "hems", "laps", "piss", "pall", "rowe", "prey", "cull", "knew", "size", "wets", "hurl", "wont", "suva", "girt", "prys", "prow", "warn", "naps", "gong", "thru", "livy", "boar", "sade", "amok", "vice", "slat", "emir", "jade", "karl", "loyd", "cerf", "bess", "loss", "rums", "lats", "bode", "subs", "muss", "maim", "kits", "thin", "york", "punt", "gays", "alpo", "aids", "drag", "eras", "mats", "pyre", "clot", "step", "oath", "lout", "wary", "carp", "hums", "tang", "pout", "whip", "fled", "omar", "such", "kano", "jake", "stan", "loop", "fuss", "mini", "byrd", "exit", "fizz", "lire", "emil", "prop", "noes", "awed", "gift", "soli", "sale", "gage", "orin", "slur", "limp", "saar", "arks", "mast", "gnat", "port", "into", "geed", "pave", "awls", "cent", "cunt", "full", "dint", "hank", "mate", "coin", "tars", "scud", "veer", "coax", "bops", "uris", "loom", "shod", "crib", "lids", "drys", "fish", "edit", "dick", "erna", "else", "hahs", "alga", "moho", "wire", "fora", "tums", "ruth", "bets", "duns", "mold", "mush", "swop", "ruby", "bolt", "nave", "kite", "ahem", "brad", "tern", "nips", "whew", "bait", "ooze", "gino", "yuck", "drum", "shoe", "lobe", "dusk", "cult", "paws", "anew", "dado", "nook", "half", "lams", "rich", "cato", "java", "kemp", "vain", "fees", "sham", "auks", "gish", "fire", "elam", "salt", "sour", "loth", "whit", "yogi", "shes", "scam", "yous", "lucy", "inez", "geld", "whig", "thee", "kelp", "loaf", "harm", "tomb", "ever", "airs", "page", "laud", "stun", "paid", "goop", "cobs", "judy", "grab", "doha", "crew", "item", "fogs", "tong", "blip", "vest", "bran", "wend", "bawl", "feel", "jets", "mixt", "tell", "dire", "devi", "milo", "deng", "yews", "weak", "mark", "doug", "fare", "rigs", "poke", "hies", "sian", "suez", "quip", "kens", "lass", "zips", "elva", "brat", "cosy", "teri", "hull", "spun", "russ", "pupa", "weed", "pulp", "main", "grim", "hone", "cord", "barf", "olav", "gaps", "rote", "wilt", "lars", "roll", "balm", "jana", "give", "eire", "faun", "suck", "kegs", "nita", "weer", "tush", "spry", "loge", "nays", "heir", "dope", "roar", "peep", "nags", "ates", "bane", "seas", "sign", "fred", "they", "lien", "kiev", "fops", "said", "lawn", "lind", "miff", "mass", "trig", "sins", "furl", "ruin", "sent", "cray", "maya", "clog", "puns", "silk", "axis", "grog", "jots", "dyer", "mope", "rand", "vend", "keen", "chou", "dose", "rain", "eats", "sped", "maui", "evan", "time", "todd", "skit", "lief", "sops", "outs", "moot", "faze", "biro", "gook", "fill", "oval", "skew", "veil", "born", "slob", "hyde", "twin", "eloy", "beat", "ergs", "sure", "kobe", "eggo", "hens", "jive", "flax", "mons", "dunk", "yest", "begs", "dial", "lodz", "burp", "pile", "much", "dock", "rene", "sago", "racy", "have", "yalu", "glow", "move", "peps", "hods", "kins", "salk", "hand", "cons", "dare", "myra", "sega", "type", "mari", "pelt", "hula", "gulf", "jugs", "flay", "fest", "spat", "toms", "zeno", "taps", "deny", "swag", "afro", "baud", "jabs", "smut", "egos", "lara", "toes", "song", "fray", "luis", "brut", "olen", "mere", "ruff", "slum", "glad", "buds", "silt", "rued", "gelt", "hive", "teem", "ides", "sink", "ands", "wisp", "omen", "lyre", "yuks", "curb", "loam", "darn", "liar", "pugs", "pane", "carl", "sang", "scar", "zeds", "claw", "berg", "hits", "mile", "lite", "khan", "erik", "slug", "loon", "dena", "ruse", "talk", "tusk", "gaol", "tads", "beds", "sock", "howe", "gave", "snob", "ahab", "part", "meir", "jell", "stir", "tels", "spit", "hash", "omit", "jinx", "lyra", "puck", "laue", "beep", "eros", "owed", "cede", "brew", "slue", "mitt", "jest", "lynx", "wads", "gena", "dank", "volt", "gray", "pony", "veld", "bask", "fens", "argo", "work", "taxi", "afar", "boon", "lube", "pass", "lazy", "mist", "blot", "mach", "poky", "rams", "sits", "rend", "dome", "pray", "duck", "hers", "lure", "keep", "gory", "chat", "runt", "jams", "lays", "posy", "bats", "hoff", "rock", "keri", "raul", "yves", "lama", "ramp", "vote", "jody", "pock", "gist", "sass", "iago", "coos", "rank", "lowe", "vows", "koch", "taco", "jinn", "juno", "rape", "band", "aces", "goal", "huck", "lila", "tuft", "swan", "blab", "leda", "gems", "hide", "tack", "porn", "scum", "frat", "plum", "duds", "shad", "arms", "pare", "chin", "gain", "knee", "foot", "line", "dove", "vera", "jays", "fund", "reno", "skid", "boys", "corn", "gwyn", "sash", "weld", "ruiz", "dior", "jess", "leaf", "pars", "cote", "zing", "scat", "nice", "dart", "only", "owls", "hike", "trey", "whys", "ding", "klan", "ross", "barb", "ants", "lean", "dopy", "hock", "tour", "grip", "aldo", "whim", "prom", "rear", "dins", "duff", "dell", "loch", "lava", "sung", "yank", "thar", "curl", "venn", "blow", "pomp", "heat", "trap", "dali", "nets", "seen", "gash", "twig", "dads", "emmy", "rhea", "navy", "haws", "mite", "bows", "alas", "ives", "play", "soon", "doll", "chum", "ajar", "foam", "call", "puke", "kris", "wily", "came", "ales", "reef", "raid", "diet", "prod", "prut", "loot", "soar", "coed", "celt", "seam", "dray", "lump", "jags", "nods", "sole", "kink", "peso", "howl", "cost", "tsar", "uric", "sore", "woes", "sewn", "sake", "cask", "caps", "burl", "tame", "bulk", "neva", "from", "meet", "webs", "spar", "fuck", "buoy", "wept", "west", "dual", "pica", "sold", "seed", "gads", "riff", "neck", "deed", "rudy", "drop", "vale", "flit", "romp", "peak", "jape", "jews", "fain", "dens", "hugo", "elba", "mink", "town", "clam", "feud", "fern", "dung", "newt", "mime", "deem", "inti", "gigs", "sosa", "lope", "lard", "cara", "smug", "lego", "flex", "doth", "paar", "moon", "wren", "tale", "kant", "eels", "muck", "toga", "zens", "lops", "duet", "coil", "gall", "teal", "glib", "muir", "ails", "boer", "them", "rake", "conn", "neat", "frog", "trip", "coma", "must", "mono", "lira", "craw", "sled", "wear", "toby", "reel", "hips", "nate", "pump", "mont", "died", "moss", "lair", "jibe", "oils", "pied", "hobs", "cads", "haze", "muse", "cogs", "figs", "cues", "roes", "whet", "boru", "cozy", "amos", "tans", "news", "hake", "cots", "boas", "tutu", "wavy", "pipe", "typo", "albs", "boom", "dyke", "wail", "woke", "ware", "rita", "fail", "slab", "owes", "jane", "rack", "hell", "lags", "mend", "mask", "hume", "wane", "acne", "team", "holy", "runs", "exes", "dole", "trim", "zola", "trek", "puma", "wacs", "veep", "yaps", "sums", "lush", "tubs", "most", "witt", "bong", "rule", "hear", "awry", "sots", "nils", "bash", "gasp", "inch", "pens", "fies", "juts", "pate", "vine", "zulu", "this", "bare", "veal", "josh", "reek", "ours", "cowl", "club", "farm", "teat", "coat", "dish", "fore", "weft", "exam", "vlad", "floe", "beak", "lane", "ella", "warp", "goth", "ming", "pits", "rent", "tito", "wish", "amps", "says", "hawk", "ways", "punk", "nark", "cagy", "east", "paul", "bose", "solo", "teed", "text", "hews", "snip", "lips", "emit", "orgy", "icon", "tuna", "soul", "kurd", "clod", "calk", "aunt", "bake", "copy", "acid", "duse", "kiln", "spec", "fans", "bani", "irma", "pads", "batu", "logo", "pack", "oder", "atop", "funk", "gide", "bede", "bibs", "taut", "guns", "dana", "puff", "lyme", "flat", "lake", "june", "sets", "gull", "hops", "earn", "clip", "fell", "kama", "seal", "diaz", "cite", "chew", "cuba", "bury", "yard", "bank", "byes", "apia", "cree", "nosh", "judo", "walk", "tape", "taro", "boot", "cods", "lade", "cong", "deft", "slim", "jeri", "rile", "park", "aeon", "fact", "slow", "goff", "cane", "earp", "tart", "does", "acts", "hope", "cant", "buts", "shin", "dude", "ergo", "mode", "gene", "lept", "chen", "beta", "eden", "pang", "saab", "fang", "whir", "cove", "perk", "fads", "rugs", "herb", "putt", "nous", "vane", "corm", "stay", "bids", "vela", "roof", "isms", "sics", "gone", "swum", "wiry", "cram", "rink", "pert", "heap", "sikh", "dais", "cell", "peel", "nuke", "buss", "rasp", "none", "slut", "bent", "dams", "serb", "dork", "bays", "kale", "cora", "wake", "welt", "rind", "trot", "sloe", "pity", "rout", "eves", "fats", "furs", "pogo", "beth", "hued", "edam", "iamb", "glee", "lute", "keel", "airy", "easy", "tire", "rube", "bogy", "sine", "chop", "rood", "elbe", "mike", "garb", "jill", "gaul", "chit", "dons", "bars", "ride", "beck", "toad", "make", "head", "suds", "pike", "snot", "swat", "peed", "same", "gaza", "lent", "gait", "gael", "elks", "hang", "nerf", "rosy", "shut", "glop", "pain", "dion", "deaf", "hero", "doer", "wost", "wage", "wash", "pats", "narc", "ions", "dice", "quay", "vied", "eons", "case", "pour", "urns", "reva", "rags", "aden", "bone", "rang", "aura", "iraq", "toot", "rome", "hals", "megs", "pond", "john", "yeps", "pawl", "warm", "bird", "tint", "jowl", "gibe", "come", "hold", "pail", "wipe", "bike", "rips", "eery", "kent", "hims", "inks", "fink", "mott", "ices", "macy", "serf", "keys", "tarp", "cops", "sods", "feet", "tear", "benz", "buys", "colo", "boil", "sews", "enos", "watt", "pull", "brag", "cork", "save", "mint", "feat", "jamb", "rubs", "roxy", "toys", "nosy", "yowl", "tamp", "lobs", "foul", "doom", "sown", "pigs", "hemp", "fame", "boor", "cube", "tops", "loco", "lads", "eyre", "alta", "aged", "flop", "pram", "lesa", "sawn", "plow", "aral", "load", "lied", "pled", "boob", "bert", "rows", "zits", "rick", "hint", "dido", "fist", "marc", "wuss", "node", "smog", "nora", "shim", "glut", "bale", "perl", "what", "tort", "meek", "brie", "bind", "cake", "psst", "dour", "jove", "tree", "chip", "stud", "thou", "mobs", "sows", "opts", "diva", "perm", "wise", "cuds", "sols", "alan", "mild", "pure", "gail", "wins", "offs", "nile", "yelp", "minn", "tors", "tran", "homy", "sadr", "erse", "nero", "scab", "finn", "mich", "turd", "then", "poem", "noun", "oxus", "brow", "door", "saws", "eben", "wart", "wand", "rosa", "left", "lina", "cabs", "rapt", "olin", "suet", "kalb", "mans", "dawn", "riel", "temp", "chug", "peal", "drew", "null", "hath", "many", "took", "fond", "gate", "sate", "leak", "zany", "vans", "mart", "hess", "home", "long", "dirk", "bile", "lace", "moog", "axes", "zone", "fork", "duct", "rico", "rife", "deep", "tiny", "hugh", "bilk", "waft", "swig", "pans", "with", "kern", "busy", "film", "lulu", "king", "lord", "veda", "tray", "legs", "soot", "ells", "wasp", "hunt", "earl", "ouch", "diem", "yell", "pegs", "blvd", "polk", "soda", "zorn", "liza", "slop", "week", "kill", "rusk", "eric", "sump", "haul", "rims", "crop", "blob", "face", "bins", "read", "care", "pele", "ritz", "beau", "golf", "drip", "dike", "stab", "jibs", "hove", "junk", "hoax", "tats", "fief", "quad", "peat", "ream", "hats", "root", "flak", "grit", "clap", "pugh", "bosh", "lock", "mute", "crow", "iced", "lisa", "bela", "fems", "oxes", "vies", "gybe", "huff", "bull", "cuss", "sunk", "pups", "fobs", "turf", "sect", "atom", "debt", "sane", "writ", "anon", "mayo", "aria", "seer", "thor", "brim", "gawk", "jack", "jazz", "menu", "yolk", "surf", "libs", "lets", "bans", "toil", "open", "aced", "poor", "mess", "wham", "fran", "gina", "dote", "love", "mood", "pale", "reps", "ines", "shot", "alar", "twit", "site", "dill", "yoga", "sear", "vamp", "abel", "lieu", "cuff", "orbs", "rose", "tank", "gape", "guam", "adar", "vole", "your", "dean", "dear", "hebe", "crab", "hump", "mole", "vase", "rode", "dash", "sera", "balk", "lela", "inca", "gaea", "bush", "loud", "pies", "aide", "blew", "mien", "side", "kerr", "ring", "tess", "prep", "rant", "lugs", "hobo", "joke", "odds", "yule", "aida", "true", "pone", "lode", "nona", "weep", "coda", "elmo", "skim", "wink", "bras", "pier", "bung", "pets", "tabs", "ryan", "jock", "body", "sofa", "joey", "zion", "mace", "kick", "vile", "leno", "bali", "fart", "that", "redo", "ills", "jogs", "pent", "drub", "slaw", "tide", "lena", "seep", "gyps", "wave", "amid", "fear", "ties", "flan", "wimp", "kali", "shun", "crap", "sage", "rune", "logs", "cain", "digs", "abut", "obit", "paps", "rids", "fair", "hack", "huns", "road", "caws", "curt", "jute", "fisk", "fowl", "duty", "holt", "miss", "rude", "vito", "baal", "ural", "mann", "mind", "belt", "clem", "last", "musk", "roam", "abed", "days", "bore", "fuze", "fall", "pict", "dump", "dies", "fiat", "vent", "pork", "eyed", "docs", "rive", "spas", "rope", "ariz", "tout", "game", "jump", "blur", "anti", "lisp", "turn", "sand", "food", "moos", "hoop", "saul", "arch", "fury", "rise", "diss", "hubs", "burs", "grid", "ilks", "suns", "flea", "soil", "lung", "want", "nola", "fins", "thud", "kidd", "juan", "heps", "nape", "rash", "burt", "bump", "tots", "brit", "mums", "bole", "shah", "tees", "skip", "limb", "umps", "ache", "arcs", "raft", "halo", "luce", "bahs", "leta", "conk", "duos", "siva", "went", "peek", "sulk", "reap", "free", "dubs", "lang", "toto", "hasp", "ball", "rats", "nair", "myst", "wang", "snug", "nash", "laos", "ante", "opal", "tina", "pore", "bite", "haas", "myth", "yugo", "foci", "dent", "bade", "pear", "mods", "auto", "shop", "etch", "lyly", "curs", "aron", "slew", "tyro", "sack", "wade", "clio", "gyro", "butt", "icky", "char", "itch", "halt", "gals", "yang", "tend", "pact", "bees", "suit", "puny", "hows", "nina", "brno", "oops", "lick", "sons", "kilo", "bust", "nome", "mona", "dull", "join", "hour", "papa", "stag", "bern", "wove", "lull", "slip", "laze", "roil", "alto", "bath", "buck", "alma", "anus", "evil", "dumb", "oreo", "rare", "near", "cure", "isis", "hill", "kyle", "pace", "comb", "nits", "flip", "clop", "mort", "thea", "wall", "kiel", "judd", "coop", "dave", "very", "amie", "blah", "flub", "talc", "bold", "fogy", "idea", "prof", "horn", "shoo", "aped", "pins", "helm", "wees", "beer", "womb", "clue", "alba", "aloe", "fine", "bard", "limo", "shaw", "pint", "swim", "dust", "indy", "hale", "cats", "troy", "wens", "luke", "vern", "deli", "both", "brig", "daub", "sara", "sued", "bier", "noel", "olga", "dupe", "look", "pisa", "knox", "murk", "dame", "matt", "gold", "jame", "toge", "luck", "peck", "tass", "calf", "pill", "wore", "wadi", "thur", "parr", "maul", "tzar", "ones", "lees", "dark", "fake", "bast", "zoom", "here", "moro", "wine", "bums", "cows", "jean", "palm", "fume", "plop", "help", "tuba", "leap", "cans", "back", "avid", "lice", "lust", "polo", "dory", "stew", "kate", "rama", "coke", "bled", "mugs", "ajax", "arts", "drug", "pena", "cody", "hole", "sean", "deck", "guts", "kong", "bate", "pitt", "como", "lyle", "siam", "rook", "baby", "jigs", "bret", "bark", "lori", "reba", "sups", "made", "buzz", "gnaw", "alps", "clay", "post", "viol", "dina", "card", "lana", "doff", "yups", "tons", "live", "kids", "pair", "yawl", "name", "oven", "sirs", "gyms", "prig", "down", "leos", "noon", "nibs", "cook", "safe", "cobb", "raja", "awes", "sari", "nerd", "fold", "lots", "pete", "deal", "bias", "zeal", "girl", "rage", "cool", "gout", "whey", "soak", "thaw", "bear", "wing", "nagy", "well", "oink", "sven", "kurt", "etna", "held", "wood", "high", "feta", "twee", "ford", "cave", "knot", "tory", "ibis", "yaks", "vets", "foxy", "sank", "cone", "pius", "tall", "seem", "wool", "flap", "gird", "lore", "coot", "mewl", "sere", "real", "puts", "sell", "nuts", "foil", "lilt", "saga", "heft", "dyed", "goat", "spew", "daze", "frye", "adds", "glen", "tojo", "pixy", "gobi", "stop", "tile", "hiss", "shed", "hahn", "baku", "ahas", "sill", "swap", "also", "carr", "manx", "lime", "debs", "moat", "eked", "bola", "pods", "coon", "lacy", "tube", "minx", "buff", "pres", "clew", "gaff", "flee", "burn", "whom", "cola", "fret", "purl", "wick", "wigs", "donn", "guys", "toni", "oxen", "wite", "vial", "spam", "huts", "vats", "lima", "core", "eula", "thad", "peon", "erie", "oats", "boyd", "cued", "olaf", "tams", "secs", "urey", "wile", "penn", "bred", "rill", "vary", "sues", "mail", "feds", "aves", "code", "beam", "reed", "neil", "hark", "pols", "gris", "gods", "mesa", "test", "coup", "heed", "dora", "hied", "tune", "doze", "pews", "oaks", "bloc", "tips", "maid", "goof", "four", "woof", "silo", "bray", "zest", "kiss", "yong", "file", "hilt", "iris", "tuns", "lily", "ears", "pant", "jury", "taft", "data", "gild", "pick", "kook", "colt", "bohr", "anal", "asps", "babe", "bach", "mash", "biko", "bowl", "huey", "jilt", "goes", "guff", "bend", "nike", "tami", "gosh", "tike", "gees", "urge", "path", "bony", "jude", "lynn", "lois", "teas", "dunn", "elul", "bonn", "moms", "bugs", "slay", "yeah", "loan", "hulk", "lows", "damn", "nell", "jung", "avis", "mane", "waco", "loin", "knob", "tyke", "anna", "hire", "luau", "tidy", "nuns", "pots", "quid", "exec", "hans", "hera", "hush", "shag", "scot", "moan", "wald", "ursa", "lorn", "hunk", "loft", "yore", "alum", "mows", "slog", "emma", "spud", "rice", "worn", "erma", "need", "bags", "lark", "kirk", "pooh", "dyes", "area", "dime", "luvs", "foch", "refs", "cast", "alit", "tugs", "even", "role", "toed", "caph", "nigh", "sony", "bide", "robs", "folk", "daft", "past", "blue", "flaw", "sana", "fits", "barr", "riot", "dots", "lamp", "cock", "fibs", "harp", "tent", "hate", "mali", "togs", "gear", "tues", "bass", "pros", "numb", "emus", "hare", "fate", "wife", "mean", "pink", "dune", "ares", "dine", "oily", "tony", "czar", "spay", "push", "glum", "till", "moth", "glue", "dive", "scad", "pops", "woks", "andy", "leah", "cusp", "hair", "alex", "vibe", "bulb", "boll", "firm", "joys", "tara", "cole", "levy", "owen", "chow", "rump", "jail", "lapp", "beet", "slap", "kith", "more", "maps", "bond", "hick", "opus", "rust", "wist", "shat", "phil", "snow", "lott", "lora", "cary", "mote", "rift", "oust", "klee", "goad", "pith", "heep", "lupe", "ivan", "mimi", "bald", "fuse", "cuts", "lens", "leer", "eyry", "know", "razz", "tare", "pals", "geek", "greg", "teen", "clef", "wags", "weal", "each", "haft", "nova", "waif", "rate", "katy", "yale", "dale", "leas", "axum", "quiz", "pawn", "fend", "capt", "laws", "city", "chad", "coal", "nail", "zaps", "sort", "loci", "less", "spur", "note", "foes", "fags", "gulp", "snap", "bogs", "wrap", "dane", "melt", "ease", "felt", "shea", "calm", "star", "swam", "aery", "year", "plan", "odin", "curd", "mira", "mops", "shit", "davy", "apes", "inky", "hues", "lome", "bits", "vila", "show", "best", "mice", "gins", "next", "roan", "ymir", "mars", "oman", "wild", "heal", "plus", "erin", "rave", "robe", "fast", "hutu", "aver", "jodi", "alms", "yams", "zero", "revs", "wean", "chic", "self", "jeep", "jobs", "waxy", "duel", "seek", "spot", "raps", "pimp", "adan", "slam", "tool", "morn", "futz", "ewes", "errs", "knit", "rung", "kans", "muff", "huhs", "tows", "lest", "meal", "azov", "gnus", "agar", "sips", "sway", "otis", "tone", "tate", "epic", "trio", "tics", "fade", "lear", "owns", "robt", "weds", "five", "lyon", "terr", "arno", "mama", "grey", "disk", "sept", "sire", "bart", "saps", "whoa", "turk", "stow", "pyle", "joni", "zinc", "negs", "task", "leif", "ribs", "malt", "nine", "bunt", "grin", "dona", "nope", "hams", "some", "molt", "smit", "sacs", "joan", "slav", "lady", "base", "heck", "list", "take", "herd", "will", "nubs", "burg", "hugs", "peru", "coif", "zoos", "nick", "idol", "levi", "grub", "roth", "adam", "elma", "tags", "tote", "yaws", "cali", "mete", "lula", "cubs", "prim", "luna", "jolt", "span", "pita", "dodo", "puss", "deer", "term", "dolt", "goon", "gary", "yarn", "aims", "just", "rena", "tine", "cyst", "meld", "loki", "wong", "were", "hung", "maze", "arid", "cars", "wolf", "marx", "faye", "eave", "raga", "flow", "neal", "lone", "anne", "cage", "tied", "tilt", "soto", "opel", "date", "buns", "dorm", "kane", "akin", "ewer", "drab", "thai", "jeer", "grad", "berm", "rods", "saki", "grus", "vast", "late", "lint", "mule", "risk", "labs", "snit", "gala", "find", "spin", "ired", "slot", "oafs", "lies", "mews", "wino", "milk", "bout", "onus", "tram", "jaws", "peas", "cleo", "seat", "gums", "cold", "vang", "dewy", "hood", "rush", "mack", "yuan", "odes", "boos", "jami", "mare", "plot", "swab", "borg", "hays", "form", "mesh", "mani", "fife", "good", "gram", "lion", "myna", "moor", "skin", "posh", "burr", "rime", "done", "ruts", "pays", "stem", "ting", "arty", "slag", "iron", "ayes", "stub", "oral", "gets", "chid", "yens", "snub", "ages", "wide", "bail", "verb", "lamb", "bomb", "army", "yoke", "gels", "tits", "bork", "mils", "nary", "barn", "hype", "odom", "avon", "hewn", "rios", "cams", "tact", "boss", "oleo", "duke", "eris", "gwen", "elms", "deon", "sims", "quit", "nest", "font", "dues", "yeas", "zeta", "bevy", "gent", "torn", "cups", "worm", "baum", "axon", "purr", "vise", "grew", "govs", "meat", "chef", "rest", "lame" };

            ////List<string> wordDict = new List<string>();

            ////foreach (var item in listWords)
            ////{
            ////    wordDict.Add(item);
            ////}

            //var result = ReverseWordsInString.subStringsLessKDist(s1, k);
            //Console.WriteLine(result);
            //Console.Read();

            //List<string> s = new List<string>();
            //s.Add("2abc");
            //s.Add("bcd");
            //s.Add("cab");

            //List<string> t = new List<string>();
            //t.Add("dbc");
            //t.Add("2abc");
            //t.Add("cab");
            //t.Add("bcd");
            //t.Add("bcb");

            //var result = ReverseWordsInString.subSequenceTags(s, t);
            //Console.WriteLine(result);
            //Console.Read();


            //string[] listWords = { "slit", "bunk", "wars", "ping", "viva", "wynn", "wows", "irks", "gang", "pool", "mock", "fort", "heel", "send", "ship", "cols", "alec", "foal", "nabs", "gaze", "giza", "mays", "dogs", "karo", "cums", "jedi", "webb", "lend", "mire", "jose", "catt", "grow", "toss", "magi", "leis", "bead", "kara", "hoof", "than", "ires", "baas", "vein", "kari", "riga", "oars", "gags", "thug", "yawn", "wive", "view", "germ", "flab", "july", "tuck", "rory", "bean", "feed", "rhee", "jeez", "gobs", "lath", "desk", "yoko", "cute", "zeus", "thus", "dims", "link", "dirt", "mara", "disc", "limy", "lewd", "maud", "duly", "elsa", "hart", "rays", "rues", "camp", "lack", "okra", "tome", "math", "plug", "monk", "orly", "friz", "hogs", "yoda", "poop", "tick", "plod", "cloy", "pees", "imps", "lead", "pope", "mall", "frey", "been", "plea", "poll", "male", "teak", "soho", "glob", "bell", "mary", "hail", "scan", "yips", "like", "mull", "kory", "odor", "byte", "kaye", "word", "honk", "asks", "slid", "hopi", "toke", "gore", "flew", "tins", "mown", "oise", "hall", "vega", "sing", "fool", "boat", "bobs", "lain", "soft", "hard", "rots", "sees", "apex", "chan", "told", "woos", "unit", "scow", "gilt", "beef", "jars", "tyre", "imus", "neon", "soap", "dabs", "rein", "ovid", "hose", "husk", "loll", "asia", "cope", "tail", "hazy", "clad", "lash", "sags", "moll", "eddy", "fuel", "lift", "flog", "land", "sigh", "saks", "sail", "hook", "visa", "tier", "maws", "roeg", "gila", "eyes", "noah", "hypo", "tore", "eggs", "rove", "chap", "room", "wait", "lurk", "race", "host", "dada", "lola", "gabs", "sobs", "joel", "keck", "axed", "mead", "gust", "laid", "ends", "oort", "nose", "peer", "kept", "abet", "iran", "mick", "dead", "hags", "tens", "gown", "sick", "odis", "miro", "bill", "fawn", "sumo", "kilt", "huge", "ores", "oran", "flag", "tost", "seth", "sift", "poet", "reds", "pips", "cape", "togo", "wale", "limn", "toll", "ploy", "inns", "snag", "hoes", "jerk", "flux", "fido", "zane", "arab", "gamy", "raze", "lank", "hurt", "rail", "hind", "hoot", "dogy", "away", "pest", "hoed", "pose", "lose", "pole", "alva", "dino", "kind", "clan", "dips", "soup", "veto", "edna", "damp", "gush", "amen", "wits", "pubs", "fuzz", "cash", "pine", "trod", "gunk", "nude", "lost", "rite", "cory", "walt", "mica", "cart", "avow", "wind", "book", "leon", "life", "bang", "draw", "leek", "skis", "dram", "ripe", "mine", "urea", "tiff", "over", "gale", "weir", "defy", "norm", "tull", "whiz", "gill", "ward", "crag", "when", "mill", "firs", "sans", "flue", "reid", "ekes", "jain", "mutt", "hems", "laps", "piss", "pall", "rowe", "prey", "cull", "knew", "size", "wets", "hurl", "wont", "suva", "girt", "prys", "prow", "warn", "naps", "gong", "thru", "livy", "boar", "sade", "amok", "vice", "slat", "emir", "jade", "karl", "loyd", "cerf", "bess", "loss", "rums", "lats", "bode", "subs", "muss", "maim", "kits", "thin", "york", "punt", "gays", "alpo", "aids", "drag", "eras", "mats", "pyre", "clot", "step", "oath", "lout", "wary", "carp", "hums", "tang", "pout", "whip", "fled", "omar", "such", "kano", "jake", "stan", "loop", "fuss", "mini", "byrd", "exit", "fizz", "lire", "emil", "prop", "noes", "awed", "gift", "soli", "sale", "gage", "orin", "slur", "limp", "saar", "arks", "mast", "gnat", "port", "into", "geed", "pave", "awls", "cent", "cunt", "full", "dint", "hank", "mate", "coin", "tars", "scud", "veer", "coax", "bops", "uris", "loom", "shod", "crib", "lids", "drys", "fish", "edit", "dick", "erna", "else", "hahs", "alga", "moho", "wire", "fora", "tums", "ruth", "bets", "duns", "mold", "mush", "swop", "ruby", "bolt", "nave", "kite", "ahem", "brad", "tern", "nips", "whew", "bait", "ooze", "gino", "yuck", "drum", "shoe", "lobe", "dusk", "cult", "paws", "anew", "dado", "nook", "half", "lams", "rich", "cato", "java", "kemp", "vain", "fees", "sham", "auks", "gish", "fire", "elam", "salt", "sour", "loth", "whit", "yogi", "shes", "scam", "yous", "lucy", "inez", "geld", "whig", "thee", "kelp", "loaf", "harm", "tomb", "ever", "airs", "page", "laud", "stun", "paid", "goop", "cobs", "judy", "grab", "doha", "crew", "item", "fogs", "tong", "blip", "vest", "bran", "wend", "bawl", "feel", "jets", "mixt", "tell", "dire", "devi", "milo", "deng", "yews", "weak", "mark", "doug", "fare", "rigs", "poke", "hies", "sian", "suez", "quip", "kens", "lass", "zips", "elva", "brat", "cosy", "teri", "hull", "spun", "russ", "pupa", "weed", "pulp", "main", "grim", "hone", "cord", "barf", "olav", "gaps", "rote", "wilt", "lars", "roll", "balm", "jana", "give", "eire", "faun", "suck", "kegs", "nita", "weer", "tush", "spry", "loge", "nays", "heir", "dope", "roar", "peep", "nags", "ates", "bane", "seas", "sign", "fred", "they", "lien", "kiev", "fops", "said", "lawn", "lind", "miff", "mass", "trig", "sins", "furl", "ruin", "sent", "cray", "maya", "clog", "puns", "silk", "axis", "grog", "jots", "dyer", "mope", "rand", "vend", "keen", "chou", "dose", "rain", "eats", "sped", "maui", "evan", "time", "todd", "skit", "lief", "sops", "outs", "moot", "faze", "biro", "gook", "fill", "oval", "skew", "veil", "born", "slob", "hyde", "twin", "eloy", "beat", "ergs", "sure", "kobe", "eggo", "hens", "jive", "flax", "mons", "dunk", "yest", "begs", "dial", "lodz", "burp", "pile", "much", "dock", "rene", "sago", "racy", "have", "yalu", "glow", "move", "peps", "hods", "kins", "salk", "hand", "cons", "dare", "myra", "sega", "type", "mari", "pelt", "hula", "gulf", "jugs", "flay", "fest", "spat", "toms", "zeno", "taps", "deny", "swag", "afro", "baud", "jabs", "smut", "egos", "lara", "toes", "song", "fray", "luis", "brut", "olen", "mere", "ruff", "slum", "glad", "buds", "silt", "rued", "gelt", "hive", "teem", "ides", "sink", "ands", "wisp", "omen", "lyre", "yuks", "curb", "loam", "darn", "liar", "pugs", "pane", "carl", "sang", "scar", "zeds", "claw", "berg", "hits", "mile", "lite", "khan", "erik", "slug", "loon", "dena", "ruse", "talk", "tusk", "gaol", "tads", "beds", "sock", "howe", "gave", "snob", "ahab", "part", "meir", "jell", "stir", "tels", "spit", "hash", "omit", "jinx", "lyra", "puck", "laue", "beep", "eros", "owed", "cede", "brew", "slue", "mitt", "jest", "lynx", "wads", "gena", "dank", "volt", "gray", "pony", "veld", "bask", "fens", "argo", "work", "taxi", "afar", "boon", "lube", "pass", "lazy", "mist", "blot", "mach", "poky", "rams", "sits", "rend", "dome", "pray", "duck", "hers", "lure", "keep", "gory", "chat", "runt", "jams", "lays", "posy", "bats", "hoff", "rock", "keri", "raul", "yves", "lama", "ramp", "vote", "jody", "pock", "gist", "sass", "iago", "coos", "rank", "lowe", "vows", "koch", "taco", "jinn", "juno", "rape", "band", "aces", "goal", "huck", "lila", "tuft", "swan", "blab", "leda", "gems", "hide", "tack", "porn", "scum", "frat", "plum", "duds", "shad", "arms", "pare", "chin", "gain", "knee", "foot", "line", "dove", "vera", "jays", "fund", "reno", "skid", "boys", "corn", "gwyn", "sash", "weld", "ruiz", "dior", "jess", "leaf", "pars", "cote", "zing", "scat", "nice", "dart", "only", "owls", "hike", "trey", "whys", "ding", "klan", "ross", "barb", "ants", "lean", "dopy", "hock", "tour", "grip", "aldo", "whim", "prom", "rear", "dins", "duff", "dell", "loch", "lava", "sung", "yank", "thar", "curl", "venn", "blow", "pomp", "heat", "trap", "dali", "nets", "seen", "gash", "twig", "dads", "emmy", "rhea", "navy", "haws", "mite", "bows", "alas", "ives", "play", "soon", "doll", "chum", "ajar", "foam", "call", "puke", "kris", "wily", "came", "ales", "reef", "raid", "diet", "prod", "prut", "loot", "soar", "coed", "celt", "seam", "dray", "lump", "jags", "nods", "sole", "kink", "peso", "howl", "cost", "tsar", "uric", "sore", "woes", "sewn", "sake", "cask", "caps", "burl", "tame", "bulk", "neva", "from", "meet", "webs", "spar", "fuck", "buoy", "wept", "west", "dual", "pica", "sold", "seed", "gads", "riff", "neck", "deed", "rudy", "drop", "vale", "flit", "romp", "peak", "jape", "jews", "fain", "dens", "hugo", "elba", "mink", "town", "clam", "feud", "fern", "dung", "newt", "mime", "deem", "inti", "gigs", "sosa", "lope", "lard", "cara", "smug", "lego", "flex", "doth", "paar", "moon", "wren", "tale", "kant", "eels", "muck", "toga", "zens", "lops", "duet", "coil", "gall", "teal", "glib", "muir", "ails", "boer", "them", "rake", "conn", "neat", "frog", "trip", "coma", "must", "mono", "lira", "craw", "sled", "wear", "toby", "reel", "hips", "nate", "pump", "mont", "died", "moss", "lair", "jibe", "oils", "pied", "hobs", "cads", "haze", "muse", "cogs", "figs", "cues", "roes", "whet", "boru", "cozy", "amos", "tans", "news", "hake", "cots", "boas", "tutu", "wavy", "pipe", "typo", "albs", "boom", "dyke", "wail", "woke", "ware", "rita", "fail", "slab", "owes", "jane", "rack", "hell", "lags", "mend", "mask", "hume", "wane", "acne", "team", "holy", "runs", "exes", "dole", "trim", "zola", "trek", "puma", "wacs", "veep", "yaps", "sums", "lush", "tubs", "most", "witt", "bong", "rule", "hear", "awry", "sots", "nils", "bash", "gasp", "inch", "pens", "fies", "juts", "pate", "vine", "zulu", "this", "bare", "veal", "josh", "reek", "ours", "cowl", "club", "farm", "teat", "coat", "dish", "fore", "weft", "exam", "vlad", "floe", "beak", "lane", "ella", "warp", "goth", "ming", "pits", "rent", "tito", "wish", "amps", "says", "hawk", "ways", "punk", "nark", "cagy", "east", "paul", "bose", "solo", "teed", "text", "hews", "snip", "lips", "emit", "orgy", "icon", "tuna", "soul", "kurd", "clod", "calk", "aunt", "bake", "copy", "acid", "duse", "kiln", "spec", "fans", "bani", "irma", "pads", "batu", "logo", "pack", "oder", "atop", "funk", "gide", "bede", "bibs", "taut", "guns", "dana", "puff", "lyme", "flat", "lake", "june", "sets", "gull", "hops", "earn", "clip", "fell", "kama", "seal", "diaz", "cite", "chew", "cuba", "bury", "yard", "bank", "byes", "apia", "cree", "nosh", "judo", "walk", "tape", "taro", "boot", "cods", "lade", "cong", "deft", "slim", "jeri", "rile", "park", "aeon", "fact", "slow", "goff", "cane", "earp", "tart", "does", "acts", "hope", "cant", "buts", "shin", "dude", "ergo", "mode", "gene", "lept", "chen", "beta", "eden", "pang", "saab", "fang", "whir", "cove", "perk", "fads", "rugs", "herb", "putt", "nous", "vane", "corm", "stay", "bids", "vela", "roof", "isms", "sics", "gone", "swum", "wiry", "cram", "rink", "pert", "heap", "sikh", "dais", "cell", "peel", "nuke", "buss", "rasp", "none", "slut", "bent", "dams", "serb", "dork", "bays", "kale", "cora", "wake", "welt", "rind", "trot", "sloe", "pity", "rout", "eves", "fats", "furs", "pogo", "beth", "hued", "edam", "iamb", "glee", "lute", "keel", "airy", "easy", "tire", "rube", "bogy", "sine", "chop", "rood", "elbe", "mike", "garb", "jill", "gaul", "chit", "dons", "bars", "ride", "beck", "toad", "make", "head", "suds", "pike", "snot", "swat", "peed", "same", "gaza", "lent", "gait", "gael", "elks", "hang", "nerf", "rosy", "shut", "glop", "pain", "dion", "deaf", "hero", "doer", "wost", "wage", "wash", "pats", "narc", "ions", "dice", "quay", "vied", "eons", "case", "pour", "urns", "reva", "rags", "aden", "bone", "rang", "aura", "iraq", "toot", "rome", "hals", "megs", "pond", "john", "yeps", "pawl", "warm", "bird", "tint", "jowl", "gibe", "come", "hold", "pail", "wipe", "bike", "rips", "eery", "kent", "hims", "inks", "fink", "mott", "ices", "macy", "serf", "keys", "tarp", "cops", "sods", "feet", "tear", "benz", "buys", "colo", "boil", "sews", "enos", "watt", "pull", "brag", "cork", "save", "mint", "feat", "jamb", "rubs", "roxy", "toys", "nosy", "yowl", "tamp", "lobs", "foul", "doom", "sown", "pigs", "hemp", "fame", "boor", "cube", "tops", "loco", "lads", "eyre", "alta", "aged", "flop", "pram", "lesa", "sawn", "plow", "aral", "load", "lied", "pled", "boob", "bert", "rows", "zits", "rick", "hint", "dido", "fist", "marc", "wuss", "node", "smog", "nora", "shim", "glut", "bale", "perl", "what", "tort", "meek", "brie", "bind", "cake", "psst", "dour", "jove", "tree", "chip", "stud", "thou", "mobs", "sows", "opts", "diva", "perm", "wise", "cuds", "sols", "alan", "mild", "pure", "gail", "wins", "offs", "nile", "yelp", "minn", "tors", "tran", "homy", "sadr", "erse", "nero", "scab", "finn", "mich", "turd", "then", "poem", "noun", "oxus", "brow", "door", "saws", "eben", "wart", "wand", "rosa", "left", "lina", "cabs", "rapt", "olin", "suet", "kalb", "mans", "dawn", "riel", "temp", "chug", "peal", "drew", "null", "hath", "many", "took", "fond", "gate", "sate", "leak", "zany", "vans", "mart", "hess", "home", "long", "dirk", "bile", "lace", "moog", "axes", "zone", "fork", "duct", "rico", "rife", "deep", "tiny", "hugh", "bilk", "waft", "swig", "pans", "with", "kern", "busy", "film", "lulu", "king", "lord", "veda", "tray", "legs", "soot", "ells", "wasp", "hunt", "earl", "ouch", "diem", "yell", "pegs", "blvd", "polk", "soda", "zorn", "liza", "slop", "week", "kill", "rusk", "eric", "sump", "haul", "rims", "crop", "blob", "face", "bins", "read", "care", "pele", "ritz", "beau", "golf", "drip", "dike", "stab", "jibs", "hove", "junk", "hoax", "tats", "fief", "quad", "peat", "ream", "hats", "root", "flak", "grit", "clap", "pugh", "bosh", "lock", "mute", "crow", "iced", "lisa", "bela", "fems", "oxes", "vies", "gybe", "huff", "bull", "cuss", "sunk", "pups", "fobs", "turf", "sect", "atom", "debt", "sane", "writ", "anon", "mayo", "aria", "seer", "thor", "brim", "gawk", "jack", "jazz", "menu", "yolk", "surf", "libs", "lets", "bans", "toil", "open", "aced", "poor", "mess", "wham", "fran", "gina", "dote", "love", "mood", "pale", "reps", "ines", "shot", "alar", "twit", "site", "dill", "yoga", "sear", "vamp", "abel", "lieu", "cuff", "orbs", "rose", "tank", "gape", "guam", "adar", "vole", "your", "dean", "dear", "hebe", "crab", "hump", "mole", "vase", "rode", "dash", "sera", "balk", "lela", "inca", "gaea", "bush", "loud", "pies", "aide", "blew", "mien", "side", "kerr", "ring", "tess", "prep", "rant", "lugs", "hobo", "joke", "odds", "yule", "aida", "true", "pone", "lode", "nona", "weep", "coda", "elmo", "skim", "wink", "bras", "pier", "bung", "pets", "tabs", "ryan", "jock", "body", "sofa", "joey", "zion", "mace", "kick", "vile", "leno", "bali", "fart", "that", "redo", "ills", "jogs", "pent", "drub", "slaw", "tide", "lena", "seep", "gyps", "wave", "amid", "fear", "ties", "flan", "wimp", "kali", "shun", "crap", "sage", "rune", "logs", "cain", "digs", "abut", "obit", "paps", "rids", "fair", "hack", "huns", "road", "caws", "curt", "jute", "fisk", "fowl", "duty", "holt", "miss", "rude", "vito", "baal", "ural", "mann", "mind", "belt", "clem", "last", "musk", "roam", "abed", "days", "bore", "fuze", "fall", "pict", "dump", "dies", "fiat", "vent", "pork", "eyed", "docs", "rive", "spas", "rope", "ariz", "tout", "game", "jump", "blur", "anti", "lisp", "turn", "sand", "food", "moos", "hoop", "saul", "arch", "fury", "rise", "diss", "hubs", "burs", "grid", "ilks", "suns", "flea", "soil", "lung", "want", "nola", "fins", "thud", "kidd", "juan", "heps", "nape", "rash", "burt", "bump", "tots", "brit", "mums", "bole", "shah", "tees", "skip", "limb", "umps", "ache", "arcs", "raft", "halo", "luce", "bahs", "leta", "conk", "duos", "siva", "went", "peek", "sulk", "reap", "free", "dubs", "lang", "toto", "hasp", "ball", "rats", "nair", "myst", "wang", "snug", "nash", "laos", "ante", "opal", "tina", "pore", "bite", "haas", "myth", "yugo", "foci", "dent", "bade", "pear", "mods", "auto", "shop", "etch", "lyly", "curs", "aron", "slew", "tyro", "sack", "wade", "clio", "gyro", "butt", "icky", "char", "itch", "halt", "gals", "yang", "tend", "pact", "bees", "suit", "puny", "hows", "nina", "brno", "oops", "lick", "sons", "kilo", "bust", "nome", "mona", "dull", "join", "hour", "papa", "stag", "bern", "wove", "lull", "slip", "laze", "roil", "alto", "bath", "buck", "alma", "anus", "evil", "dumb", "oreo", "rare", "near", "cure", "isis", "hill", "kyle", "pace", "comb", "nits", "flip", "clop", "mort", "thea", "wall", "kiel", "judd", "coop", "dave", "very", "amie", "blah", "flub", "talc", "bold", "fogy", "idea", "prof", "horn", "shoo", "aped", "pins", "helm", "wees", "beer", "womb", "clue", "alba", "aloe", "fine", "bard", "limo", "shaw", "pint", "swim", "dust", "indy", "hale", "cats", "troy", "wens", "luke", "vern", "deli", "both", "brig", "daub", "sara", "sued", "bier", "noel", "olga", "dupe", "look", "pisa", "knox", "murk", "dame", "matt", "gold", "jame", "toge", "luck", "peck", "tass", "calf", "pill", "wore", "wadi", "thur", "parr", "maul", "tzar", "ones", "lees", "dark", "fake", "bast", "zoom", "here", "moro", "wine", "bums", "cows", "jean", "palm", "fume", "plop", "help", "tuba", "leap", "cans", "back", "avid", "lice", "lust", "polo", "dory", "stew", "kate", "rama", "coke", "bled", "mugs", "ajax", "arts", "drug", "pena", "cody", "hole", "sean", "deck", "guts", "kong", "bate", "pitt", "como", "lyle", "siam", "rook", "baby", "jigs", "bret", "bark", "lori", "reba", "sups", "made", "buzz", "gnaw", "alps", "clay", "post", "viol", "dina", "card", "lana", "doff", "yups", "tons", "live", "kids", "pair", "yawl", "name", "oven", "sirs", "gyms", "prig", "down", "leos", "noon", "nibs", "cook", "safe", "cobb", "raja", "awes", "sari", "nerd", "fold", "lots", "pete", "deal", "bias", "zeal", "girl", "rage", "cool", "gout", "whey", "soak", "thaw", "bear", "wing", "nagy", "well", "oink", "sven", "kurt", "etna", "held", "wood", "high", "feta", "twee", "ford", "cave", "knot", "tory", "ibis", "yaks", "vets", "foxy", "sank", "cone", "pius", "tall", "seem", "wool", "flap", "gird", "lore", "coot", "mewl", "sere", "real", "puts", "sell", "nuts", "foil", "lilt", "saga", "heft", "dyed", "goat", "spew", "daze", "frye", "adds", "glen", "tojo", "pixy", "gobi", "stop", "tile", "hiss", "shed", "hahn", "baku", "ahas", "sill", "swap", "also", "carr", "manx", "lime", "debs", "moat", "eked", "bola", "pods", "coon", "lacy", "tube", "minx", "buff", "pres", "clew", "gaff", "flee", "burn", "whom", "cola", "fret", "purl", "wick", "wigs", "donn", "guys", "toni", "oxen", "wite", "vial", "spam", "huts", "vats", "lima", "core", "eula", "thad", "peon", "erie", "oats", "boyd", "cued", "olaf", "tams", "secs", "urey", "wile", "penn", "bred", "rill", "vary", "sues", "mail", "feds", "aves", "code", "beam", "reed", "neil", "hark", "pols", "gris", "gods", "mesa", "test", "coup", "heed", "dora", "hied", "tune", "doze", "pews", "oaks", "bloc", "tips", "maid", "goof", "four", "woof", "silo", "bray", "zest", "kiss", "yong", "file", "hilt", "iris", "tuns", "lily", "ears", "pant", "jury", "taft", "data", "gild", "pick", "kook", "colt", "bohr", "anal", "asps", "babe", "bach", "mash", "biko", "bowl", "huey", "jilt", "goes", "guff", "bend", "nike", "tami", "gosh", "tike", "gees", "urge", "path", "bony", "jude", "lynn", "lois", "teas", "dunn", "elul", "bonn", "moms", "bugs", "slay", "yeah", "loan", "hulk", "lows", "damn", "nell", "jung", "avis", "mane", "waco", "loin", "knob", "tyke", "anna", "hire", "luau", "tidy", "nuns", "pots", "quid", "exec", "hans", "hera", "hush", "shag", "scot", "moan", "wald", "ursa", "lorn", "hunk", "loft", "yore", "alum", "mows", "slog", "emma", "spud", "rice", "worn", "erma", "need", "bags", "lark", "kirk", "pooh", "dyes", "area", "dime", "luvs", "foch", "refs", "cast", "alit", "tugs", "even", "role", "toed", "caph", "nigh", "sony", "bide", "robs", "folk", "daft", "past", "blue", "flaw", "sana", "fits", "barr", "riot", "dots", "lamp", "cock", "fibs", "harp", "tent", "hate", "mali", "togs", "gear", "tues", "bass", "pros", "numb", "emus", "hare", "fate", "wife", "mean", "pink", "dune", "ares", "dine", "oily", "tony", "czar", "spay", "push", "glum", "till", "moth", "glue", "dive", "scad", "pops", "woks", "andy", "leah", "cusp", "hair", "alex", "vibe", "bulb", "boll", "firm", "joys", "tara", "cole", "levy", "owen", "chow", "rump", "jail", "lapp", "beet", "slap", "kith", "more", "maps", "bond", "hick", "opus", "rust", "wist", "shat", "phil", "snow", "lott", "lora", "cary", "mote", "rift", "oust", "klee", "goad", "pith", "heep", "lupe", "ivan", "mimi", "bald", "fuse", "cuts", "lens", "leer", "eyry", "know", "razz", "tare", "pals", "geek", "greg", "teen", "clef", "wags", "weal", "each", "haft", "nova", "waif", "rate", "katy", "yale", "dale", "leas", "axum", "quiz", "pawn", "fend", "capt", "laws", "city", "chad", "coal", "nail", "zaps", "sort", "loci", "less", "spur", "note", "foes", "fags", "gulp", "snap", "bogs", "wrap", "dane", "melt", "ease", "felt", "shea", "calm", "star", "swam", "aery", "year", "plan", "odin", "curd", "mira", "mops", "shit", "davy", "apes", "inky", "hues", "lome", "bits", "vila", "show", "best", "mice", "gins", "next", "roan", "ymir", "mars", "oman", "wild", "heal", "plus", "erin", "rave", "robe", "fast", "hutu", "aver", "jodi", "alms", "yams", "zero", "revs", "wean", "chic", "self", "jeep", "jobs", "waxy", "duel", "seek", "spot", "raps", "pimp", "adan", "slam", "tool", "morn", "futz", "ewes", "errs", "knit", "rung", "kans", "muff", "huhs", "tows", "lest", "meal", "azov", "gnus", "agar", "sips", "sway", "otis", "tone", "tate", "epic", "trio", "tics", "fade", "lear", "owns", "robt", "weds", "five", "lyon", "terr", "arno", "mama", "grey", "disk", "sept", "sire", "bart", "saps", "whoa", "turk", "stow", "pyle", "joni", "zinc", "negs", "task", "leif", "ribs", "malt", "nine", "bunt", "grin", "dona", "nope", "hams", "some", "molt", "smit", "sacs", "joan", "slav", "lady", "base", "heck", "list", "take", "herd", "will", "nubs", "burg", "hugs", "peru", "coif", "zoos", "nick", "idol", "levi", "grub", "roth", "adam", "elma", "tags", "tote", "yaws", "cali", "mete", "lula", "cubs", "prim", "luna", "jolt", "span", "pita", "dodo", "puss", "deer", "term", "dolt", "goon", "gary", "yarn", "aims", "just", "rena", "tine", "cyst", "meld", "loki", "wong", "were", "hung", "maze", "arid", "cars", "wolf", "marx", "faye", "eave", "raga", "flow", "neal", "lone", "anne", "cage", "tied", "tilt", "soto", "opel", "date", "buns", "dorm", "kane", "akin", "ewer", "drab", "thai", "jeer", "grad", "berm", "rods", "saki", "grus", "vast", "late", "lint", "mule", "risk", "labs", "snit", "gala", "find", "spin", "ired", "slot", "oafs", "lies", "mews", "wino", "milk", "bout", "onus", "tram", "jaws", "peas", "cleo", "seat", "gums", "cold", "vang", "dewy", "hood", "rush", "mack", "yuan", "odes", "boos", "jami", "mare", "plot", "swab", "borg", "hays", "form", "mesh", "mani", "fife", "good", "gram", "lion", "myna", "moor", "skin", "posh", "burr", "rime", "done", "ruts", "pays", "stem", "ting", "arty", "slag", "iron", "ayes", "stub", "oral", "gets", "chid", "yens", "snub", "ages", "wide", "bail", "verb", "lamb", "bomb", "army", "yoke", "gels", "tits", "bork", "mils", "nary", "barn", "hype", "odom", "avon", "hewn", "rios", "cams", "tact", "boss", "oleo", "duke", "eris", "gwen", "elms", "deon", "sims", "quit", "nest", "font", "dues", "yeas", "zeta", "bevy", "gent", "torn", "cups", "worm", "baum", "axon", "purr", "vise", "grew", "govs", "meat", "chef", "rest", "lame" };

            //List<string> wordDict = new List<string>();

            //foreach (var item in listWords)
            //{
            //    wordDict.Add(item);
            //}

            //var result = ReverseWordsInString.subStringsLessKDist(s1, k);
            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region Largest Number At Least Twice of Others
            //int[] nums = { 0, 0, 1, 2 };
            //var result = LargestNumberAtLeastTwiceOfOthers.LarestNumberTwiceOtherIndex(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Change Coin
            //int[] nums = { 1, 2, 5 };
            //int amount = 5;
            //var result = CoinChangeII.CoinChangeGetCount(nums, amount);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Largest Number
            //int[] nums = { 3, 30, 34, 5, 9 };
            //var result = LargestNumber.LargestNumberStringInput(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Plus One Linked List
            //ListNode head1 = new ListNode(4);
            //head1.next = new ListNode(5);
            //head1.next.next = new ListNode(9);
            //head1.next.next.next = new ListNode(9);

            //Console.WriteLine(PlusOneLinkedList.PlusOne(head1));
            //Console.Read();
            #endregion

            #region Nth Digit
            //int n = 11;
            //var result = NthDigit.GetDigit(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Kth Largest Element in an Array
            //int k = 2;
            //int[] nums = { 3, 2, 1, 5, 6, 4 };
            //var result = KthLargestElementArray.findKthLargest(nums, k);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Third Maximum Number
            //int[] nums = { 5, 2, 4, 1, 3, 6, 0 };
            //var result = ThirdMaximumNumberClass.ThirdMax(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Flip Game
            //string s = "++++";
            //var result = FlipGameII.FlipGameWinFirstPlayer(s);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Baseball Game
            //string[] Ops = { "5", "2", "C", "D", "+" };
            //var result = BaseballGame.GetPoints(Ops);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Bulls and Cows
            //string secret = "1807";
            //string guess = "7810";
            //var result = BullsCows.HintBullsCowsGame(secret, guess);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Elimination Game
            //int n = 24;
            //var result = EliminateGame.lastRemaining(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Path Sum II
            ////[1,-2,-3,1,3,-2,null,-1]
            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(8);

            //root.left.left = new TreeNode(11);

            //root.left.left.left = new TreeNode(7);
            //root.left.left.right = new TreeNode(2);

            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(4);

            //root.right.right.left = new TreeNode(5);
            //root.right.right.right = new TreeNode(1);

            //Console.WriteLine(PathSumII.GetPathSumList(root, 22));
            //Console.ReadKey();
            #endregion

            #region Find All Numbers Disappeared in an Array
            //int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            //var result = FindMissingPositiveNumbers.FindMissingNumbersFromList(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Convert BST to Greater Tree
            ////[1,-2,-3,1,3,-2,null,-1]
            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(14);
            //Console.WriteLine(ConvertBSTToGT.ConvertBinarySearchTreeToGreaterTree(root));
            //Console.ReadKey();
            #endregion

            #region Generate Parentheses
            //int n = 4;
            //var result = GenerateParentheses.GenerateValidParenthesesFromGivenNumber(n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Binary Tree Right Side View
            ////[1,-2,-3,1,3,-2,null,-1]
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.left.left = new TreeNode(4);
            //Console.WriteLine(BinaryTreeRightSideView.PrintBinaryTreeRightSideView(root));
            //Console.ReadKey();
            #endregion

            #region Sum Of Right Leaves
            //[1,-2,-3,1,3,-2,null,-1]
            //  Given the below binary tree and sum = 22,
            //              5
            //             / \
            //            4   8
            //           /   / \
            //          11  13  4
            //         /  \      \
            //        7    2      1

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.left.left.right = new TreeNode(2);

            //root.right = new TreeNode(3);
            //root.right.right = new TreeNode(8);

            //root.right.right.left = new TreeNode(6);
            //root.right.right.right = new TreeNode(7);

            //var result = SumOfRightLeaves.GetSumOfRightLeaves(root);
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion

            #region Construct Binary Tree from Preorder and Inorder Traversal
            //int[] preorder = { 3, 9, 20, 15, 7 };
            //int[] inorder = { 9, 3, 15, 20, 7 };
            //var result = ConstructBinaryTreeFromInOrderPreOrder.BuildTree(inorder,preorder);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Word Break
            //string s1 = "leetcode";

            //string[] listWords = { "leet", "code" };

            //List<string> wordDict = new List<string>();

            //foreach (var item in listWords)
            //{
            //    wordDict.Add(item);
            //}

            //var result = WordBreak.IsWordBreakPossible(s1, wordDict);
            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region Find Difference
            //string s = "abcd";
            //string t = "abcde";

            //var result = FindTheDifferenceClass.FindDiff(s, t);
            //Console.WriteLine(result);
            //Console.Read();

            #endregion

            #region Coin Change
            //int[] nums = { 1, 2, 5 };
            //int n = 11;
            //var result = CoinChange.GetCoinCountChange(nums, n);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Word Search

            //char[,] word = new char[3, 4]
            //{            
            //    { 'A', 'B', 'C', 'E' },
            //    { 'S', 'F', 'C', 'S' },
            //    { 'A', 'D', 'E', 'E' }
            //};

            //string searchWord = "ABCCED";
            //var result = WordSearch.IsWordSearch2D(word, searchWord);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Basic Calculator 
            //string searchWord = "3+2*2";
            //var result = BasicCalculatorII.Calculate(searchWord);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Random Structure
            //RandomizedSet random = new RandomizedSet();
            //random.Insert(1);
            //random.Remove(2);
            //random.Insert(2);
            //int x = random.GetRandom();
            //random.Remove(1);
            //random.Insert(2);
            //x = random.GetRandom();
            //Console.WriteLine(x);
            #endregion

            #region Is Subsequqnce 
            //string s= "ahbgdc";
            //string t = "abc";
            //var result = IsSubsequence.isSubSequence(s, t);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Longest Harmonious Subsequence
            //int[] nums = { 1, 3, 2, 2, 5, 2, 3, 7 };
            //var result = LongestHarmoniousSubSequenceClass.LongestTwoPointer(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Shortest Unsorted Continuous Subarray
            //int[] nums = { 2, 6, 4, 8, 10, 9, 15 };
            //var result = ShortestUnSortedContinousSubArray.ShortestUnsortedSubArray(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Can Place Flowers
            //int[] nums = { 0, 0 };
            //var result = CanPlaceFlowersClass.CanPlace(nums, 2);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Min Cost Climbing Stairs
            //int[] nums = { 0, 0, 1, 2 };
            //var result = MinCostClimbingStairs.MinCost(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Find Duplicate File in System
            //string[] nums = { "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)" };
            //var result = FindDuplicateFilesInSystem.FindDuplicateFilesInDirectories(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Remove Duplicates from Sorted Array II
            //int[] nums = { 1, 1, 1, 2, 2, 3, 3 };
            //var result = RemoveDuplicatesFromSortedArrayII.RemoveDuplicates(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Find All Duplicates in an Array
            //int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            //var result = FindAllDuplicateNumbers.FindDuplicates(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Remove Duplicates from Sorted List II
            //    //1->1->2->2
            ////[7,2,4,3]
            ////[5,6,4]

            //    //3,4,2,7
            //    //4,6,5


            //ListNode head = new ListNode(1);
            //head.next = new ListNode(1);
            //head.next.next = new ListNode(1);
            //head.next.next.next = new ListNode(2);
            //head.next.next.next.next = new ListNode(2);
            //head.next.next.next.next.next = new ListNode(3);

            //var listNode = RemoveDuplicatesFromSortedListII.RemoveDuplicate(head);


            #endregion

            #region Design hashtable using chaining
            //FixedSizeGenericHashTable<string, string> hash = new FixedSizeGenericHashTable<string, string>(20);

            //hash.Add("1", "item 1");
            //hash.Add("2", "item 2");
            //hash.Add("dsfdsdsd", "sadsadsadsad");

            //string one = hash.FindValue("1");
            //string two = hash.FindValue("2");
            //string dsfdsdsd = hash.FindValue("dsfdsdsd");
            //hash.Remove("1");
            //Console.ReadLine();
            #endregion

            #region Kth Smallest Element in a BST
            //////[3,1,5,0,2,4,6]
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(5);

            //root.left.left = new TreeNode(0);
            //root.left.right = new TreeNode(2);

            //root.right.left = new TreeNode(4);
            //root.right.left.left = new TreeNode(6);

            //Console.WriteLine(KthSmallestElementBST.KthSmallest(root,2));
            //Console.ReadKey();
            #endregion

            #region Print Boundary Binary Tree
            ////[1,-2,-3,1,3,-2,null,-1]
            ////  Given the below binary tree and sum = 22,
            ////              5
            ////             / \
            ////            4   8
            ////           /   / \
            ////          11  13  4
            ////         /  \      \
            ////        7    2      1

            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(8);

            //root.left.left = new TreeNode(11);
            //root.left.left.left = new TreeNode(7);
            //root.left.left.right = new TreeNode(2);

            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(4);
            //root.right.right.right = new TreeNode(1);

            //var result = PrintBoundaryBinaryTree.GetBoundaryBinaryTreeRecursive(root);
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion

            #region Count Negative in Matrix
            //int[,] nums = new int[3, 4]
            //{
            //   { -3, -2, -1, 1 },
            //   { -2, 2, 3, 4 },
            //   { 4, 5, 7, 8 }  
            //};

            //var result = CountNegativeNumberInSortedMatrix.CountNegative(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Length of the longest substring without repeating characters

            ////string str = "au";
            //string str = "abcbbbbcccbdddadacb";
            ////Console.WriteLine("Input String - " + str);
            //Console.WriteLine(LongestSubstringWithAtMostTwoDistinctCharacters.LongestSubstringWithMostTwoUniqueChar(str));
            ////Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LogenstSubstringUniqueCharWithTemplate(str));
            ////Console.Read();

            #endregion

            #region Award Budget
            //double[] nums = { 2, 50, 100, 120, 167 };
            //double target = 400;
            //var result = AwardBudgetCutsClass.NewCapAwardBudgetCuts(nums, target);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Reverse Nodes in K Groups
            //ListNode head1 = new ListNode(1);
            //head1.next = new ListNode(2);
            //head1.next.next = new ListNode(3);
            //head1.next.next.next = new ListNode(4);
            //head1.next.next.next.next = new ListNode(5);
            //head1.next.next.next.next.next = new ListNode(6);

            //Console.WriteLine(ReverseNodesInK_Group.ReverseNodesKGroups(head1, 4));
            ////Console.Read();
            #endregion

            #region Regular Expression Matching
            //string text = "ab";
            //string pattern = "a*";
            //var result = BasicRegex.IsMatch(text, pattern);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Binary Tree Vertical Level Order Traversal

            //    35
            //   /   \
            //  23    27
            // /  \     \
            //14   10    9

            ////[3,9,20,null,null,15,7]

            //TreeNode root = new TreeNode(35);
            //root.left = new TreeNode(23);
            //root.right = new TreeNode(27);

            //root.left.left = new TreeNode(14);
            //root.left.right = new TreeNode(10);

            //root.right.right = new TreeNode(9);

            //TreeNodeVerticalOrder root = new TreeNodeVerticalOrder(35);
            //root.left = new TreeNodeVerticalOrder(23);
            //root.right = new TreeNodeVerticalOrder(27);

            //root.left.left = new TreeNodeVerticalOrder(14);
            //root.left.right = new TreeNodeVerticalOrder(10);

            //root.right.right = new TreeNodeVerticalOrder(9);
            //Console.WriteLine(VerticalLevelOrderTraversal.verticalOrderTreeTraversalII(root));
            //Console.ReadKey();
            #endregion

            #region Bottom View

            ////    35
            ////   /   \
            ////  23    27
            //// /  \     \
            ////14   10    9

            //////[3,9,20,null,null,15,7]

            //TreeNodeVerticalOrder root = new TreeNodeVerticalOrder(1);
            //root.left = new TreeNodeVerticalOrder(2);
            //root.right = new TreeNodeVerticalOrder(3);

            //root.left.left = new TreeNodeVerticalOrder(4);
            //root.left.right = new TreeNodeVerticalOrder(5);

            //root.right.left = new TreeNodeVerticalOrder(6);
            //root.right.right = new TreeNodeVerticalOrder(7);
            //Console.WriteLine(BottomViewBinaryTree.BottomView(root));
            //Console.ReadKey();
            #endregion

            #region Top View

            //////    35
            //////   /   \
            //////  23    27
            ////// /  \     \
            //////14   10    9

            ////////[3,9,20,null,null,15,7]

            //TreeNodeVerticalOrder root = new TreeNodeVerticalOrder(1);
            //root.left = new TreeNodeVerticalOrder(2);
            //root.right = new TreeNodeVerticalOrder(3);

            //root.left.left = new TreeNodeVerticalOrder(4);
            //root.left.right = new TreeNodeVerticalOrder(5);

            //root.right.left = new TreeNodeVerticalOrder(6);
            //root.right.right = new TreeNodeVerticalOrder(7);
            //Console.WriteLine(TopViewBinaryTree.TopView(root));
            //Console.ReadKey();
            #endregion

            #region Convert Sorted List to Binary Search Tree
            //    //1->1->2->2
            ////[7,2,4,3]
            ////[5,6,4]

            //    //3,4,2,7
            //    //4,6,5


            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);

            //var listNode = ConvertSortedListToBinaryTree.ConvertListToBST(head);

            #endregion

            #region Kth Smallest Element in a Sorted Matrix

            //int[,] nums = new int[3, 3]
            //{
            //    {1,5,9},
            //    {10,11,13},
            //    {12,13,15},
            //};

            //var result = KthSmallestElementInMatrix.KthSmallestElementMatrix(nums, 8);

            //Console.WriteLine(/*result*/);

            //Console.Read();
            #endregion

            #region Remove Spaces
            //Console.WriteLine(RemoveSpaces.RemoveSpace("    AB   C D    "));
            //Console.Read();
            #endregion

            #region Print Interleave
            //PrintInterleaveOfTwoStrings.PrintInterleave("AB","CD",0,0,"");
            //Console.Read();
            #endregion

            #region Containing Second Strings Chars
            //string[] strArray = { "program", "programming", "computer", "rope", "coding" };
            //string match = "pro";
            //PrintStringsContainingSecondStringChars.ContainingSecondStringsChars(strArray, match);
            #endregion

            #region Interleaving Strings
            //string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac";
            //InterleavingString.IsInterleavingIterative(s1,s2,s3);
            #endregion

            #region Meeting Rooms

            //////{ 6,8}, { 1,9}, { 2,4}, { 4,7}

            ////[10, 30],[5, 10],[15, 20]
            //Interval[] listInterval = new Interval[4];

            //Interval interval = new Interval();
            //interval.start = 10;
            //interval.end = 30;

            //Interval interval1 = new Interval();
            //interval1.start = 5;
            //interval1.end = 10;

            //Interval interval2 = new Interval();
            //interval2.start = 15;
            //interval2.end = 20;

            //Interval interval3 = new Interval();
            //interval3.start = 15;
            //interval3.end = 18;

            //listInterval[0] = interval;
            //listInterval[1] = interval1;
            //listInterval[2] = interval2;
            //listInterval[3] = interval3;
            //var result = MeetingRoom.IsMeetingRoomAvailable(listInterval);

            //Console.Read();
            #endregion

            #region Meeting Rooms II

            //////{ 6,8}, { 1,9}, { 2,4}, { 4,7}

            //[10, 30],[5, 10],[15, 20]
            //List<Interval> listInterval = new List<Interval>();

            //Interval interval = new Interval();
            //interval.start = 0;
            //interval.end = 30;

            //Interval interval1 = new Interval();
            //interval1.start = 5;
            //interval1.end = 10;

            //Interval interval2 = new Interval();
            //interval2.start = 15;
            //interval2.end = 20;

            //listInterval.Add(interval);
            //listInterval.Add(interval1);
            //listInterval.Add(interval2);
            //var result = MeetingRoomII.CountConfRoomMeetingIntervals(listInterval);

            //Console.Read();
            #endregion

            #region 3 Sum Samller
            //int[] nums = { -2, 0, 1, 3 };
            //var result1 = _3SumSmaller.Threeumsmaller(nums, 2);
            ////_3Sum.ThreeSumWithSort(nums);
            //Console.Read();
            #endregion

            #region Missing Ranges
            //int[] nums = { 0, 1, 3, 50, 75 };
            //var result = MissingRanges.GetAllMissingRanges(nums, 0, 99);
            ////_3Sum.ThreeSumWithSort(nums);
            //Console.Read();
            #endregion

            #region Max Consecutive Ones II
            //int[] nums = { 1, 0, 1, 1, 0 };
            //int result = MaxConsecutiveOnesClassII.FindMaxConsecutiveOnes(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region LFU Cache

            //["LFUCache", "put", "put", "get", "put", "put", "get"]
            //[[2],[2,1],[2,2],[2],[1,1],[4,1],[2]]

            //LFUCache objLFUCache = new LFUCache(2);
            //objLFUCache.Put(2, 1);
            //objLFUCache.Put(2, 2);
            //int cacheItem = objLFUCache.Get(2);
            //objLFUCache.Put(1, 1);
            //objLFUCache.Put(4, 1);
            //cacheItem = objLFUCache.Get(2);
            #endregion

            #region Serialize and Deserialize Binary Tree

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);


            //root.right.left = new TreeNode(4);
            //root.right.right = new TreeNode(5);

            //SerializeAndDeserializeBinaryTree.DeSerializeBinaryTreeBFS(SerializeAndDeserializeBinaryTree.SerializeBinaryTreeBFS(root));
            #endregion

            #region Reverse String
            //string s = " ";
            //var result = ReverseWordsInStringI.ReverseWords(s);
            #endregion

            #region Rotate String
            //var result = RotateString.RotateStr("vcuszhlbtpmksjleuchmjffufrwpiddgyynfujnqblngzoogzg", "fufrwpiddgyynfujnqblngzoogzgvcuszhlbtpmksjleuchmjf");
            #endregion

            #region Solve Equation
            //var result = SolveTheEquationClass.SolveEquation("2x=x");
            #endregion

            #region LCA of Two Nodes in the tree
            ////[1,-2,-3,1,3,-2,null,-1]

            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(5);
            //root.right = new TreeNode(1);

            //root.left.left = new TreeNode(6);
            //root.left.right = new TreeNode(2);

            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(8);

            //TreeNode p = new TreeNode(12);
            //TreeNode q = new TreeNode(20);

            //Console.WriteLine(LowestCommonAncestorBinaryTree.LCATwoNodesBinaryTree(root, p, q));
            //Console.ReadKey();
            #endregion

            #region Wiggle Sort
            //int[] nums = { 3, 5, 2, 1, 6, 4 };
            //WiggleSort.SortWiggle(nums);
            #endregion

            #region Transpose
            //int[][] nums = new int[2][];

            //nums[0] = new int[3]
            //{ 1,2,3};

            //nums[1] = new int[3]
            //{ 4,5,6};

            ////nums[2] = new int[3]
            ////{ 7,8,9};

            //TransposeMatrix.TransposeMatrixClassMethod(nums);
            //Console.WriteLine(/*result*/);
            //Console.Read();
            #endregion

            #region 01 Matrix
            //int[,] nums = new int[3, 3]
            //{
            //    { 0,0,0},
            //    { 0,1,0},
            //    { 1,1,1}
            //};

            //var result = _01Matrix.GetDistance(nums);
            //Console.WriteLine(/*result*/);
            //Console.Read();
            #endregion

            #region Spiral Matrix
            //var result =SpiralMatrixII.GenerateSpiralMatrixFromN(3);
            //Console.WriteLine(/*result*/);
            #endregion

            #region Urlify String
            //var result = ReplaceSpaceWithPercentage20String.UrlifyString("My name is Amit Agarwal                   ");
            //Console.WriteLine(/*result*/);
            #endregion

            #region Two Sum Data Structure
            //int[] nums = { 2, 2, 4, 5, 5, 9, 14 };
            //TwoSumIIIDataStructureDesign.add(2);
            //TwoSumIIIDataStructureDesign.add(2);
            //TwoSumIIIDataStructureDesign.add(4);
            //TwoSumIIIDataStructureDesign.add(5);
            //TwoSumIIIDataStructureDesign.add(5);
            //TwoSumIIIDataStructureDesign.add(9);
            //TwoSumIIIDataStructureDesign.add(14);
            //TwoSumIIIDataStructureDesign.find(4);
            #endregion

            #region Missing Number among three
            //var result = MissingNumbeRepatedThreeNumbers.MissingNumber("11122233344455666");
            //Console.Read();
            #endregion

            #region String Decode
            //var result = StringDecompress.StringDecode("3[a]2[bc]");
            //Console.Read();
            #endregion

            #region Maze Path
            ////int[,] nums = new int[8, 13]
            ////{{0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            //// {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            //// {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
            //// {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            //// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}};

            //int[,] nums = new int[4, 4]
            //{
            //    { 1, 0, 0, 0},
            //    { 1, 1, 0, 1},
            //    { 0, 1, 0, 0},
            //    { 1, 1, 1, 1}
            //};

            //var result = PathInRatMaze.IsPathInMaze(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Connect Same Level Nodes Next
            ////[3,9,20,null,null,15,7]

            //TreeNodeNextPointer root = new TreeNodeNextPointer(1);
            //root.left = new TreeNodeNextPointer(2);
            //root.right = new TreeNodeNextPointer(3);

            //root.left.left = new TreeNodeNextPointer(4);
            //root.left.right = new TreeNodeNextPointer(5);

            //root.right.left = new TreeNodeNextPointer(6);
            //root.right.left.left = new TreeNodeNextPointer(7);

            //ConnectsNodesAtSameLevel.connectNodesAtSameLevelBinaryTreeDFS(root);
            //Console.ReadKey();
            #endregion

            #region Find All Duplicates in an Array
            //int[] nums = { 1, 3, 4, 2, 2 };
            //var result = FindTheDuplicateNumber.FindDuplicate(nums);
            //Console.WriteLine(result);
            //Console.Read();
            #endregion

            #region Maximum Binary Tree
            //int[] nums = { 3, 2, 1, 6, 0, 5 };
            //TreeNode node = MaxBinaryTreeClass.MaxTree(nums);
            #endregion

            #region Replace space with %20
            //var result = ReplaceSpaceWithPercentage20String.UrlifyString("Mr John Smith     ", 13);
            //Console.Read();
            #endregion

            #region Sort the Stack ASC
            //Stack<int> stack = new Stack<int>();
            //// [34, 3, 31, 98, 92, 23]

            //stack.Push(34);
            //stack.Push(3);
            //stack.Push(31);
            //stack.Push(98);
            //stack.Push(92);
            //stack.Push(23);

            //SortStackUsingTempStack.SortStackAscendingOrder(stack);
            #endregion

            #region House Robber
            //int[] nums = { 2, 1, 1, 2 };
            //HouseRobber.MaximumAmountRobbedFromHouse(nums);
            #endregion

            #region Subtract, Multiply, Add and Divide using only Add operator
            //var result = ArithmaticOperationsUsingAddSign.Multiply(2, -4);
            #endregion

            #region Design Add Search Words
            //DesignAddAndSearchWords words = new DesignAddAndSearchWords();
            //words.AddWord("bad");
            //words.AddWord("mad");
            //words.AddWord("dad");
            //bool result = words.Search("pad");
            //result = words.Search("bad");
            //result = words.Search("bad");
            //result = words.Search(".ad");
            //result = words.Search("b..");
            #endregion

            #region Factor Combinations
            //var result = FactorCombinations.GetAllFactorCombinations(8);
            #endregion

            #region Overlapping Interval Min Count - Pending

            //{ 6,8}, { 1,9}, { 2,4}, { 4,7}
            //[1,2], [2,3], [3,4], [1,3]

            //Interval[] listInterval = new Interval[4];

            //listInterval[0] = new Interval();
            //listInterval[1] = new Interval();
            //listInterval[2] = new Interval();
            //listInterval[3] = new Interval();

            //listInterval[0].start = 1;
            //listInterval[0].end = 2;

            //listInterval[1].start = 2;
            //listInterval[1].end = 3;

            //listInterval[2].start = 3;
            //listInterval[2].end = 4;

            //listInterval[3].start = 1;
            //listInterval[3].end = 3;

            ////Interval interval1 = new Interval();
            ////interval1.start = 2;
            ////interval1.end = 6;

            ////Interval interval2 = new Interval();
            ////interval2.start = 8;
            ////interval2.end = 10;

            ////Interval interval3 = new Interval();
            ////interval3.start = 15;
            ////interval3.end = 18;

            //NonOverlappingIntervalsClass objNonOverLappingInterval = new NonOverlappingIntervalsClass();
            //var result1 = objNonOverLappingInterval.CountNonOverlappingIntervals(listInterval);

            //Console.Read();
            #endregion

            #region Count components in Linked List
            //    //7->5->9->4->6
            ////[7,2,4,3]
            ////[5,6,4]

            //    //3,4,2,7
            //    //4,6,5

            //ListNode head1 = new ListNode(1);
            //head1.next = new ListNode(2);
            //head1.next.next = new ListNode(4);
            ////head1.next.next.next = new ListNode(4);

            //int[] G = { 1, 2 };
            //var result1 = FindComponentsInLinkedList.ComponentsInLinkedList(head1, G);

            //    // Print the final list
            //    //resultedList.PrintLinkedListNodes();


            #endregion

            #region Valid Word Abbreviation
            //string s1 = "internationalization";
            //string abbr = "i12iz4n";
            //string s1 = "apple";
            //string abbr = "a2e";
            //var result1 = ValidWordAbbrevationClass.IsValidWordAbbr(s1, abbr);
            #endregion

            #region Valid Word Square
            //List<string> list = new List<string>
            //{
            //    "abcd",
            //    "bnrt",
            //    "crm",
            //    "dt"
            //};
            //var result1 = ValidWordSquareClass.IsValidWordSquare(list);
            #endregion

            #region Find Common in Three Sorted Array elements

            //int[] ar1 = { 1, 5, 5 };
            //int[] ar2 = { 3, 4, 5, 5, 10 };
            //int[] ar3 = { 5, 5, 10, 20 };
            //var result = FindCommonThreeSortedArray.FindCommon(ar1, ar2, ar3);

            #endregion

            #region House Robber III
            //TreeNode root = new TreeNode(2);
            //root.left = new TreeNode(1);
            //root.left.right = new TreeNode(4);
            //root.right = new TreeNode(3);
            //var result = HouseRobberIII.HouseRoberIII(root);
            #endregion

            #region Spiral Matrix
            int[,] nums = new int[5, 5]
            {
                { 1,2,3,4,5},
                { 16,17,18,19,6},
                { 15,24,25,20,7},
                { 14,23,22,21,8},
                { 13,12,11,10,9},
            };

            ShiftMatrixByOneSpiralMatrix.ShiftMatrix(nums);
            Console.WriteLine(/*result*/);
            Console.Read();
            #endregion

        }
    }
}
