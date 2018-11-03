using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given a column title as appear in an Excel sheet, return its corresponding column number.
    //  For example:
    //  A -> 1
    //  B -> 2
    //  C -> 3
    //  ...
    //  Z -> 26
    //  AA -> 27
    //  AB -> 28 
    /// </summary>
    class ExcelSheetColumnNumber
    {
        public static int TitleOfColumnNumber(string s)
        {
            // Idea is quite simple here
            // 1. loop through the string
            // 2. multiply resulted column number with 26 in every iteration of loop
            // 3. add the char value from string and - 'A' do + 1 as well to correct mapping
            // 4. add the char value in resulted column number as well

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int columnNumber = 0;

            for (int i = 0; i < s.Length; i++)
            {
                columnNumber = columnNumber * 26;
                columnNumber = columnNumber + (s[i] - 'A') + 1;
            }

            return columnNumber;
        }
    }
}
