using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class LetterCombinationPhoneNumber
    {
        /// <summary>
        /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
        //  A mapping of digit to letters(just like on the telephone buttons) is given below.Note that 1 does not map to any letters.
        //  Example:
        //  Input: "23"
        //  Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
        //  Note:
        //  Although the above answer is in lexicographical order, your answer could be in any order you want.
        //  </summary>
        //  <param name="digits"></param>
        // <returns></returns>
        public static List<string> LetterCombination(string digits)
        {
            List<string> result = new List<string>();
            if (digits == null || digits.Length < 1)
            {
                return result;
            }

            Dictionary<char, char[]> dict = new Dictionary<char, char[]>();
            dict.Add('2', new char[] { 'a', 'b', 'c' });
            dict.Add('3', new char[] { 'd', 'e', 'f' });
            dict.Add('4', new char[] { 'g', 'h', 'i' });
            dict.Add('5', new char[] { 'j', 'k', 'l' });
            dict.Add('6', new char[] { 'm', 'n', 'o' });
            dict.Add('7', new char[] { 'p', 'q', 'r','s' });
            dict.Add('8', new char[] { 't', 'u', 'v' });
            dict.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            helper(result, digits, dict, 0, new StringBuilder());
            return result;
        }

        public static void helper(List<string> result, string digits, Dictionary<char, char[]> dict, int index, StringBuilder sb)
        {
            if (index >= digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }

            char ch = digits[index];
            char[] arr = dict[ch];

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                helper(result, digits, dict, index + 1, sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
