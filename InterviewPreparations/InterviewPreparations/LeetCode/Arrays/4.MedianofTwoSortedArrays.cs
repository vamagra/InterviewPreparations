using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MedianofTwoSortedArrays
    {
        #region FindMedianSortedArraysDifferentSizes
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int Size1 = nums1.Length;
            int Size2 = nums2.Length;

            if (Size1 > Size2)
            {
                return MedianofTwoSortedArraysDiffSize(nums2, 0, Size2, nums1, 0, Size1);
            }
            else
            {
                return MedianofTwoSortedArraysDiffSize(nums1, 0, Size1, nums2, 0, Size2);
            }
        }

        /// <summary>
        /// Here are some of the cases that needs to handle
        /// Case 1 - 
        ///     N=0 and M=2 (first array is empty and second has 2 elements)
        /// Case 2 - 
        ///     N=1 and M=1 
        /// Case 3 - 
        ///     N=1 and M is Odd 
        /// Case 4-
        ///     N=1 and M is Even
        ///     
        /// Case 5 - 
        ///     N=2 and M=2
        /// Case 6 - 
        ///     N=2 and M is Odd 
        /// Case 4-
        ///     N=2 and M is Even
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="m"></param>
        /// <param name="B"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double MedianofTwoSortedArraysDiffSize(int[] A, int startIndexA, int N, int[] B, int startIndexB, int M)
        {
            //Case 1
            if (N == 0)
            {
                if (M == 1)
                {
                    return B[0];
                }

                if (M > 1)
                {
                    return MedianSingle(B, startIndexB, M);
                }
            }

            if (N == 1)
            {
                //Case 2
                if (M == 1)
                {
                    return MO2(A[startIndexA + 0], B[startIndexB + 0]);
                }

                //Case 3
                if (M % 2 == 1)
                {
                    return MO2(B[startIndexB + M / 2], Convert.ToInt32(MO3(A[startIndexA + 0], B[startIndexB + M / 2 - 1], B[startIndexB + M / 2 + 1])));
                }

                //Case 4
                if (M % 2 == 0)
                {
                    return MO3(A[startIndexA + 0], B[startIndexB + M / 2 - 1], B[startIndexB + M / 2]);
                }
            }

            if (N == 2)
            {
                //Case 2
                if (M == 2)
                {
                    return MO4(A[startIndexA + 0], B[startIndexB + 0], A[startIndexA + 1], B[startIndexB + 1]);
                }

                //Case 3
                if (M % 2 == 1)
                {
                    return MO3(B[startIndexB + M / 2], max(A[startIndexA + 0], B[startIndexB + M / 2 - 1]), min(A[startIndexA + 1], B[startIndexB + M / 2 + 1]));
                }

                //Case 4
                if (M % 2 == 0)
                {
                    return MO4(B[startIndexB + M / 2], B[startIndexB + M / 2 - 1], max(A[startIndexA + 0], B[startIndexB + M / 2 - 2]), min(A[startIndexA + 1], B[startIndexB + M / 2 + 1]));
                }
            }

            int midIndexA = (N - 1) / 2;
            int midIndexB = (M - 1) / 2;

            if (A[midIndexA] <= B[midIndexB])
            {
                MedianofTwoSortedArraysDiffSize(A, startIndexA, N / 2 + 1, B, 0, M - midIndexA);
            }
            else
            {
                MedianofTwoSortedArraysDiffSize(A, 0, N/2+1, B, startIndexA, M - midIndexA);
            }

            return 0.0;
        }

        public static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int min(int a, int b)
        {
            return a > b ? b : a;
        }

        public static double MO2(int a, int b)
        {
            return (a + b) / 2.0;
        }

        public static double MO3(int a, int b, int c)
        {
            //return (a + b + c) - (max(a, max(b, c)) - min(a, min(b, c)));
            return max(min(a, b), min(max(a, b), c));
        }

        public static double MO4(int a, int b, int c, int d)
        {
            return ((a + b + c + b) - max(max(a, b), max(c, d)) - min(min(a, b), min(c, d))) / 2.0;
            //return (b+c) / 2.0;
        }

        public static double MedianSingle(int[] A, int startIndex, int n)
        {
            if (n == 0)
            {
                return -1;
            }

            if (n % 2 == 0)
            {
                return (A[startIndex + n / 2] + A[startIndex + n / 2 - 1]) / 2.0;
            }
            else
            {
                return A[startIndex + n / 2];
            }
        }
        #endregion

        #region FindMedianSortedArraysSameSize

        public static double FindMedianSortedArraysSameSize(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            int count = 0;
            int m1 = -1, m2 = -1;
            int N = nums1.Length;
            int M = nums2.Length;

            if (N != M)
            {
                return -1;
            }

            for (count = 0; count <= N; count++)
            {
                if (i == N)
                {
                    m1 = m2;
                    m2 = nums2[0];
                    break;
                }

                if (j == N)
                {
                    m1 = m2;
                    m2 = nums1[0];
                    break;
                }

                if (nums1[i] < nums2[j])
                {
                    m1 = m2;
                    m2 = nums1[i];
                    i++;
                }
                else
                {
                    m1 = m2;
                    m2 = nums2[j];
                    j++;
                }
            }

            return (m1 + m2) / 2.0;
        }

        #endregion

    }
}
