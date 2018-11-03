using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class BasicRegex
    {
        /// <summary>
        /// Basic Regex Parser
        //  Implement a regular expression function isMatch that supports the '.' and '*' symbols.The function receives two strings - text and pattern - and should return true if the text matches the pattern as a regular expression.For simplicity, assume that the actual symbols '.' and '*' do not appear in the text string and are used as special symbols only in the pattern string.
        //  In case you aren’t familiar with regular expressions, the function determines if the text and pattern are the equal, where the '.' is treated as a single a character wildcard(see third example), and '*' is matched for a zero or more sequence of the previous letter(see fourth and fifth examples). For more information on regular expression matching, see the Regular Expression Wikipedia page.
        //  Explain your algorithm, and analyze its time and space complexities.
        //  Examples:
        //  input:  text = "aa", pattern = "a"
        //  output: false
        //  input:  text = "aa", pattern = "aa"
        //  output: true
        //  input:  text = "abc", pattern = "a.c"
        //  output: true
        //  input:  text = "abbb", pattern = "ab*"
        //  output: true
        //  input:  text = "acd", pattern = "ab*c."
        //  output: true
        //  Constraints:
        //  [time limit] 5000ms
        //  [input] string text
        //  [input] string pattern
        //  [output] boolean
        //  </summary>
        //  <param name="text"></param>
        //  <param name="pattern"></param>
        //  <returns></returns>
        public static bool IsMatch(string text, string pattern)
        {
            return IsRegExMatch(text, pattern, 0, 0);
        }

        private static bool IsRegExMatch(string text, string pattern, int tx, int pt)
        {
            // if the text length is equal to text counter tx
            if (tx == text.Length)
            {
                return true;
            }

            // if the text length is equal to text counter tx && pattern length is equal to pattern counter
            if (text.Length == tx && pattern.Length == pt)
            {
                return true;
            }

            // if we reach to below if where pattern length is equal to pattern counter, then return false as text counter is not reached to end
            if (pattern.Length == pt)
            {
                return false;
            }

            if (pattern.ToCharArray()[pt] == '.')
            {
                IsRegExMatch(text, pattern, tx + 1, pt + 1);
            }

            if (text.ToCharArray()[tx] == pattern.ToCharArray()[pt])
            {
                IsRegExMatch(text, pattern, tx + 1, pt + 1);
            }

            // if we encounter "*" in pattern, we just want to move in text
            if (pattern.ToCharArray()[pt] == '*')
            {
                IsRegExMatch(text, pattern, tx + 1, pt);
            }

            // if we encounter "*" in the pattern and pattern previous char is not equal to text current char then return false; 
            if (pattern.ToCharArray()[pt] == '*' && pt > 0 && pattern.ToCharArray()[pt - 1] == text.ToCharArray()[tx])
            {
                return false;
            }

            // if text and pattern charcter is not matching, and next pattern char is *, then we just want to move in pattern
            if (text.ToCharArray()[tx] != pattern.ToCharArray()[pt] && pt < pattern.Length - 1 && pattern.ToCharArray()[pt + 1] == '*')
            {
                IsRegExMatch(text, pattern, tx, pt + 1);
            }

            return false;
        }
    }
}
