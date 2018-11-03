using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ExcelSheetColumnTitle
    {
        //  <summary>
        //  Given a positive integer, return its corresponding column title as appear in an Excel sheet.
        //  For example:
        //  1 -> A
        //  2 -> B
        //  3 -> C
        //  ...
        //  26 -> Z
        //  27 -> AA
        //  28 -> AB
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        //  Ask Prakash why it is not submitting in Leetcode
        public static string GetExcelColumnTitle(int n)
        {
            // idea is quite simple here
            // 1. we need stringbuilder to store the output
            // 2. we will have loop till n > 0
            // 3. we will insert the value always at first position of the string builder by taking mod
            // 4. we will reduce the value of n by n / 26

            StringBuilder columnTitle = new StringBuilder();

            while (n > 0)
            {
                // Think of it as normalizing the integer result to A through Z. after deducting -1 from n
                // e.g. if n is 25, n & = 25, so ‘A’ + 25 = 'Z’
                // e.g. if n is 26, n & = 0, so ‘A’ + 0 = ‘A’
                // e.g. if n is 27, n & = 1, so ‘A’ + 1 = ‘B’
                // so it appropriate maps the n value to the correct integer
                // if n is 1 -> A + 0 will return A
                // if n is 26 -> A + 25 will return Z
                n--;
                columnTitle.Insert(0, (char)('A' + n % 26));
                n = n / 26;
            }

            return columnTitle.ToString();
        }
    }
}
