using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LargestNumber
    {
        /// <summary>
        /// Given a list of non negative integers, arrange them such that they form the largest number.
        //  For example, given[3, 30, 34, 5, 9], the largest formed number is 9534330.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string LargestNumberStringInput(int[] nums)
        {
            // Given two numbers X and Y, how should myCompare() decide 
            // which number to put first – we compare two numbers XY(Y 
            // appended at the end of X) and YX(X appended at the end of Y)
            // .If XY is larger, then X should come before Y in output, 
            // else Y should come before.For example, let X and Y be 542 
            // and 60.To compare X and Y, we compare 54260 and 60542.
            // Since 60542 is greater than 54260, we put Y first.

            if (nums.Length < 1)
            {
                return "";
            }

            //Step1 - Create string array and convert the int array to string array
            string[] strNumberArray = new string[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                strNumberArray[i] = Convert.ToString(nums[i]);
            }

            Array.Sort(strNumberArray, new comparerString());

            //if there is only Zeros (0)
            if(strNumberArray[0] == "0")
            {
                return "0";
            }

            StringBuilder sbResult = new StringBuilder();

            foreach(string s in strNumberArray)
            {
                sbResult.Append(s);
            }

            return sbResult.ToString();
        }
    }

    public class comparerString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            string s1 = x + y;
            string s2 = y + x;

            return s2.CompareTo(s1);
        }
    }
}
