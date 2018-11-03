using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public static class ArrayQuestions
    {

        #region Rearrange an array in maximum minimum form
        //Input  : arr[] = {1, 2, 3, 4, 5, 6, 7} 
        //Output : arr[] = {7, 1, 6, 2, 5, 3, 4}

        //Input  : arr[] = {1, 2, 3, 4, 5, 6} 
        //Output : arr[] = {6, 1, 5, 2, 4, 3}

        //First Solution is, Loop the Array of elements and if index is 0 or even then find the Maximum from the List and if
        //Index is Odd then find the minimum from the list and print the list.

        //Second Solution, take Max and Min pointers and print the elements one by one by looping through the array, we can also store 
        //these values in different array and then print the output array.


        //Below Solution is not working
        public static void ReArrangeArrayMaxandMinForm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int maxPointer = arr.Length - 1;
            //int minPointer = 0;
            int n = arr.Length;
            // Traverse through all numbers
            for (int i = 0; i < n; i++)
            {
                int temp = arr[i];

                // If number is negative then we have already
                // processed it. Else process all numbers which
                // are to be replaced by each other in cyclic way
                while (temp > 0)
                {
                    // Find the index where arr[i] should go
                    int j = (i < n / 2) ? 2 * i + 1 : 2 * (n - 1 - i);

                    // If arr[i] is already at its correct
                    // position, mark it as negative
                    if (i == j)
                    {
                        arr[i] = -temp;
                        break;
                    }

                    // Swap the number 'temp' with the current number
                    // at its target position
                    //swap(temp, arr[j]);

                    int swapTemp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapTemp;

                    // Mark the number as processed
                    arr[j] = -arr[j];

                    // Next process the previous number at target position
                    i = j;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
        #endregion
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = a;
        }

        #region Count Strictly Increasing Subarrays

        //My Solution is loop through the array and check if the elements are greater than from current 
        //value increase the resulted Counter, if not then increase the loop counter

        // Given an array of integers, count number of subarrays (of size more than one) that are strictly increasing.
        // Expected Time Complexity : O(n)
        // Expected Extra Space: O(1)

        //Examples: 
        //Input: arr[] = {1, 4, 3}
        //Output: 1
        //There is only one subarray {1, 4}

        //Input: arr[] = {1, 2, 3, 4}
        //Output: 6
        //There are 6 subarrays {1, 2}, {1, 2, 3}, {1, 2, 3, 4}
        //                      {2, 3}, {2, 3, 4} and {3, 4}

        //Input: arr[] = {1, 2, 2, 4}
        //Output: 2
        //There are 2 subarrays {1, 2} and {2, 4}

        #region Mine Solution Time Complexity O(n3)
        public static void CountStrictlyIncreasingSubarrays()
        {
            //int[] InputArray = { 1, 4, 3 };

            int[] InputArray = { 1, 2, 2, 4 };
            int resultedCounter = 0;
            int subCounter = 1;
            int lastPos;

            for (int startPos = 0; startPos <= InputArray.Length - 1; startPos++)
            {
                for (int endPos = startPos + 1; endPos <= InputArray.Length - 1; endPos++)
                {
                    if (IsSubarray(startPos, endPos, InputArray))
                    {
                        resultedCounter++;
                    }
                }
            }

            Console.WriteLine("Number of Sub Array is :" + resultedCounter);

            Console.ReadKey();
        }

        public static bool IsSubarray(int starPos, int endPost, int[] arr)
        {
            bool isSubArray = false;

            for (int j = endPost; j > starPos; j--)
            {
                if (arr[j] > arr[j - 1])
                {
                    isSubArray = true;
                }
                else
                {
                    break;
                }
            }

            return isSubArray;
        }


        #endregion

        public static int countIncreasing(int[] arr, int n)
        {
            // Initialize count of subarrays as 0
            int cnt = 0;

            // Pick starting point
            for (int i = 0; i < n; i++)
            {
                // Pick ending point
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[j - 1])
                        cnt++;

                    // If subarray arr[i..j] is not strictly 
                    // increasing, then subarrays after it , i.e., 
                    // arr[i..j+1], arr[i..j+2], .... cannot
                    // be strictly increasing
                    else
                        break;
                }
            }
            return cnt;
        }

        #endregion

        #region Caculate Water Quanity between Towers

        //My Solution is : Traverse the Tower Weights from Tower 2 (array index 1) and find out the next largest tower ahead and 
        //set the next pointer.

        public static void CalculateWaterQuantityBetweenTowers()
        {
            int[] towersWeight = { 10, 8, 6, 4, 5, 7, 9 };
            Stack<int> stIndex = new Stack<int>();

            int totalWaterQuantity = 0;
            int nextIndexCounter = 0;

            int currentIndex = 0;
            int previousIndex = 0;
            int nextIndex = 0;
            int i = 1;

            while (i < towersWeight.Length)
            {
                currentIndex = i;
                previousIndex = i - 1;

                if (stIndex.Count <= 0)
                {
                    nextIndex = i + 1;
                }

                int baseValue = 0;

                if (towersWeight[nextIndex] > towersWeight[currentIndex]) //To check wheather Next Tower is bigger than current tower
                {
                    if (towersWeight[previousIndex] < towersWeight[nextIndex])
                    {
                        if (towersWeight[previousIndex] > towersWeight[currentIndex])
                        {
                            baseValue = towersWeight[previousIndex];
                        }
                    }
                    else
                    {
                        baseValue = towersWeight[nextIndex];
                    }

                    if (baseValue != 0)
                    {
                        totalWaterQuantity = totalWaterQuantity + (baseValue - towersWeight[currentIndex]);

                        //run the loop from Next Value
                        for (int stCounter = 0; stCounter <= stIndex.Count; stCounter++)
                        {
                            int stPopup = stIndex.Pop();


                            totalWaterQuantity = totalWaterQuantity + (baseValue - towersWeight[stPopup]);
                        }
                    }

                    i = nextIndex + 1;
                }
                else //if Next Tower is less than currentTower then store the indexes in stack;
                {
                    stIndex.Push(nextIndex);
                    nextIndex = nextIndex + 1;
                    //i++;
                }
            }

            Console.WriteLine("Total Number of Water Quantity is: " + totalWaterQuantity);
            Console.ReadKey();
        }
        #endregion

        #region Form minimum number from Given Sequence

        public static void FormMinimumNumberGivenSequence(String str)
        {

            String result = "";

            char[] s = str.ToCharArray();

            Stack<int> stack = new Stack<int>();

            int i = 0, n = 1;

            while (i < s.Length)
            {
                switch (s[i])
                {

                    case 'I':

                        result = result + n;

                        while (stack.Count > 0)
                        {
                            result = result + stack.Pop();
                        }

                        n++; i++;

                        break;

                    case 'D':
                        stack.Push(n);
                        n++;
                        i++;

                        break;
                }
            }

            result = result + n;

            while (stack.Count > 0)
            {
                result = result + stack.Pop();
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
        #endregion

        #region Merge Two Sorted Array

        //Solution http://ideone.com/kwgTWD According to this solution swap the smallest element from second array to first array 
        //and sort the second array elements after every swap.

        public static void MergeTwoSortedArrays()
        {
            int[] array1 = { 1, 5, 9, 10, 15, 20 };
            int[] array2 = { 2, 3, 8, 13 };

            int lenght = 0;

            if (array1.Length > array2.Length)
            {
                lenght = array2.Length;
            }

            int firstArrayPointer = 0;
            int secondArrayPointer = 0;
            int counter = 0;

            while (counter < lenght)
            {
                //check if first Array Value if greater than second Array value.
                if (array1[firstArrayPointer] > array2[secondArrayPointer])
                {
                    //swap the value from second array to first array.

                    int temp = array1[firstArrayPointer];
                    array1[firstArrayPointer] = array2[secondArrayPointer];
                    array2[secondArrayPointer] = temp;
                }
                else //move the first Array pointer ahead if value if less than first array.
                {
                    firstArrayPointer++;
                }
            }
        }
        #endregion

        #region print string in Zig Zag number of rows

        public static void PrintZigZagString()
        {
            //string str = "ABCDEFGH";
            //int numOfRows = 2;

            string str = "GEEKSFORGEEKS";

            char[] inputString = str.ToCharArray();
            int numOfRows = 3;

            int counter = 0;
            int counterPrintChar = 0;

            int rowCounter = 1;
            int rowNumber = 1;

            bool isBack = false;

            while (counter <= inputString.Length - 1)
            {
                if (rowNumber == rowCounter)
                {
                    if (inputString[counter] != '0')
                    {
                        Console.Write(inputString[counter]);
                    }

                    inputString[counter] = '0';

                    if (rowCounter != numOfRows)
                        isBack = false;
                }

                if (isBack)
                {
                    if (rowNumber == 1)
                    {
                        isBack = false;
                    }
                    else
                    {
                        rowNumber--;
                    }
                }
                else
                {
                    rowNumber++;

                    if (rowNumber == numOfRows)
                    {
                        isBack = true;
                    }
                }

                if (counter == inputString.Length - 1 && rowCounter != numOfRows)
                {
                    counter = 0;
                    rowCounter++;
                    rowNumber = 1;
                    isBack = false;
                }
                else
                {
                    counter++;
                }
            }

            Console.ReadKey();
        }


        #endregion

        #region Reverse sub array of Array

        public static void ReverseSubarrayofArray()
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 67, 10 };

            int startIndex = 5;
            int endIndex = 6;

            while (startIndex <= endIndex)
            {
                int temp = inputArray[startIndex];
                inputArray[startIndex] = inputArray[endIndex];
                inputArray[endIndex] = temp;
                startIndex++;
                endIndex--;
            }

            for (int j = 0; j < inputArray.Length; j++)
            {
                Console.WriteLine(inputArray[j]);
            }

            Console.ReadKey();
        }

        #endregion

        #region Total count integers which have at-least one zero

        public static void CountTotalZeroinDigitNumber()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            long counter = MathPow(10, inputNumber);
            int indexCounter = 0;
            int numberOfZeros = 0;

            while (indexCounter < counter)
            {
                if (indexCounter > 0 && indexCounter % 10 == 0)
                {
                    numberOfZeros++;
                }
                indexCounter = indexCounter + 10;
            }

            Console.WriteLine(numberOfZeros);
            Console.ReadKey();
        }

        private static long MathPow(int num, int exp)
        {
            int index = 1;
            long result = num;

            while (index < exp)
            {
                result = result * num;
                exp--;
            }

            return result;
        }

        #endregion

        #region Binary Serach

        public static void BinarySearch(int searchItem)
        {
            int[] arrayItem = { 3, 5, 7, 8, 10, 16, 30, 40, 50 };

            int counter = 0;
            int midItem = arrayItem.Length / 2;
            int lowIndex = 0;
            int highIndex = arrayItem.Length;
            int searchIndex = 0;

            while (lowIndex < highIndex)
            {
                if (arrayItem[midItem] > searchItem)
                {
                    highIndex = midItem;
                    midItem = (highIndex - lowIndex) / 2;
                }

                if (arrayItem[midItem] < searchItem)
                {
                    lowIndex = midItem;
                    midItem = (highIndex + lowIndex) / 2;
                }

                if (arrayItem[midItem] == searchItem)
                {
                    searchIndex = midItem;
                    break;
                }

            }

            Console.WriteLine("Item Found at position" + (searchIndex + 1));
            Console.ReadKey();

        }

        #endregion

        #region Selection Sort

        /// <summary>
        /// Find the smallest element in the list and replace it with first element in phase 1 and do the same for rest of the elements.
        /// </summary>
        public static void SelectionSort()
        {
            int[] inputArray = { 20, 6, 10, 11, 14, 19, 2, 4 };

            int smallestValue = inputArray[0];
            int sortedIndex = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                smallestValue = inputArray[i];
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (smallestValue > inputArray[j])
                    {
                        smallestValue = inputArray[j];
                        sortedIndex = j;
                    }
                }

                int temp = inputArray[i];
                inputArray[i] = smallestValue;
                inputArray[sortedIndex] = temp;
            }

            Console.WriteLine("-------------------Sorted Array---------------");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }

            Console.ReadKey();
        }

        #endregion

        #region Bubble Sort

        public static void BubbleSort()
        {

            int[] inputArray = { 5, 10, 3, 2, 16, 10, 8, 9, 6 };

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }

        }

        #endregion

        public static int findSentance()
        {
            //string s = "we test coders. give us a Try?";
            string s = "Forget CVs..Save time . x x";


            int count = 0;
            int maxCount = 0;
            bool isLastChar = false;

            if (s.Length >= 1)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == s.Length - 1 && (s[i] == '.' || s[i] == '!' || s[i] == '?'))
                    {
                        //count++;
                    }
                    else if ((s[i] == ' ' && s[i + 1] != ' ' && s[i + 1] != '.' && s[i + 1] != '?')
                        || (s[i] == '.' && s[i + 1] != ' ' && s[i + 1] != '.' && s[i + 1] != '?')
                        || (s[i] == '?' && s[i + 1] != ' ' && s[i + 1] != '.' && s[i + 1] != '?')
                        || (s[i] == '!' && s[i + 1] != ' ' && s[i + 1] != '.' && s[i + 1] != '?'))
                    {
                        count++;
                    }

                    if (i == s.Length - 1 && (s[i] == '.' || s[i] == '!' || s[i] == '?'))
                    {
                        maxCount = count;
                        count = 0;
                    }
                    else if ((s[i] == '.' && s[i + 1] != '.' && s[i + 1] != '!' && s[i + 1] != '?')
                        || (s[i] == '?' && s[i + 1] != '?' && s[i + 1] != '.' && s[i + 1] != '!')
                        || (s[i] == '!' && s[i + 1] != '!' && s[i + 1] != '.' && s[i + 1] != '?'))
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                            count = 0;
                        }
                    }
                }
            }

            return maxCount;

        }

        public static int preFixpermutation()
        {
            int[] A = { 2, 1, 3, 5, 4 };

            int indexTotal = 0;
            int runningTotal = 0;
            int resultCount = 0;

            if (A.Length == 1 && A[0] == 1)
            {
                resultCount = 1;
            }

            if (A.Length > 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    indexTotal = indexTotal + (i + 1);
                    runningTotal = runningTotal + A[i];

                    if (indexTotal == runningTotal)
                    {
                        resultCount++;
                    }
                }
            }

            return resultCount;
        }

        public static bool IsSortArrayWithSingleSwap()
        {
            //int[] A = { 1, 5, 3, 3, 7 };
            int[] A = { 3, 2, 1 };
            //int[] A = { 2, 1, 4, 3};
            //int[] A = { 1, 3, 5, 3, 4 };

            int temp = 0;
            int swaps = 0;

            int i = 0;
            bool flag = true;
            bool result = true;
            bool isSameComarison = true;
            int nextEle = 0;
            int firstEle = 0;
            while (flag)
            {
                flag = false;
                i = 0;

                while (i < A.Length - 1)
                {
                    if (nextEle == A[i + 1] && firstEle == A[i])
                    {
                        isSameComarison = false;
                    }
                    else
                    {
                        isSameComarison = true;
                    }

                    if (A[i] > A[i + 1] && isSameComarison)
                    {
                        nextEle = A[i + 1];
                        firstEle = A[i];
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swaps++;
                        flag = true;
                    }
                    i++;
                }

                //if(swaps >1)
                //{
                //    break;
                //}
            }

            if (swaps > 1)
            {
                result = false;
            }

            return result;

            //bool isSwap = false;
            //int temp = 0;

            //for (int i = A.Length - 1; i > 0; i--)
            //{
            //    if (A[i] < A[i - 1])
            //    {
            //        int j = i - 1;

            //        while (j >= 0 && A[i] < A[j])
            //        {
            //            j--;
            //        }

            //        isSwap = true;

            //        temp = A[i];
            //        A[i] = A[j + 1];
            //        A[j + 1] = temp;
            //        break;
            //    }
            //}

            //for(int i=1;i<A.Length-1;i++)
            //{
            //    if(A[i] < A[i-1])
            //    {
            //        return false;
            //    }
            //}

            //return isSwap;
        }

        public static bool IsSubSequenceOfString()
        {
            bool IsSubsequence = false;
            string str1 = "AXY";
            string str2 = "ABCXGFYTR";

            int j = 0;

            for (int i = 0; i <= str2.Length; i++)
            {
                if (str1[j] == str2[i])
                {
                    j++;

                    if (j == str1.Length)
                    {
                        IsSubsequence = true;
                        break;
                    }

                }
            }

            return IsSubsequence;
        }

        public static bool IsSubSequenceOfStringRecursion(string subString, string mainString, int subStringCounter, int mainStringCounter)
        {
            bool IsSubsequence = false;
            //string str1 = "AXY";
            //string str2 = "ABCXGFYTR";

            //for (int i = 0; i <= str2.Length; i++)
            //{
            if (subString[subStringCounter] == mainString[mainStringCounter])
            {
                subStringCounter++;

                if (subStringCounter == subString.Length)
                {
                    IsSubsequence = true;
                    return IsSubsequence;
                }
            }

            IsSubSequenceOfStringRecursion(subString, mainString, subStringCounter, ++mainStringCounter);
            //}

            return IsSubsequence;
        }

        public static string FindSubSequenceFromTwoStrings()
        {
            string str1 = "ABCDGH";
            string str2 = "AEDFHR";

            //if(str1.Length == str2.Length)
            //{
            //    int j = 0;
            //    for(int str1Counter=0;str1Counter<str1.Length;str1Counter++)
            //    {

            //    }


            ////}

            return "";
        }

        public static int maxSubArraySum(int[] a, int size)
        {
            int max_so_far = a[0];
            int curr_max = a[0];

            for (int i = 1; i < size; i++)
            {
                curr_max = max(a[i], curr_max + a[i]);
                max_so_far = max(max_so_far, curr_max);
            }
            return max_so_far;

        }

        private static int max(int first, int second)
        {
            return first > second ? first : second;
        }


        public static void findGeometricTriplets(int[] arr, int n)
        {
            // One by fix every element as middle element
            for (int j = 1; j < n - 1; j++)
            {
                // Initialize i and k for the current j
                int i = j - 1, k = j + 1;

                // Find all i and k such that (i, j, k)
                // forms a triplet of GP
                while (i >= 0 && k <= n - 1)
                {
                    // if arr[j]/arr[i] = r and arr[k]/arr[j] = r
                    // and r is an integer (i, j, k) forms Geometric
                    // Progression
                    while (arr[j] % arr[i] == 0 &&
                            arr[k] % arr[j] == 0 &&
                            arr[j] / arr[i] == arr[k] / arr[j])
                    {
                        // print the triplet
                        //cout << arr[i] << " " << arr[j]
                        //     << " " << arr[k] << endl;

                        // Since the array is sorted and elements
                        // are distinct.
                        k++;
                        i--;
                    }

                    // if arr[j] is multiple of arr[i] and arr[k] is
                    // multiple of arr[j], then arr[j] / arr[i] !=
                    // arr[k] / arr[j]. We compare their values to
                    // move to next k or previous i.
                    if (arr[j] % arr[i] == 0 &&
                            arr[k] % arr[j] == 0)
                    {
                        if (arr[j] / arr[i] < arr[k] / arr[j])
                            i--;
                        else k++;
                    }

                    // else if arr[j] is multiple of arr[i], then
                    // try next k. Else, try previous i.
                    else if (arr[j] % arr[i] == 0)
                        k++;
                    else i--;
                }
            }
        }

        public static int maxSumRotation(int[] arr, int n)
        {
            // Initialize result
            int res = int.MinValue;

            // Consider rotation beginning with i
            // for all possible values of i.
            for (int i = 0; i < n; i++)
            {

                // Initialize sum of current rotation
                int curr_sum = 0;

                // Compute sum of all values. We don't
                // acutally rotation the array, but compute
                // sum by finding ndexes when arr[i] is
                // first element
                for (int j = 0; j < n; j++)
                {
                    int index = (i + j) % n;
                    curr_sum += j * arr[index];
                }

                // Update result if required
                res = max(res, curr_sum);
            }

            return res;
        }


        public static int subArraySum(int[] arr, int n, int sum)
        {
            /* Initialize curr_sum as value of first element
               and starting point as 0 */
            int curr_sum = arr[0], start = 0, i;

            /* Add elements one by one to curr_sum and if the curr_sum exceeds the
               sum, then remove starting element */
            for (i = 1; i <= n; i++)
            {
                // If curr_sum exceeds the sum, then remove the starting elements
                while (curr_sum > sum && start < i - 1)
                {
                    curr_sum = curr_sum - arr[start];
                    start++;
                }

                // If curr_sum becomes equal to sum, then return true
                if (curr_sum == sum)
                {
                    //printf ("Sum found between indexes %d and %d", start, i-1);
                    return 1;
                }

                // Add this element to curr_sum
                if (i < n)
                    curr_sum = curr_sum + arr[i];
            }

            // If we reach here, then no subarray
            //printf("No subarray found");
            return 0;
        }

        public static int[] MergeTwoSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length < 1)
            {
                return nums2;
            }

            if (nums2.Length < 1)
            {
                return nums1;
            }

            int[] MergedArray = new int[nums1.Length + nums2.Length];
            int counter = 0;

            int i = 0;
            int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {

                if (nums1[i] < nums2[j])
                {
                    MergedArray[counter] = nums1[i];
                    i++;
                }
                else
                {
                    MergedArray[counter] = nums2[j];
                    j++;
                }

                counter++;
            }

            while (i < nums1.Length)
            {
                MergedArray[counter] = nums1[i];
                i++;
                counter++;
            }

            while (j < nums2.Length)
            {
                MergedArray[counter] = nums2[j];
                j++;
                counter++;
            }

            return MergedArray;
        }

        public static int[] MergeTwoSortedArraysInPlace(int[] nums1, int[] nums2, int len1, int len2)
        {
            if (nums1.Length < 1)
            {
                return nums2;
            }

            if (nums2.Length < 1)
            {
                return nums1;
            }

            int i = len1 - 1;
            int j = len2 - 1;

            int counter = (len1 + len2) - 1;

            while (counter >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[counter] = nums1[i];
                    i--;
                }
                else
                {
                    nums2[counter] = nums2[j];
                    j--;
                }

                counter--;
            }

            return nums1;
        }
    }
}
