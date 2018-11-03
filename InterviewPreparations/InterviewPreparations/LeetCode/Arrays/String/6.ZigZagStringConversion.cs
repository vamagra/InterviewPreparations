using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ZigZagStringConversion
    {
        // <summary>
        // The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
        //        P A   H N
        // A P L S I I G
        // Y   I R
        // And then read line by line: "PAHNAPLSIIGYIR"
        // Write the code that will take a string and make this conversion given a number of rows:
        // string convert(string text, int nRows);
        // convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
        // </summary>
        // <param name="str"></param>
        // <param name="numRows"></param>
        // <returns></returns>
        public static string Convert(string str, int numRows)
        {
            // if number of rows are less than one
            if (numRows <= 1 || str.Length == 1)
            {
                return str;
            }

            // make string builder array of given number of rows
            StringBuilder[] list = new StringBuilder[numRows];

            for (int i = 0; i < numRows; i++)
            {
                list[i] = new StringBuilder();
            }

            bool down = true;
            int row = 0;

            for (int i = 0; i < str.Length; i++)
            {
                list[row].Append(str[i]);

                if (row == 0)
                {
                    down = true;
                }

                if (row == numRows - 1)
                {
                    down = false;
                }

                if (down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            var resultedString = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                resultedString.Append(list[i]);
            }

            return resultedString.ToString();
        }
    }
}
