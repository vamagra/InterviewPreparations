using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.String
{
    class WordExistsKeyBoardRow
    {
        /// <summary>
        //  Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
        //  American keyboard
        //  Example 1:
        //  Input: ["Hello", "Alaska", "Dad", "Peace"]
        //  Output: ["Alaska", "Dad"]
        //  Note:
        //  You may use one character in the keyboard more than once.
        //  You may assume the input string will only contain letters of alphabet.
        //  </summary>
        //  <param name="words"></param>
        //  <returns></returns>
        public static string[] KeyboardRow(string[] words)
        {
            if (words == null || words.Length < 1)
            {
                return words;
            }

            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"q",1},{"w",1},{"e",1},{"r",1},{"t",1},{"y",1},{"u",1},{"i",1},{"o",1},{"p",1},
                {"a",2},{"s",2},{"d",2},{"f",2},{"g",2},{"h",2},{"j",2},{"k",2},{"l",2},
                {"z",3},{"x",3},{"c",3},{"v",3},{"b",3},{"n",3},{"m",3}
            };

            List<string> list = new List<string>();
            foreach (string word in words)
            {
                string newWord = word.ToLower();
                int currNumber = 0;
                int lastNumber = 0;
                bool differentRow = false;

                foreach (char ch in word)
                {
                    currNumber = dict[ch.ToString()];

                    if (lastNumber == 0)
                    {
                        lastNumber = currNumber;
                    }

                    if (currNumber != lastNumber)
                    {
                        differentRow = true;
                        break;
                    }
                }

                if (!differentRow)
                {
                    list.Add(newWord);
                }
            }

            string[] resultArray = new string[list.Count];
            int counter = 0;

            foreach (string s in list)
            {
                resultArray[counter++] = s;
            }

            return resultArray;
        }
    }
}
